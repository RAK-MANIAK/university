using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    public class Packing
    {
            public static void Pack(string path, IEnumerable<FileEntry> files)
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    var root = Path.GetDirectoryName(path);

                    foreach (var file in files)
                    {
                        Pack(stream, file, root);
                    }
                }
            }

            public static void Unpack(string path, IEnumerable<FileEntry> files)
            {
                foreach (var file in files)
                {
                    Unpack(path, file.Path);
                }
            }

            private static void Pack(Stream stream, FileEntry file, string root)
            {
                byte[] content = file.GetBytes();
                byte[] fileName = Encoding.UTF8.GetBytes(file.Name);

                stream.Write(BitConverter.GetBytes(fileName.Length), 0, sizeof(int));
                stream.Write(fileName, 0, fileName.Length);
                stream.Write(BitConverter.GetBytes(content.Length), 0, sizeof(int));
                stream.Write(content, 0, content.Length);
            }

            private static void Unpack(string path, string packedFile)
            {
                using (var stream = new FileStream(packedFile, FileMode.Open))
                {
                    while (stream.Position < stream.Length)
                    {
                        byte[] fileName = ReadBytes(stream);
                        byte[] content = ReadBytes(stream);

                        string combinedPath = Path.Combine(path, Encoding.UTF8.GetString(fileName));
                        string directoryPath = Path.GetDirectoryName(combinedPath);

                        if (Directory.Exists(directoryPath) == false)
                        {
                            Directory.CreateDirectory(directoryPath ?? string.Empty);
                        }

                        var unpackedStream = new FileStream(combinedPath, FileMode.Create);
                        unpackedStream.Write(content, 0, content.Length);
                    }
                }
            }

            private static int ReadInt(Stream stream)
            {
                byte[] bytes = new byte[sizeof(int)];

                _ = stream.Read(bytes, 0, sizeof(int));

                return BitConverter.ToInt32(bytes, 0);
            }

            private static byte[] ReadBytes(Stream stream)
            {
                int size = ReadInt(stream);

                byte[] bytes = new byte[size];
                _ = stream.Read(bytes, 0, size);

                return bytes;
            }
        }
}
