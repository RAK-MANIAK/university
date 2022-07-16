using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Crypt
    {
        public const int Key = 234232589;

        public static void Encrypt(string path, IEnumerable<FileEntry> files, int key)
        {
            foreach (var file in files)
            {
                Encrypt(path, file, key);
            }
        }

        private static void Encrypt(string path, FileEntry file, int key)
        {
            var encr = Getencr(file, key);

            using (var stream = new FileStream(Path.Combine(path, file.Name + ".crypt"), FileMode.Create))
            {
                stream.Write(encr, 0, encr.Length);
            }
        }

        public static void Decrypt(string path, IEnumerable<FileEntry> files, int key)
        {
            foreach (var file in files)
            {
                Decrypt(path, file, key);
            }
        }

        private static void Decrypt(string path, FileEntry file, int key)
        {
            var decr = Getdecr(file, key);

            using (var stream = new FileStream(Path.Combine(path, Path.GetFileNameWithoutExtension(file.Name)),
                       FileMode.Create))
            {
                stream.Write(decr, 0, decr.Length);
            }
        }

        private static byte[] Getencr(FileEntry file, int key)
        {
            byte[] con = file.GetBytes();
            byte[] encr = new byte[con.Length];

            for (int i = 0; i < con.Length; i++)
            {
                encr[i] = (byte)(con[i] ^ key);
            }

            return encr;
        }

        private static byte[] Getdecr(FileEntry file, int key)
        {
            return Getencr(file, key);
        }
    }
}
