namespace ClassLibrary
{
    public class FileEntry
    {
        public string Name { get; }

        public string Path { get; }

        public FileEntry(string path)
        {
            Name = System.IO.Path.GetFileName(path);
            Path = path;
        }

        public FileEntry(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public byte[] GetBytes() => System.IO.File.ReadAllBytes(Path);

        public string GetText() => System.IO.File.ReadAllText(Path);

        public bool IsPacked() => System.IO.Path.GetExtension(Name) == ".gzar";

        public bool IsEncrypted() => System.IO.Path.GetExtension(Name) == ".crypt";
    }
}
