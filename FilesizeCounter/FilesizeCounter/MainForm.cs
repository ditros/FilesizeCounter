using System;
using System.IO;
using System.Windows.Forms;

namespace FilesizeCounter
{
    public partial class MainForm : Form
    {
        private float _fileSize;

        public MainForm()
        {
            InitializeComponent();
        }

        private void RecalculateFileSize()
        {
            if (radioButtonB.Checked)
            {
                labelFileSize.Text = _fileSize.ToString() + " Bytes";
            }

            if (radioButtonKB.Checked)
            {
                var fileSize = _fileSize / 1024f;
                labelFileSize.Text = fileSize.ToString() + " KBytes";
            }

            if (radioButtonMB.Checked)
            {
                var fileSize = _fileSize / 1024f / 1024f;
                labelFileSize.Text = fileSize.ToString() + " MBytes";
            }

            if (radioButtonGB.Checked)
            {
                var fileSize = _fileSize / 1024f / 1024f / 1024f;
                labelFileSize.Text = fileSize.ToString() + " GBytes";
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Images (*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var fileInfo = new FileInfo(fileName);
                _fileSize = fileInfo.Length;

                RecalculateFileSize();
            }
        }

        private void radioButtonGB_CheckedChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(labelFileSize.Text))
            {
                RecalculateFileSize();
            }
        }

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedPath = folderBrowserDialog.SelectedPath;
                var fileNames = Directory.GetFiles(selectedPath, "*.jpg", SearchOption.AllDirectories);

                _fileSize = 0.0f;

                foreach (var fileName in fileNames)
                {
                    var fileInfo = new FileInfo(fileName);
                    _fileSize += fileInfo.Length;
                }

                RecalculateFileSize();
            }
        }
    }
}
