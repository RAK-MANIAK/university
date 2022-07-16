using ClassLibrary;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void archiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                AddExtension = true,
                Filter = "packed files (*.gzar)|*.gzar"
            };
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }
            Packing.Pack(dialog.FileName, listBox1.SelectedItems.Cast<FileEntry>());
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = true
            };
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            listBox1.Items.Clear();

            foreach (var file in dialog.FileNames)
            {
                var fileEntry = new FileEntry(file);

                listBox1.Items.Add(fileEntry);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void unZIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            Packing.Unpack(dialog.SelectedPath, listBox1.SelectedItems.Cast<FileEntry>().Where(file => file.IsPacked()));
        }

        private void encryptSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            Crypt.Encrypt(dialog.SelectedPath, listBox1.SelectedItems.Cast<FileEntry>(), Crypt.Key);
        }

        private void decryptSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            Crypt.Decrypt(dialog.SelectedPath,
            listBox1.SelectedItems.Cast<FileEntry>().Where(file => file.IsEncrypted()), Crypt.Key);
        }


        private void listBoxFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) == false)
            {
                return;
            }

            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string path = Path.GetDirectoryName(files.FirstOrDefault());

            foreach (var file in files)
            {
                if (FileUtils.IsDirectory(file))
                {
                    foreach (var subFile in Directory.EnumerateFiles(file, "*.*", SearchOption.AllDirectories))
                    {
                        listBox1.Items.Add(new FileEntry(FileUtils.GetRelativePath(subFile, path), subFile));
                    }
                }
                else
                {
                    listBox1.Items.Add(new FileEntry(Path.GetFileName(file), file));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
