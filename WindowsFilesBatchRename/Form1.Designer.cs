namespace WindowsFilesBatchRename
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_startwork = new System.Windows.Forms.Button();
            this.btn_chooseFolder = new System.Windows.Forms.Button();
            this.btn_chooseFiles = new System.Windows.Forms.Button();
            this.lbl_filecount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_startwork);
            this.panel1.Controls.Add(this.btn_chooseFolder);
            this.panel1.Controls.Add(this.btn_chooseFiles);
            this.panel1.Controls.Add(this.lbl_filecount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 778);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SourceFileName,
            this.NewFileName,
            this.FilePath,
            this.OptionState});
            this.dataGridView1.Location = new System.Drawing.Point(13, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 718);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 60;
            // 
            // SourceFileName
            // 
            this.SourceFileName.DataPropertyName = "SourceFileName";
            this.SourceFileName.HeaderText = "源文件名称";
            this.SourceFileName.Name = "SourceFileName";
            this.SourceFileName.ReadOnly = true;
            this.SourceFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SourceFileName.Width = 250;
            // 
            // NewFileName
            // 
            this.NewFileName.DataPropertyName = "NewFileName";
            this.NewFileName.HeaderText = "新文件名";
            this.NewFileName.Name = "NewFileName";
            this.NewFileName.ReadOnly = true;
            this.NewFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NewFileName.Width = 250;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "文件路径";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FilePath.Width = 400;
            // 
            // OptionState
            // 
            this.OptionState.DataPropertyName = "OptionState";
            this.OptionState.HeaderText = "操作状态";
            this.OptionState.Name = "OptionState";
            this.OptionState.ReadOnly = true;
            this.OptionState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_startwork
            // 
            this.btn_startwork.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_startwork.Location = new System.Drawing.Point(1019, 8);
            this.btn_startwork.Name = "btn_startwork";
            this.btn_startwork.Size = new System.Drawing.Size(98, 41);
            this.btn_startwork.TabIndex = 3;
            this.btn_startwork.Text = "开始重命名";
            this.btn_startwork.UseVisualStyleBackColor = true;
            // 
            // btn_chooseFolder
            // 
            this.btn_chooseFolder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chooseFolder.Location = new System.Drawing.Point(908, 8);
            this.btn_chooseFolder.Name = "btn_chooseFolder";
            this.btn_chooseFolder.Size = new System.Drawing.Size(98, 41);
            this.btn_chooseFolder.TabIndex = 2;
            this.btn_chooseFolder.Text = "选择文件夹";
            this.btn_chooseFolder.UseVisualStyleBackColor = true;
            this.btn_chooseFolder.Click += new System.EventHandler(this.btn_chooseFolder_Click);
            // 
            // btn_chooseFiles
            // 
            this.btn_chooseFiles.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chooseFiles.Location = new System.Drawing.Point(811, 8);
            this.btn_chooseFiles.Name = "btn_chooseFiles";
            this.btn_chooseFiles.Size = new System.Drawing.Size(91, 41);
            this.btn_chooseFiles.TabIndex = 1;
            this.btn_chooseFiles.Text = "选择文件";
            this.btn_chooseFiles.UseVisualStyleBackColor = true;
            this.btn_chooseFiles.Click += new System.EventHandler(this.btn_chooseFiles_Click);
            // 
            // lbl_filecount
            // 
            this.lbl_filecount.AutoSize = true;
            this.lbl_filecount.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_filecount.Location = new System.Drawing.Point(13, 14);
            this.lbl_filecount.Name = "lbl_filecount";
            this.lbl_filecount.Size = new System.Drawing.Size(124, 27);
            this.lbl_filecount.TabIndex = 0;
            this.lbl_filecount.Text = "文件数量：0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 800);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "批量重命名";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_filecount;
        private Button btn_chooseFiles;
        private Button btn_chooseFolder;
        private Button btn_startwork;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SourceFileName;
        private DataGridViewTextBoxColumn NewFileName;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn OptionState;
    }
}