namespace FilesizeCounter
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.radioButtonGB = new System.Windows.Forms.RadioButton();
            this.radioButtonMB = new System.Windows.Forms.RadioButton();
            this.radioButtonKB = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.comboBoxFileFormat = new System.Windows.Forms.ComboBox();
            this.progressBarFileCount = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "C:\\\\";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 16);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(112, 22);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select File";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(150, 21);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(0, 13);
            this.labelFileSize.TabIndex = 1;
            // 
            // radioButtonGB
            // 
            this.radioButtonGB.AutoSize = true;
            this.radioButtonGB.Location = new System.Drawing.Point(13, 60);
            this.radioButtonGB.Name = "radioButtonGB";
            this.radioButtonGB.Size = new System.Drawing.Size(59, 17);
            this.radioButtonGB.TabIndex = 1;
            this.radioButtonGB.Text = "GBytes";
            this.radioButtonGB.UseVisualStyleBackColor = true;
            this.radioButtonGB.CheckedChanged += new System.EventHandler(this.radioButtonGB_CheckedChanged);
            // 
            // radioButtonMB
            // 
            this.radioButtonMB.AutoSize = true;
            this.radioButtonMB.Checked = true;
            this.radioButtonMB.Location = new System.Drawing.Point(78, 60);
            this.radioButtonMB.Name = "radioButtonMB";
            this.radioButtonMB.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMB.TabIndex = 2;
            this.radioButtonMB.TabStop = true;
            this.radioButtonMB.Text = "MBytes";
            this.radioButtonMB.UseVisualStyleBackColor = true;
            this.radioButtonMB.CheckedChanged += new System.EventHandler(this.radioButtonGB_CheckedChanged);
            // 
            // radioButtonKB
            // 
            this.radioButtonKB.AutoSize = true;
            this.radioButtonKB.Location = new System.Drawing.Point(144, 60);
            this.radioButtonKB.Name = "radioButtonKB";
            this.radioButtonKB.Size = new System.Drawing.Size(58, 17);
            this.radioButtonKB.TabIndex = 3;
            this.radioButtonKB.Text = "KBytes";
            this.radioButtonKB.UseVisualStyleBackColor = true;
            this.radioButtonKB.CheckedChanged += new System.EventHandler(this.radioButtonGB_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(208, 60);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(51, 17);
            this.radioButtonB.TabIndex = 4;
            this.radioButtonB.Text = "Bytes";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonGB_CheckedChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\";
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(12, 103);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(112, 22);
            this.buttonSelectDirectory.TabIndex = 5;
            this.buttonSelectDirectory.Text = "Select Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // comboBoxFileFormat
            // 
            this.comboBoxFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileFormat.FormattingEnabled = true;
            this.comboBoxFileFormat.Items.AddRange(new object[] {
            "All files",
            "jpg",
            "doc",
            "txt",
            "exe",
            "rar"});
            this.comboBoxFileFormat.Location = new System.Drawing.Point(138, 103);
            this.comboBoxFileFormat.Name = "comboBoxFileFormat";
            this.comboBoxFileFormat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFileFormat.TabIndex = 6;
            this.comboBoxFileFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileFormat_SelectedIndexChanged);
            // 
            // progressBarFileCount
            // 
            this.progressBarFileCount.Location = new System.Drawing.Point(13, 135);
            this.progressBarFileCount.Name = "progressBarFileCount";
            this.progressBarFileCount.Size = new System.Drawing.Size(246, 23);
            this.progressBarFileCount.Step = 1;
            this.progressBarFileCount.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 170);
            this.Controls.Add(this.progressBarFileCount);
            this.Controls.Add(this.comboBoxFileFormat);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonKB);
            this.Controls.Add(this.radioButtonMB);
            this.Controls.Add(this.radioButtonGB);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.buttonSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FilesizeCounter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.RadioButton radioButtonGB;
        private System.Windows.Forms.RadioButton radioButtonMB;
        private System.Windows.Forms.RadioButton radioButtonKB;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.ComboBox comboBoxFileFormat;
        private System.Windows.Forms.ProgressBar progressBarFileCount;
    }
}

