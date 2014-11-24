﻿using System;
using System.IO;
using System.Windows.Forms;

namespace FilesizeCounter
{
    public partial class MainForm : Form
    {
        private float _fileSize;
        private string _selectedPath;

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
            progressBarFileCount.Value = 0;
            progressBarFileCount.Maximum = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var fileInfo = new FileInfo(fileName);
                _fileSize = fileInfo.Length;
                progressBarFileCount.Value++;
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
                _selectedPath = folderBrowserDialog.SelectedPath;
                FileFormatChange();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _selectedPath = null;
            comboBoxFileFormat.SelectedIndex = 0;
        }

        private void FileFormatChange()
        {
            var fileFormat = comboBoxFileFormat.SelectedItem.ToString();

            if (fileFormat == "All files")
            {
                fileFormat = "*";
            }

            try
            {
                var fileNames = Directory.GetFiles(_selectedPath, "*." + fileFormat, SearchOption.AllDirectories);

                progressBarFileCount.Value = 0;
                progressBarFileCount.Maximum = fileNames.Length;
                _fileSize = 0.0f;

                foreach (var fileName in fileNames)
                {
                    var fileInfo = new FileInfo(fileName);
                    _fileSize += fileInfo.Length;
                    progressBarFileCount.Value++;
                }

                RecalculateFileSize();
            }
            catch
            {
                MessageBox.Show("Отказано в доступе по пути " + _selectedPath);
            }
        }

        private void comboBoxFileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(_selectedPath))
            {
                FileFormatChange();
            }
        }
    }
}
