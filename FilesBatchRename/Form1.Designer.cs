using System.Windows.Forms;

namespace FilesBatchRename
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Data = new System.Windows.Forms.Panel();
            this.dgvFileData = new System.Windows.Forms.DataGridView();
            this.btn_startwork = new System.Windows.Forms.Button();
            this.btn_chooseFolder = new System.Windows.Forms.Button();
            this.btn_chooseFiles = new System.Windows.Forms.Button();
            this.lbl_filecount = new System.Windows.Forms.Label();
            this.panel_optionSetting = new System.Windows.Forms.Panel();
            this.panelExtensionSetting = new System.Windows.Forms.Panel();
            this.tabExtensionControl = new System.Windows.Forms.TabControl();
            this.tabExtensionCustom = new System.Windows.Forms.TabPage();
            this.txtNewExtension = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabExtensionInsert = new System.Windows.Forms.TabPage();
            this.txtExtensionInsertText = new System.Windows.Forms.TextBox();
            this.lblExtensionInsertText = new System.Windows.Forms.Label();
            this.lblExtensionInsertChar2 = new System.Windows.Forms.Label();
            this.nudExtensionInsertChar = new System.Windows.Forms.NumericUpDown();
            this.lblExtensionInsertChar1 = new System.Windows.Forms.Label();
            this.rdoExtensionInserCustom = new System.Windows.Forms.RadioButton();
            this.rdoExtensionInsertEnd = new System.Windows.Forms.RadioButton();
            this.rdoExtensionInsertStart = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.tabExtensionReplace = new System.Windows.Forms.TabPage();
            this.txtExtensionReplaceText = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtExtensionSearchText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabExtensionDelete = new System.Windows.Forms.TabPage();
            this.lblExtensionDeleteCount2 = new System.Windows.Forms.Label();
            this.nudExtensionDeleteCount = new System.Windows.Forms.NumericUpDown();
            this.lblExtensionDeletePosition2 = new System.Windows.Forms.Label();
            this.lblExtensionDeleteCount1 = new System.Windows.Forms.Label();
            this.txtExtensionDeleteContent = new System.Windows.Forms.TextBox();
            this.nudExtensionDeletePosition = new System.Windows.Forms.NumericUpDown();
            this.lblExtensionDeletePosition1 = new System.Windows.Forms.Label();
            this.rdoExtensionDeleteByPosition = new System.Windows.Forms.RadioButton();
            this.lblExtensionDeleteContent1 = new System.Windows.Forms.Label();
            this.rdoExtensionDeleteByContent = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.cbEnableExtension = new System.Windows.Forms.CheckBox();
            this.panelNumberSetting = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudNumberDigits = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudIncremental = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudInitValue = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNumberCount2 = new System.Windows.Forms.Label();
            this.nudNumberCount = new System.Windows.Forms.NumericUpDown();
            this.rdoNumberCustom = new System.Windows.Forms.RadioButton();
            this.lblNumberCount1 = new System.Windows.Forms.Label();
            this.rdoNumberEnd = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoNumberStart = new System.Windows.Forms.RadioButton();
            this.cbEnableNumber = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEditFileName = new System.Windows.Forms.CheckBox();
            this.tabOptionControl = new System.Windows.Forms.TabControl();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.txtInsertText = new System.Windows.Forms.TextBox();
            this.lblInsertText = new System.Windows.Forms.Label();
            this.lblInsertCharPosition2 = new System.Windows.Forms.Label();
            this.nudInsertCharPosition = new System.Windows.Forms.NumericUpDown();
            this.lblInsertCharPosition1 = new System.Windows.Forms.Label();
            this.rdoInsertCustom = new System.Windows.Forms.RadioButton();
            this.rdoInsertEnd = new System.Windows.Forms.RadioButton();
            this.rdoInsertStart = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.txtReplaceText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.lblDelteCount2 = new System.Windows.Forms.Label();
            this.nudDeleteCount = new System.Windows.Forms.NumericUpDown();
            this.lblDeletePosition2 = new System.Windows.Forms.Label();
            this.lblDeleteCount1 = new System.Windows.Forms.Label();
            this.txtDeleteText = new System.Windows.Forms.TextBox();
            this.nudDeletePosition = new System.Windows.Forms.NumericUpDown();
            this.lblDeletePositon1 = new System.Windows.Forms.Label();
            this.rdoDeleteByPosition = new System.Windows.Forms.RadioButton();
            this.lblDeleteText = new System.Windows.Forms.Label();
            this.rdoDeletebyContent = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_ToggleCase = new System.Windows.Forms.Panel();
            this.rdoAllUp = new System.Windows.Forms.RadioButton();
            this.rdoAllLow = new System.Windows.Forms.RadioButton();
            this.rdoNoToggle = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileData)).BeginInit();
            this.panel_optionSetting.SuspendLayout();
            this.panelExtensionSetting.SuspendLayout();
            this.tabExtensionControl.SuspendLayout();
            this.tabExtensionCustom.SuspendLayout();
            this.tabExtensionInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensionInsertChar)).BeginInit();
            this.tabExtensionReplace.SuspendLayout();
            this.tabExtensionDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensionDeleteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensionDeletePosition)).BeginInit();
            this.panelNumberSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncremental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabOptionControl.SuspendLayout();
            this.tabCustom.SuspendLayout();
            this.tabInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsertCharPosition)).BeginInit();
            this.tabReplace.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeletePosition)).BeginInit();
            this.panel_ToggleCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Data
            // 
            this.panel_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Data.Controls.Add(this.dgvFileData);
            this.panel_Data.Controls.Add(this.btn_startwork);
            this.panel_Data.Controls.Add(this.btn_chooseFolder);
            this.panel_Data.Controls.Add(this.btn_chooseFiles);
            this.panel_Data.Controls.Add(this.lbl_filecount);
            this.panel_Data.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Data.Location = new System.Drawing.Point(12, 11);
            this.panel_Data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(1126, 778);
            this.panel_Data.TabIndex = 0;
            // 
            // dgvFileData
            // 
            this.dgvFileData.AllowUserToAddRows = false;
            this.dgvFileData.AllowUserToResizeColumns = false;
            this.dgvFileData.AllowUserToResizeRows = false;
            this.dgvFileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SourceFileName,
            this.NewFileName,
            this.FilePath,
            this.OptionState});
            this.dgvFileData.Location = new System.Drawing.Point(13, 55);
            this.dgvFileData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFileData.MultiSelect = false;
            this.dgvFileData.Name = "dgvFileData";
            this.dgvFileData.RowTemplate.Height = 25;
            this.dgvFileData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileData.Size = new System.Drawing.Size(1104, 718);
            this.dgvFileData.TabIndex = 4;
            this.dgvFileData.Visible = false;
            this.dgvFileData.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvFileData_UserDeletedRow);
            // 
            // btn_startwork
            // 
            this.btn_startwork.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_startwork.Location = new System.Drawing.Point(1011, 8);
            this.btn_startwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_startwork.Name = "btn_startwork";
            this.btn_startwork.Size = new System.Drawing.Size(98, 41);
            this.btn_startwork.TabIndex = 3;
            this.btn_startwork.Text = "开始重命名";
            this.btn_startwork.UseVisualStyleBackColor = true;
            this.btn_startwork.Click += new System.EventHandler(this.BtnStartWork_Click);
            // 
            // btn_chooseFolder
            // 
            this.btn_chooseFolder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_chooseFolder.Location = new System.Drawing.Point(908, 8);
            this.btn_chooseFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_chooseFolder.Name = "btn_chooseFolder";
            this.btn_chooseFolder.Size = new System.Drawing.Size(98, 41);
            this.btn_chooseFolder.TabIndex = 2;
            this.btn_chooseFolder.Text = "选择文件夹";
            this.btn_chooseFolder.UseVisualStyleBackColor = true;
            this.btn_chooseFolder.Click += new System.EventHandler(this.Btn_chooseFolder_Click);
            // 
            // btn_chooseFiles
            // 
            this.btn_chooseFiles.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_chooseFiles.Location = new System.Drawing.Point(811, 8);
            this.btn_chooseFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_chooseFiles.Name = "btn_chooseFiles";
            this.btn_chooseFiles.Size = new System.Drawing.Size(91, 41);
            this.btn_chooseFiles.TabIndex = 1;
            this.btn_chooseFiles.Text = "选择文件";
            this.btn_chooseFiles.UseVisualStyleBackColor = true;
            this.btn_chooseFiles.Click += new System.EventHandler(this.Btn_chooseFiles_Click);
            // 
            // lbl_filecount
            // 
            this.lbl_filecount.AutoSize = true;
            this.lbl_filecount.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lbl_filecount.Location = new System.Drawing.Point(13, 14);
            this.lbl_filecount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filecount.Name = "lbl_filecount";
            this.lbl_filecount.Size = new System.Drawing.Size(124, 27);
            this.lbl_filecount.TabIndex = 0;
            this.lbl_filecount.Text = "文件总数：0";
            // 
            // panel_optionSetting
            // 
            this.panel_optionSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_optionSetting.Controls.Add(this.panelExtensionSetting);
            this.panel_optionSetting.Controls.Add(this.panelNumberSetting);
            this.panel_optionSetting.Controls.Add(this.panel1);
            this.panel_optionSetting.Controls.Add(this.panel_ToggleCase);
            this.panel_optionSetting.Controls.Add(this.label1);
            this.panel_optionSetting.Location = new System.Drawing.Point(1144, 11);
            this.panel_optionSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_optionSetting.Name = "panel_optionSetting";
            this.panel_optionSetting.Size = new System.Drawing.Size(343, 778);
            this.panel_optionSetting.TabIndex = 1;
            // 
            // panelExtensionSetting
            // 
            this.panelExtensionSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExtensionSetting.Controls.Add(this.tabExtensionControl);
            this.panelExtensionSetting.Controls.Add(this.cbEnableExtension);
            this.panelExtensionSetting.Location = new System.Drawing.Point(4, 557);
            this.panelExtensionSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelExtensionSetting.Name = "panelExtensionSetting";
            this.panelExtensionSetting.Size = new System.Drawing.Size(331, 216);
            this.panelExtensionSetting.TabIndex = 10;
            // 
            // tabExtensionControl
            // 
            this.tabExtensionControl.Controls.Add(this.tabExtensionCustom);
            this.tabExtensionControl.Controls.Add(this.tabExtensionInsert);
            this.tabExtensionControl.Controls.Add(this.tabExtensionReplace);
            this.tabExtensionControl.Controls.Add(this.tabExtensionDelete);
            this.tabExtensionControl.Location = new System.Drawing.Point(4, 42);
            this.tabExtensionControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionControl.Name = "tabExtensionControl";
            this.tabExtensionControl.SelectedIndex = 0;
            this.tabExtensionControl.Size = new System.Drawing.Size(321, 149);
            this.tabExtensionControl.TabIndex = 22;
            this.tabExtensionControl.SelectedIndexChanged += new System.EventHandler(this.TabExtensionControl_SelectedIndexChanged);
            // 
            // tabExtensionCustom
            // 
            this.tabExtensionCustom.Controls.Add(this.txtNewExtension);
            this.tabExtensionCustom.Controls.Add(this.label11);
            this.tabExtensionCustom.Location = new System.Drawing.Point(4, 26);
            this.tabExtensionCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionCustom.Name = "tabExtensionCustom";
            this.tabExtensionCustom.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionCustom.Size = new System.Drawing.Size(313, 119);
            this.tabExtensionCustom.TabIndex = 0;
            this.tabExtensionCustom.Text = "自定义";
            this.tabExtensionCustom.UseVisualStyleBackColor = true;
            // 
            // txtNewExtension
            // 
            this.txtNewExtension.Location = new System.Drawing.Point(65, 23);
            this.txtNewExtension.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewExtension.Name = "txtNewExtension";
            this.txtNewExtension.Size = new System.Drawing.Size(230, 23);
            this.txtNewExtension.TabIndex = 1;
            this.txtNewExtension.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "新扩展名";
            // 
            // tabExtensionInsert
            // 
            this.tabExtensionInsert.Controls.Add(this.txtExtensionInsertText);
            this.tabExtensionInsert.Controls.Add(this.lblExtensionInsertText);
            this.tabExtensionInsert.Controls.Add(this.lblExtensionInsertChar2);
            this.tabExtensionInsert.Controls.Add(this.nudExtensionInsertChar);
            this.tabExtensionInsert.Controls.Add(this.lblExtensionInsertChar1);
            this.tabExtensionInsert.Controls.Add(this.rdoExtensionInserCustom);
            this.tabExtensionInsert.Controls.Add(this.rdoExtensionInsertEnd);
            this.tabExtensionInsert.Controls.Add(this.rdoExtensionInsertStart);
            this.tabExtensionInsert.Controls.Add(this.label19);
            this.tabExtensionInsert.Location = new System.Drawing.Point(4, 26);
            this.tabExtensionInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionInsert.Name = "tabExtensionInsert";
            this.tabExtensionInsert.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionInsert.Size = new System.Drawing.Size(313, 119);
            this.tabExtensionInsert.TabIndex = 1;
            this.tabExtensionInsert.Text = "插入";
            this.tabExtensionInsert.UseVisualStyleBackColor = true;
            // 
            // txtExtensionInsertText
            // 
            this.txtExtensionInsertText.Location = new System.Drawing.Point(69, 72);
            this.txtExtensionInsertText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExtensionInsertText.Name = "txtExtensionInsertText";
            this.txtExtensionInsertText.Size = new System.Drawing.Size(153, 23);
            this.txtExtensionInsertText.TabIndex = 8;
            this.txtExtensionInsertText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblExtensionInsertText
            // 
            this.lblExtensionInsertText.AutoSize = true;
            this.lblExtensionInsertText.Location = new System.Drawing.Point(12, 75);
            this.lblExtensionInsertText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionInsertText.Name = "lblExtensionInsertText";
            this.lblExtensionInsertText.Size = new System.Drawing.Size(56, 17);
            this.lblExtensionInsertText.TabIndex = 7;
            this.lblExtensionInsertText.Text = "插入内容";
            // 
            // lblExtensionInsertChar2
            // 
            this.lblExtensionInsertChar2.AutoSize = true;
            this.lblExtensionInsertChar2.Location = new System.Drawing.Point(94, 45);
            this.lblExtensionInsertChar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionInsertChar2.Name = "lblExtensionInsertChar2";
            this.lblExtensionInsertChar2.Size = new System.Drawing.Size(56, 17);
            this.lblExtensionInsertChar2.TabIndex = 6;
            this.lblExtensionInsertChar2.Text = "个字符后";
            // 
            // nudExtensionInsertChar
            // 
            this.nudExtensionInsertChar.Location = new System.Drawing.Point(33, 42);
            this.nudExtensionInsertChar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudExtensionInsertChar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtensionInsertChar.Name = "nudExtensionInsertChar";
            this.nudExtensionInsertChar.Size = new System.Drawing.Size(58, 23);
            this.nudExtensionInsertChar.TabIndex = 5;
            this.nudExtensionInsertChar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtensionInsertChar.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblExtensionInsertChar1
            // 
            this.lblExtensionInsertChar1.AutoSize = true;
            this.lblExtensionInsertChar1.Location = new System.Drawing.Point(12, 45);
            this.lblExtensionInsertChar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionInsertChar1.Name = "lblExtensionInsertChar1";
            this.lblExtensionInsertChar1.Size = new System.Drawing.Size(20, 17);
            this.lblExtensionInsertChar1.TabIndex = 4;
            this.lblExtensionInsertChar1.Text = "第";
            // 
            // rdoExtensionInserCustom
            // 
            this.rdoExtensionInserCustom.AutoSize = true;
            this.rdoExtensionInserCustom.Location = new System.Drawing.Point(162, 21);
            this.rdoExtensionInserCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoExtensionInserCustom.Name = "rdoExtensionInserCustom";
            this.rdoExtensionInserCustom.Size = new System.Drawing.Size(62, 21);
            this.rdoExtensionInserCustom.TabIndex = 3;
            this.rdoExtensionInserCustom.Text = "自定义";
            this.rdoExtensionInserCustom.UseVisualStyleBackColor = true;
            this.rdoExtensionInserCustom.CheckedChanged += new System.EventHandler(this.RdoExtensionInsertRadioButton_CheckedChanged);
            // 
            // rdoExtensionInsertEnd
            // 
            this.rdoExtensionInsertEnd.AutoSize = true;
            this.rdoExtensionInsertEnd.Location = new System.Drawing.Point(106, 21);
            this.rdoExtensionInsertEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoExtensionInsertEnd.Name = "rdoExtensionInsertEnd";
            this.rdoExtensionInsertEnd.Size = new System.Drawing.Size(50, 21);
            this.rdoExtensionInsertEnd.TabIndex = 2;
            this.rdoExtensionInsertEnd.Text = "末尾";
            this.rdoExtensionInsertEnd.UseVisualStyleBackColor = true;
            this.rdoExtensionInsertEnd.CheckedChanged += new System.EventHandler(this.RdoExtensionInsertRadioButton_CheckedChanged);
            // 
            // rdoExtensionInsertStart
            // 
            this.rdoExtensionInsertStart.AutoSize = true;
            this.rdoExtensionInsertStart.Location = new System.Drawing.Point(50, 21);
            this.rdoExtensionInsertStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoExtensionInsertStart.Name = "rdoExtensionInsertStart";
            this.rdoExtensionInsertStart.Size = new System.Drawing.Size(50, 21);
            this.rdoExtensionInsertStart.TabIndex = 1;
            this.rdoExtensionInsertStart.Text = "开头";
            this.rdoExtensionInsertStart.UseVisualStyleBackColor = true;
            this.rdoExtensionInsertStart.CheckedChanged += new System.EventHandler(this.RdoExtensionInsertRadioButton_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 21);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "位置";
            // 
            // tabExtensionReplace
            // 
            this.tabExtensionReplace.Controls.Add(this.txtExtensionReplaceText);
            this.tabExtensionReplace.Controls.Add(this.label20);
            this.tabExtensionReplace.Controls.Add(this.txtExtensionSearchText);
            this.tabExtensionReplace.Controls.Add(this.label21);
            this.tabExtensionReplace.Location = new System.Drawing.Point(4, 26);
            this.tabExtensionReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionReplace.Name = "tabExtensionReplace";
            this.tabExtensionReplace.Size = new System.Drawing.Size(313, 119);
            this.tabExtensionReplace.TabIndex = 2;
            this.tabExtensionReplace.Text = "替换";
            this.tabExtensionReplace.UseVisualStyleBackColor = true;
            // 
            // txtExtensionReplaceText
            // 
            this.txtExtensionReplaceText.Location = new System.Drawing.Point(75, 58);
            this.txtExtensionReplaceText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExtensionReplaceText.Name = "txtExtensionReplaceText";
            this.txtExtensionReplaceText.Size = new System.Drawing.Size(220, 23);
            this.txtExtensionReplaceText.TabIndex = 3;
            this.txtExtensionReplaceText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 61);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "替换内容";
            // 
            // txtExtensionSearchText
            // 
            this.txtExtensionSearchText.Location = new System.Drawing.Point(75, 18);
            this.txtExtensionSearchText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExtensionSearchText.Name = "txtExtensionSearchText";
            this.txtExtensionSearchText.Size = new System.Drawing.Size(220, 23);
            this.txtExtensionSearchText.TabIndex = 1;
            this.txtExtensionSearchText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 21);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "查找内容";
            // 
            // tabExtensionDelete
            // 
            this.tabExtensionDelete.Controls.Add(this.lblExtensionDeleteCount2);
            this.tabExtensionDelete.Controls.Add(this.nudExtensionDeleteCount);
            this.tabExtensionDelete.Controls.Add(this.lblExtensionDeletePosition2);
            this.tabExtensionDelete.Controls.Add(this.lblExtensionDeleteCount1);
            this.tabExtensionDelete.Controls.Add(this.txtExtensionDeleteContent);
            this.tabExtensionDelete.Controls.Add(this.nudExtensionDeletePosition);
            this.tabExtensionDelete.Controls.Add(this.lblExtensionDeletePosition1);
            this.tabExtensionDelete.Controls.Add(this.rdoExtensionDeleteByPosition);
            this.tabExtensionDelete.Controls.Add(this.lblExtensionDeleteContent1);
            this.tabExtensionDelete.Controls.Add(this.rdoExtensionDeleteByContent);
            this.tabExtensionDelete.Controls.Add(this.label27);
            this.tabExtensionDelete.Location = new System.Drawing.Point(4, 26);
            this.tabExtensionDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabExtensionDelete.Name = "tabExtensionDelete";
            this.tabExtensionDelete.Size = new System.Drawing.Size(313, 119);
            this.tabExtensionDelete.TabIndex = 3;
            this.tabExtensionDelete.Text = "删除";
            this.tabExtensionDelete.UseVisualStyleBackColor = true;
            // 
            // lblExtensionDeleteCount2
            // 
            this.lblExtensionDeleteCount2.AutoSize = true;
            this.lblExtensionDeleteCount2.Location = new System.Drawing.Point(126, 92);
            this.lblExtensionDeleteCount2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionDeleteCount2.Name = "lblExtensionDeleteCount2";
            this.lblExtensionDeleteCount2.Size = new System.Drawing.Size(44, 17);
            this.lblExtensionDeleteCount2.TabIndex = 9;
            this.lblExtensionDeleteCount2.Text = "个字符";
            // 
            // nudExtensionDeleteCount
            // 
            this.nudExtensionDeleteCount.Location = new System.Drawing.Point(62, 91);
            this.nudExtensionDeleteCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudExtensionDeleteCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtensionDeleteCount.Name = "nudExtensionDeleteCount";
            this.nudExtensionDeleteCount.Size = new System.Drawing.Size(58, 23);
            this.nudExtensionDeleteCount.TabIndex = 8;
            this.nudExtensionDeleteCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtensionDeleteCount.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblExtensionDeletePosition2
            // 
            this.lblExtensionDeletePosition2.AutoSize = true;
            this.lblExtensionDeletePosition2.Location = new System.Drawing.Point(150, 67);
            this.lblExtensionDeletePosition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionDeletePosition2.Name = "lblExtensionDeletePosition2";
            this.lblExtensionDeletePosition2.Size = new System.Drawing.Size(92, 17);
            this.lblExtensionDeletePosition2.TabIndex = 12;
            this.lblExtensionDeletePosition2.Text = "个字符开始删除";
            // 
            // lblExtensionDeleteCount1
            // 
            this.lblExtensionDeleteCount1.AutoSize = true;
            this.lblExtensionDeleteCount1.Location = new System.Drawing.Point(12, 92);
            this.lblExtensionDeleteCount1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionDeleteCount1.Name = "lblExtensionDeleteCount1";
            this.lblExtensionDeleteCount1.Size = new System.Drawing.Size(44, 17);
            this.lblExtensionDeleteCount1.TabIndex = 7;
            this.lblExtensionDeleteCount1.Text = "共删除";
            // 
            // txtExtensionDeleteContent
            // 
            this.txtExtensionDeleteContent.Location = new System.Drawing.Point(74, 37);
            this.txtExtensionDeleteContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExtensionDeleteContent.Name = "txtExtensionDeleteContent";
            this.txtExtensionDeleteContent.Size = new System.Drawing.Size(168, 23);
            this.txtExtensionDeleteContent.TabIndex = 5;
            this.txtExtensionDeleteContent.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // nudExtensionDeletePosition
            // 
            this.nudExtensionDeletePosition.Location = new System.Drawing.Point(86, 64);
            this.nudExtensionDeletePosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudExtensionDeletePosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtensionDeletePosition.Name = "nudExtensionDeletePosition";
            this.nudExtensionDeletePosition.Size = new System.Drawing.Size(58, 23);
            this.nudExtensionDeletePosition.TabIndex = 11;
            this.nudExtensionDeletePosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtensionDeletePosition.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblExtensionDeletePosition1
            // 
            this.lblExtensionDeletePosition1.AutoSize = true;
            this.lblExtensionDeletePosition1.Location = new System.Drawing.Point(12, 67);
            this.lblExtensionDeletePosition1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionDeletePosition1.Name = "lblExtensionDeletePosition1";
            this.lblExtensionDeletePosition1.Size = new System.Drawing.Size(68, 17);
            this.lblExtensionDeletePosition1.TabIndex = 10;
            this.lblExtensionDeletePosition1.Text = "从文件名第";
            // 
            // rdoExtensionDeleteByPosition
            // 
            this.rdoExtensionDeleteByPosition.AutoSize = true;
            this.rdoExtensionDeleteByPosition.Location = new System.Drawing.Point(154, 10);
            this.rdoExtensionDeleteByPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoExtensionDeleteByPosition.Name = "rdoExtensionDeleteByPosition";
            this.rdoExtensionDeleteByPosition.Size = new System.Drawing.Size(74, 21);
            this.rdoExtensionDeleteByPosition.TabIndex = 2;
            this.rdoExtensionDeleteByPosition.Text = "指定位置";
            this.rdoExtensionDeleteByPosition.UseVisualStyleBackColor = true;
            this.rdoExtensionDeleteByPosition.CheckedChanged += new System.EventHandler(this.RdoExtensionDeleteRadioButton_CheckedChanged);
            // 
            // lblExtensionDeleteContent1
            // 
            this.lblExtensionDeleteContent1.AutoSize = true;
            this.lblExtensionDeleteContent1.Location = new System.Drawing.Point(12, 40);
            this.lblExtensionDeleteContent1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionDeleteContent1.Name = "lblExtensionDeleteContent1";
            this.lblExtensionDeleteContent1.Size = new System.Drawing.Size(56, 17);
            this.lblExtensionDeleteContent1.TabIndex = 4;
            this.lblExtensionDeleteContent1.Text = "删除内容";
            // 
            // rdoExtensionDeleteByContent
            // 
            this.rdoExtensionDeleteByContent.AutoSize = true;
            this.rdoExtensionDeleteByContent.Location = new System.Drawing.Point(74, 10);
            this.rdoExtensionDeleteByContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoExtensionDeleteByContent.Name = "rdoExtensionDeleteByContent";
            this.rdoExtensionDeleteByContent.Size = new System.Drawing.Size(74, 21);
            this.rdoExtensionDeleteByContent.TabIndex = 1;
            this.rdoExtensionDeleteByContent.Text = "指定内容";
            this.rdoExtensionDeleteByContent.UseVisualStyleBackColor = true;
            this.rdoExtensionDeleteByContent.CheckedChanged += new System.EventHandler(this.RdoExtensionDeleteRadioButton_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 10);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 17);
            this.label27.TabIndex = 0;
            this.label27.Text = "删除方式";
            // 
            // cbEnableExtension
            // 
            this.cbEnableExtension.AutoSize = true;
            this.cbEnableExtension.Location = new System.Drawing.Point(4, 16);
            this.cbEnableExtension.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEnableExtension.Name = "cbEnableExtension";
            this.cbEnableExtension.Size = new System.Drawing.Size(87, 21);
            this.cbEnableExtension.TabIndex = 21;
            this.cbEnableExtension.Text = "扩展名修改";
            this.cbEnableExtension.UseVisualStyleBackColor = true;
            this.cbEnableExtension.CheckedChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // panelNumberSetting
            // 
            this.panelNumberSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNumberSetting.Controls.Add(this.label10);
            this.panelNumberSetting.Controls.Add(this.label15);
            this.panelNumberSetting.Controls.Add(this.nudNumberDigits);
            this.panelNumberSetting.Controls.Add(this.label14);
            this.panelNumberSetting.Controls.Add(this.nudIncremental);
            this.panelNumberSetting.Controls.Add(this.label13);
            this.panelNumberSetting.Controls.Add(this.nudInitValue);
            this.panelNumberSetting.Controls.Add(this.label12);
            this.panelNumberSetting.Controls.Add(this.lblNumberCount2);
            this.panelNumberSetting.Controls.Add(this.nudNumberCount);
            this.panelNumberSetting.Controls.Add(this.rdoNumberCustom);
            this.panelNumberSetting.Controls.Add(this.lblNumberCount1);
            this.panelNumberSetting.Controls.Add(this.rdoNumberEnd);
            this.panelNumberSetting.Controls.Add(this.label5);
            this.panelNumberSetting.Controls.Add(this.rdoNumberStart);
            this.panelNumberSetting.Controls.Add(this.cbEnableNumber);
            this.panelNumberSetting.Controls.Add(this.label6);
            this.panelNumberSetting.Location = new System.Drawing.Point(4, 317);
            this.panelNumberSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNumberSetting.Name = "panelNumberSetting";
            this.panelNumberSetting.Size = new System.Drawing.Size(331, 233);
            this.panelNumberSetting.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(33, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "2、若数字位数为3，命名则为000、001、002";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(9, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "注：1、若数字位数为1，命名则为0、1、2";
            // 
            // nudNumberDigits
            // 
            this.nudNumberDigits.Location = new System.Drawing.Point(71, 136);
            this.nudNumberDigits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudNumberDigits.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDigits.Name = "nudNumberDigits";
            this.nudNumberDigits.Size = new System.Drawing.Size(58, 23);
            this.nudNumberDigits.TabIndex = 18;
            this.nudNumberDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDigits.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 137);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "数字位数";
            // 
            // nudIncremental
            // 
            this.nudIncremental.Location = new System.Drawing.Point(211, 94);
            this.nudIncremental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudIncremental.Name = "nudIncremental";
            this.nudIncremental.Size = new System.Drawing.Size(58, 23);
            this.nudIncremental.TabIndex = 16;
            this.nudIncremental.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIncremental.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "每次递增";
            // 
            // nudInitValue
            // 
            this.nudInitValue.Location = new System.Drawing.Point(71, 94);
            this.nudInitValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudInitValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudInitValue.Name = "nudInitValue";
            this.nudInitValue.Size = new System.Drawing.Size(58, 23);
            this.nudInitValue.TabIndex = 14;
            this.nudInitValue.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "初始数值";
            // 
            // lblNumberCount2
            // 
            this.lblNumberCount2.AutoSize = true;
            this.lblNumberCount2.Location = new System.Drawing.Point(88, 68);
            this.lblNumberCount2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberCount2.Name = "lblNumberCount2";
            this.lblNumberCount2.Size = new System.Drawing.Size(56, 17);
            this.lblNumberCount2.TabIndex = 11;
            this.lblNumberCount2.Text = "个字符后";
            this.lblNumberCount2.Visible = false;
            // 
            // nudNumberCount
            // 
            this.nudNumberCount.Location = new System.Drawing.Point(23, 67);
            this.nudNumberCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudNumberCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberCount.Name = "nudNumberCount";
            this.nudNumberCount.Size = new System.Drawing.Size(58, 23);
            this.nudNumberCount.TabIndex = 10;
            this.nudNumberCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberCount.Visible = false;
            this.nudNumberCount.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // rdoNumberCustom
            // 
            this.rdoNumberCustom.AutoSize = true;
            this.rdoNumberCustom.Location = new System.Drawing.Point(149, 44);
            this.rdoNumberCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoNumberCustom.Name = "rdoNumberCustom";
            this.rdoNumberCustom.Size = new System.Drawing.Size(62, 21);
            this.rdoNumberCustom.TabIndex = 12;
            this.rdoNumberCustom.Text = "自定义";
            this.rdoNumberCustom.UseVisualStyleBackColor = true;
            this.rdoNumberCustom.CheckedChanged += new System.EventHandler(this.RdoNumberSettingRadioButton_CheckedChanged);
            // 
            // lblNumberCount1
            // 
            this.lblNumberCount1.AutoSize = true;
            this.lblNumberCount1.Location = new System.Drawing.Point(5, 68);
            this.lblNumberCount1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberCount1.Name = "lblNumberCount1";
            this.lblNumberCount1.Size = new System.Drawing.Size(20, 17);
            this.lblNumberCount1.TabIndex = 9;
            this.lblNumberCount1.Text = "第";
            this.lblNumberCount1.Visible = false;
            // 
            // rdoNumberEnd
            // 
            this.rdoNumberEnd.AutoSize = true;
            this.rdoNumberEnd.Location = new System.Drawing.Point(96, 44);
            this.rdoNumberEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoNumberEnd.Name = "rdoNumberEnd";
            this.rdoNumberEnd.Size = new System.Drawing.Size(50, 21);
            this.rdoNumberEnd.TabIndex = 11;
            this.rdoNumberEnd.Text = "末尾";
            this.rdoNumberEnd.UseVisualStyleBackColor = true;
            this.rdoNumberEnd.CheckedChanged += new System.EventHandler(this.RdoNumberSettingRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // rdoNumberStart
            // 
            this.rdoNumberStart.AutoSize = true;
            this.rdoNumberStart.Checked = true;
            this.rdoNumberStart.Location = new System.Drawing.Point(40, 44);
            this.rdoNumberStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoNumberStart.Name = "rdoNumberStart";
            this.rdoNumberStart.Size = new System.Drawing.Size(50, 21);
            this.rdoNumberStart.TabIndex = 10;
            this.rdoNumberStart.TabStop = true;
            this.rdoNumberStart.Text = "开头";
            this.rdoNumberStart.UseVisualStyleBackColor = true;
            this.rdoNumberStart.CheckedChanged += new System.EventHandler(this.RdoNumberSettingRadioButton_CheckedChanged);
            // 
            // cbEnableNumber
            // 
            this.cbEnableNumber.AutoSize = true;
            this.cbEnableNumber.Location = new System.Drawing.Point(6, 11);
            this.cbEnableNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEnableNumber.Name = "cbEnableNumber";
            this.cbEnableNumber.Size = new System.Drawing.Size(75, 21);
            this.cbEnableNumber.TabIndex = 0;
            this.cbEnableNumber.Text = "启用编号";
            this.cbEnableNumber.UseVisualStyleBackColor = true;
            this.cbEnableNumber.CheckedChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "位置";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbEditFileName);
            this.panel1.Controls.Add(this.tabOptionControl);
            this.panel1.Location = new System.Drawing.Point(4, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 224);
            this.panel1.TabIndex = 8;
            // 
            // cbEditFileName
            // 
            this.cbEditFileName.AutoSize = true;
            this.cbEditFileName.Location = new System.Drawing.Point(7, 16);
            this.cbEditFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEditFileName.Name = "cbEditFileName";
            this.cbEditFileName.Size = new System.Drawing.Size(87, 21);
            this.cbEditFileName.TabIndex = 10;
            this.cbEditFileName.Text = "修改文件名";
            this.cbEditFileName.UseVisualStyleBackColor = true;
            this.cbEditFileName.CheckedChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // tabOptionControl
            // 
            this.tabOptionControl.Controls.Add(this.tabCustom);
            this.tabOptionControl.Controls.Add(this.tabInsert);
            this.tabOptionControl.Controls.Add(this.tabReplace);
            this.tabOptionControl.Controls.Add(this.tabDelete);
            this.tabOptionControl.Location = new System.Drawing.Point(4, 42);
            this.tabOptionControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabOptionControl.Name = "tabOptionControl";
            this.tabOptionControl.SelectedIndex = 0;
            this.tabOptionControl.Size = new System.Drawing.Size(321, 149);
            this.tabOptionControl.TabIndex = 9;
            this.tabOptionControl.SelectedIndexChanged += new System.EventHandler(this.TabOptionControl_SelectedIndexChanged);
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.txtNewName);
            this.tabCustom.Controls.Add(this.label2);
            this.tabCustom.Location = new System.Drawing.Point(4, 26);
            this.tabCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabCustom.Size = new System.Drawing.Size(313, 119);
            this.tabCustom.TabIndex = 0;
            this.tabCustom.Text = "自定义";
            this.tabCustom.UseVisualStyleBackColor = true;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(65, 23);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(230, 23);
            this.txtNewName.TabIndex = 1;
            this.txtNewName.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "新文件名";
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.txtInsertText);
            this.tabInsert.Controls.Add(this.lblInsertText);
            this.tabInsert.Controls.Add(this.lblInsertCharPosition2);
            this.tabInsert.Controls.Add(this.nudInsertCharPosition);
            this.tabInsert.Controls.Add(this.lblInsertCharPosition1);
            this.tabInsert.Controls.Add(this.rdoInsertCustom);
            this.tabInsert.Controls.Add(this.rdoInsertEnd);
            this.tabInsert.Controls.Add(this.rdoInsertStart);
            this.tabInsert.Controls.Add(this.label3);
            this.tabInsert.Location = new System.Drawing.Point(4, 26);
            this.tabInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInsert.Size = new System.Drawing.Size(313, 119);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "插入";
            this.tabInsert.UseVisualStyleBackColor = true;
            // 
            // txtInsertText
            // 
            this.txtInsertText.Location = new System.Drawing.Point(68, 69);
            this.txtInsertText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInsertText.Name = "txtInsertText";
            this.txtInsertText.Size = new System.Drawing.Size(153, 23);
            this.txtInsertText.TabIndex = 8;
            this.txtInsertText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblInsertText
            // 
            this.lblInsertText.AutoSize = true;
            this.lblInsertText.Location = new System.Drawing.Point(9, 72);
            this.lblInsertText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsertText.Name = "lblInsertText";
            this.lblInsertText.Size = new System.Drawing.Size(56, 17);
            this.lblInsertText.TabIndex = 7;
            this.lblInsertText.Text = "插入内容";
            // 
            // lblInsertCharPosition2
            // 
            this.lblInsertCharPosition2.AutoSize = true;
            this.lblInsertCharPosition2.Location = new System.Drawing.Point(89, 42);
            this.lblInsertCharPosition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsertCharPosition2.Name = "lblInsertCharPosition2";
            this.lblInsertCharPosition2.Size = new System.Drawing.Size(56, 17);
            this.lblInsertCharPosition2.TabIndex = 6;
            this.lblInsertCharPosition2.Text = "个字符后";
            // 
            // nudInsertCharPosition
            // 
            this.nudInsertCharPosition.Location = new System.Drawing.Point(30, 40);
            this.nudInsertCharPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudInsertCharPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInsertCharPosition.Name = "nudInsertCharPosition";
            this.nudInsertCharPosition.Size = new System.Drawing.Size(58, 23);
            this.nudInsertCharPosition.TabIndex = 5;
            this.nudInsertCharPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInsertCharPosition.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblInsertCharPosition1
            // 
            this.lblInsertCharPosition1.AutoSize = true;
            this.lblInsertCharPosition1.Location = new System.Drawing.Point(9, 42);
            this.lblInsertCharPosition1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsertCharPosition1.Name = "lblInsertCharPosition1";
            this.lblInsertCharPosition1.Size = new System.Drawing.Size(20, 17);
            this.lblInsertCharPosition1.TabIndex = 4;
            this.lblInsertCharPosition1.Text = "第";
            // 
            // rdoInsertCustom
            // 
            this.rdoInsertCustom.AutoSize = true;
            this.rdoInsertCustom.Location = new System.Drawing.Point(159, 18);
            this.rdoInsertCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoInsertCustom.Name = "rdoInsertCustom";
            this.rdoInsertCustom.Size = new System.Drawing.Size(62, 21);
            this.rdoInsertCustom.TabIndex = 3;
            this.rdoInsertCustom.Text = "自定义";
            this.rdoInsertCustom.UseVisualStyleBackColor = true;
            this.rdoInsertCustom.CheckedChanged += new System.EventHandler(this.RdoInsertRadioButton_CheckedChanged);
            // 
            // rdoInsertEnd
            // 
            this.rdoInsertEnd.AutoSize = true;
            this.rdoInsertEnd.Location = new System.Drawing.Point(103, 18);
            this.rdoInsertEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoInsertEnd.Name = "rdoInsertEnd";
            this.rdoInsertEnd.Size = new System.Drawing.Size(50, 21);
            this.rdoInsertEnd.TabIndex = 2;
            this.rdoInsertEnd.Text = "末尾";
            this.rdoInsertEnd.UseVisualStyleBackColor = true;
            this.rdoInsertEnd.CheckedChanged += new System.EventHandler(this.RdoInsertRadioButton_CheckedChanged);
            // 
            // rdoInsertStart
            // 
            this.rdoInsertStart.AutoSize = true;
            this.rdoInsertStart.Location = new System.Drawing.Point(47, 18);
            this.rdoInsertStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoInsertStart.Name = "rdoInsertStart";
            this.rdoInsertStart.Size = new System.Drawing.Size(50, 21);
            this.rdoInsertStart.TabIndex = 1;
            this.rdoInsertStart.Text = "开头";
            this.rdoInsertStart.UseVisualStyleBackColor = true;
            this.rdoInsertStart.CheckedChanged += new System.EventHandler(this.RdoInsertRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "位置";
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.txtReplaceText);
            this.tabReplace.Controls.Add(this.label8);
            this.tabReplace.Controls.Add(this.txtSearchText);
            this.tabReplace.Controls.Add(this.label7);
            this.tabReplace.Location = new System.Drawing.Point(4, 26);
            this.tabReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Size = new System.Drawing.Size(313, 119);
            this.tabReplace.TabIndex = 2;
            this.tabReplace.Text = "替换";
            this.tabReplace.UseVisualStyleBackColor = true;
            // 
            // txtReplaceText
            // 
            this.txtReplaceText.Location = new System.Drawing.Point(75, 58);
            this.txtReplaceText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReplaceText.Name = "txtReplaceText";
            this.txtReplaceText.Size = new System.Drawing.Size(220, 23);
            this.txtReplaceText.TabIndex = 3;
            this.txtReplaceText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "替换内容";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(75, 18);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(220, 23);
            this.txtSearchText.TabIndex = 1;
            this.txtSearchText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "查找内容";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.lblDelteCount2);
            this.tabDelete.Controls.Add(this.nudDeleteCount);
            this.tabDelete.Controls.Add(this.lblDeletePosition2);
            this.tabDelete.Controls.Add(this.lblDeleteCount1);
            this.tabDelete.Controls.Add(this.txtDeleteText);
            this.tabDelete.Controls.Add(this.nudDeletePosition);
            this.tabDelete.Controls.Add(this.lblDeletePositon1);
            this.tabDelete.Controls.Add(this.rdoDeleteByPosition);
            this.tabDelete.Controls.Add(this.lblDeleteText);
            this.tabDelete.Controls.Add(this.rdoDeletebyContent);
            this.tabDelete.Controls.Add(this.label9);
            this.tabDelete.Location = new System.Drawing.Point(4, 26);
            this.tabDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(313, 119);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "删除";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // lblDelteCount2
            // 
            this.lblDelteCount2.AutoSize = true;
            this.lblDelteCount2.Location = new System.Drawing.Point(126, 92);
            this.lblDelteCount2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelteCount2.Name = "lblDelteCount2";
            this.lblDelteCount2.Size = new System.Drawing.Size(44, 17);
            this.lblDelteCount2.TabIndex = 9;
            this.lblDelteCount2.Text = "个字符";
            // 
            // nudDeleteCount
            // 
            this.nudDeleteCount.Location = new System.Drawing.Point(62, 91);
            this.nudDeleteCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudDeleteCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeleteCount.Name = "nudDeleteCount";
            this.nudDeleteCount.Size = new System.Drawing.Size(58, 23);
            this.nudDeleteCount.TabIndex = 8;
            this.nudDeleteCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeleteCount.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblDeletePosition2
            // 
            this.lblDeletePosition2.AutoSize = true;
            this.lblDeletePosition2.Location = new System.Drawing.Point(150, 67);
            this.lblDeletePosition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeletePosition2.Name = "lblDeletePosition2";
            this.lblDeletePosition2.Size = new System.Drawing.Size(92, 17);
            this.lblDeletePosition2.TabIndex = 12;
            this.lblDeletePosition2.Text = "个字符开始删除";
            // 
            // lblDeleteCount1
            // 
            this.lblDeleteCount1.AutoSize = true;
            this.lblDeleteCount1.Location = new System.Drawing.Point(12, 92);
            this.lblDeleteCount1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteCount1.Name = "lblDeleteCount1";
            this.lblDeleteCount1.Size = new System.Drawing.Size(44, 17);
            this.lblDeleteCount1.TabIndex = 7;
            this.lblDeleteCount1.Text = "共删除";
            // 
            // txtDeleteText
            // 
            this.txtDeleteText.Location = new System.Drawing.Point(74, 37);
            this.txtDeleteText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeleteText.Name = "txtDeleteText";
            this.txtDeleteText.Size = new System.Drawing.Size(168, 23);
            this.txtDeleteText.TabIndex = 5;
            this.txtDeleteText.TextChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // nudDeletePosition
            // 
            this.nudDeletePosition.Location = new System.Drawing.Point(86, 64);
            this.nudDeletePosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudDeletePosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeletePosition.Name = "nudDeletePosition";
            this.nudDeletePosition.Size = new System.Drawing.Size(58, 23);
            this.nudDeletePosition.TabIndex = 11;
            this.nudDeletePosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeletePosition.ValueChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // lblDeletePositon1
            // 
            this.lblDeletePositon1.AutoSize = true;
            this.lblDeletePositon1.Location = new System.Drawing.Point(12, 67);
            this.lblDeletePositon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeletePositon1.Name = "lblDeletePositon1";
            this.lblDeletePositon1.Size = new System.Drawing.Size(68, 17);
            this.lblDeletePositon1.TabIndex = 10;
            this.lblDeletePositon1.Text = "从文件名第";
            // 
            // rdoDeleteByPosition
            // 
            this.rdoDeleteByPosition.AutoSize = true;
            this.rdoDeleteByPosition.Location = new System.Drawing.Point(154, 10);
            this.rdoDeleteByPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoDeleteByPosition.Name = "rdoDeleteByPosition";
            this.rdoDeleteByPosition.Size = new System.Drawing.Size(74, 21);
            this.rdoDeleteByPosition.TabIndex = 2;
            this.rdoDeleteByPosition.Text = "指定位置";
            this.rdoDeleteByPosition.UseVisualStyleBackColor = true;
            this.rdoDeleteByPosition.CheckedChanged += new System.EventHandler(this.RdoDeleteRadioButton_CheckedChanged);
            // 
            // lblDeleteText
            // 
            this.lblDeleteText.AutoSize = true;
            this.lblDeleteText.Location = new System.Drawing.Point(12, 40);
            this.lblDeleteText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteText.Name = "lblDeleteText";
            this.lblDeleteText.Size = new System.Drawing.Size(56, 17);
            this.lblDeleteText.TabIndex = 4;
            this.lblDeleteText.Text = "删除内容";
            // 
            // rdoDeletebyContent
            // 
            this.rdoDeletebyContent.AutoSize = true;
            this.rdoDeletebyContent.Location = new System.Drawing.Point(74, 10);
            this.rdoDeletebyContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoDeletebyContent.Name = "rdoDeletebyContent";
            this.rdoDeletebyContent.Size = new System.Drawing.Size(74, 21);
            this.rdoDeletebyContent.TabIndex = 1;
            this.rdoDeletebyContent.Text = "指定内容";
            this.rdoDeletebyContent.UseVisualStyleBackColor = true;
            this.rdoDeletebyContent.CheckedChanged += new System.EventHandler(this.RdoDeleteRadioButton_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "删除方式";
            // 
            // panel_ToggleCase
            // 
            this.panel_ToggleCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ToggleCase.Controls.Add(this.rdoAllUp);
            this.panel_ToggleCase.Controls.Add(this.rdoAllLow);
            this.panel_ToggleCase.Controls.Add(this.rdoNoToggle);
            this.panel_ToggleCase.Controls.Add(this.label4);
            this.panel_ToggleCase.Location = new System.Drawing.Point(4, 268);
            this.panel_ToggleCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_ToggleCase.Name = "panel_ToggleCase";
            this.panel_ToggleCase.Size = new System.Drawing.Size(331, 44);
            this.panel_ToggleCase.TabIndex = 7;
            // 
            // rdoAllUp
            // 
            this.rdoAllUp.AutoSize = true;
            this.rdoAllUp.Location = new System.Drawing.Point(200, 11);
            this.rdoAllUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoAllUp.Name = "rdoAllUp";
            this.rdoAllUp.Size = new System.Drawing.Size(86, 21);
            this.rdoAllUp.TabIndex = 17;
            this.rdoAllUp.Text = "小写转大写";
            this.rdoAllUp.UseVisualStyleBackColor = true;
            this.rdoAllUp.CheckedChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // rdoAllLow
            // 
            this.rdoAllLow.AutoSize = true;
            this.rdoAllLow.Location = new System.Drawing.Point(113, 11);
            this.rdoAllLow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoAllLow.Name = "rdoAllLow";
            this.rdoAllLow.Size = new System.Drawing.Size(86, 21);
            this.rdoAllLow.TabIndex = 16;
            this.rdoAllLow.Text = "大写转小写";
            this.rdoAllLow.UseVisualStyleBackColor = true;
            this.rdoAllLow.CheckedChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // rdoNoToggle
            // 
            this.rdoNoToggle.AutoSize = true;
            this.rdoNoToggle.Checked = true;
            this.rdoNoToggle.Location = new System.Drawing.Point(78, 11);
            this.rdoNoToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoNoToggle.Name = "rdoNoToggle";
            this.rdoNoToggle.Size = new System.Drawing.Size(38, 21);
            this.rdoNoToggle.TabIndex = 13;
            this.rdoNoToggle.TabStop = true;
            this.rdoNoToggle.Text = "无";
            this.rdoNoToggle.UseVisualStyleBackColor = true;
            this.rdoNoToggle.CheckedChanged += new System.EventHandler(this.SetNewFileNameToDataTable);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "大小写转换";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "操作配置";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 60;
            // 
            // SourceFileName
            // 
            this.SourceFileName.DataPropertyName = "SourceFileName";
            this.SourceFileName.HeaderText = "源文件名称";
            this.SourceFileName.Name = "SourceFileName";
            this.SourceFileName.ReadOnly = true;
            this.SourceFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SourceFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SourceFileName.Width = 250;
            // 
            // NewFileName
            // 
            this.NewFileName.DataPropertyName = "NewFileName";
            this.NewFileName.HeaderText = "预计新文件名";
            this.NewFileName.Name = "NewFileName";
            this.NewFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NewFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NewFileName.Width = 250;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "文件路径";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FilePath.Width = 420;
            // 
            // OptionState
            // 
            this.OptionState.DataPropertyName = "OptionState";
            this.OptionState.HeaderText = "操作状态";
            this.OptionState.Name = "OptionState";
            this.OptionState.ReadOnly = true;
            this.OptionState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OptionState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 800);
            this.Controls.Add(this.panel_optionSetting);
            this.Controls.Add(this.panel_Data);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows文件批量重命名";
            this.panel_Data.ResumeLayout(false);
            this.panel_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileData)).EndInit();
            this.panel_optionSetting.ResumeLayout(false);
            this.panel_optionSetting.PerformLayout();
            this.panelExtensionSetting.ResumeLayout(false);
            this.panelExtensionSetting.PerformLayout();
            this.tabExtensionControl.ResumeLayout(false);
            this.tabExtensionCustom.ResumeLayout(false);
            this.tabExtensionCustom.PerformLayout();
            this.tabExtensionInsert.ResumeLayout(false);
            this.tabExtensionInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensionInsertChar)).EndInit();
            this.tabExtensionReplace.ResumeLayout(false);
            this.tabExtensionReplace.PerformLayout();
            this.tabExtensionDelete.ResumeLayout(false);
            this.tabExtensionDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensionDeleteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensionDeletePosition)).EndInit();
            this.panelNumberSetting.ResumeLayout(false);
            this.panelNumberSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncremental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabOptionControl.ResumeLayout(false);
            this.tabCustom.ResumeLayout(false);
            this.tabCustom.PerformLayout();
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsertCharPosition)).EndInit();
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeletePosition)).EndInit();
            this.panel_ToggleCase.ResumeLayout(false);
            this.panel_ToggleCase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Data;
        private Label lbl_filecount;
        private Button btn_chooseFiles;
        private Button btn_chooseFolder;
        private Button btn_startwork;
        private DataGridView dgvFileData;
        private Panel panel_optionSetting;
        private Label label1;
        private Panel panel_ToggleCase;
        private Label label4;
        private RadioButton rdoAllUp;
        private RadioButton rdoAllLow;
        private RadioButton rdoNoToggle;
        private Panel panel1;
        private TabControl tabOptionControl;
        private TabPage tabCustom;
        private TextBox txtNewName;
        private Label label2;
        private TabPage tabInsert;
        private TextBox txtInsertText;
        private Label lblInsertText;
        private Label lblInsertCharPosition2;
        private NumericUpDown nudInsertCharPosition;
        private Label lblInsertCharPosition1;
        private RadioButton rdoInsertCustom;
        private RadioButton rdoInsertEnd;
        private RadioButton rdoInsertStart;
        private Label label3;
        private TabPage tabReplace;
        private TextBox txtReplaceText;
        private Label label8;
        private TextBox txtSearchText;
        private Label label7;
        private TabPage tabDelete;
        private Label lblDelteCount2;
        private NumericUpDown nudDeleteCount;
        private Label lblDeletePosition2;
        private Label lblDeleteCount1;
        private TextBox txtDeleteText;
        private NumericUpDown nudDeletePosition;
        private Label lblDeletePositon1;
        private RadioButton rdoDeleteByPosition;
        private Label lblDeleteText;
        private RadioButton rdoDeletebyContent;
        private Label label9;
        private Panel panelNumberSetting;
        private CheckBox cbEnableNumber;
        private RadioButton rdoNumberCustom;
        private RadioButton rdoNumberEnd;
        private Label label5;
        private RadioButton rdoNumberStart;
        private Label label6;
        private Label lblNumberCount2;
        private NumericUpDown nudNumberCount;
        private Label lblNumberCount1;
        private NumericUpDown nudIncremental;
        private Label label13;
        private NumericUpDown nudInitValue;
        private Label label12;
        private NumericUpDown nudNumberDigits;
        private Label label14;
        private Label label15;
        private Label label10;
        private Panel panelExtensionSetting;
        private CheckBox cbEnableExtension;
        private TabControl tabExtensionControl;
        private TabPage tabExtensionCustom;
        private TextBox txtNewExtension;
        private Label label11;
        private TabPage tabExtensionInsert;
        private TextBox txtExtensionInsertText;
        private Label lblExtensionInsertText;
        private Label lblExtensionInsertChar2;
        private NumericUpDown nudExtensionInsertChar;
        private Label lblExtensionInsertChar1;
        private RadioButton rdoExtensionInserCustom;
        private RadioButton rdoExtensionInsertEnd;
        private RadioButton rdoExtensionInsertStart;
        private Label label19;
        private TabPage tabExtensionReplace;
        private TextBox txtExtensionReplaceText;
        private Label label20;
        private TextBox txtExtensionSearchText;
        private Label label21;
        private TabPage tabExtensionDelete;
        private Label lblExtensionDeleteCount2;
        private NumericUpDown nudExtensionDeleteCount;
        private Label lblExtensionDeletePosition2;
        private Label lblExtensionDeleteCount1;
        private TextBox txtExtensionDeleteContent;
        private NumericUpDown nudExtensionDeletePosition;
        private Label lblExtensionDeletePosition1;
        private RadioButton rdoExtensionDeleteByPosition;
        private Label lblExtensionDeleteContent1;
        private RadioButton rdoExtensionDeleteByContent;
        private Label label27;
        private CheckBox cbEditFileName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SourceFileName;
        private DataGridViewTextBoxColumn NewFileName;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn OptionState;
    }
}

