using FilesBatchRename.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FilesBatchRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //设置不自动新增数据列
            this.dgvFileData.AutoGenerateColumns = false;
            //去掉最后一行空白行
            this.dgvFileData.AllowUserToAddRows = false;
            //隐藏头一列空白列
            this.dgvFileData.RowHeadersVisible = false;
        }

        #region 选择文件或文件夹获取文件数据


        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_chooseFiles_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Filter = Resources.DialogFilterText;

            if (dialog.ShowDialog() != DialogResult.OK) return;


            var dt = new DataTable();
            InitDataTable(dt);

            if (dialog.Multiselect)
            {
                foreach (var t in dialog.FileNames)
                {
                    InsertDataTable(dt, t);
                }
            }
            else
            {
                InsertDataTable(dt, dialog.FileName);
            }


            this.dgvFileData.DataSource = dt;
            this.lbl_filecount.Text = Resources.TotalFileCount + dt.Rows.Count;
            this.dgvFileData.Visible = true;
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_chooseFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            if (string.IsNullOrEmpty(dialog.SelectedPath))
            {
                MessageBox.Show(this, Resources.FilePathIsNotEmpty, Resources.Tips);
                return;
            }
            //指定的文件夹目录
            var dir = new DirectoryInfo(dialog.SelectedPath);
            if (dir.Exists == false)
            {
                MessageBox.Show(Resources.FilePathIsNotExists);
            }
            else
            {
                var dt = new DataTable();
                InitDataTable(dt);
                //检索表示当前目录的文件和子目录
                var fsInfos = dir.GetFiles();
                //遍历检索的文件和子目录
                foreach (var fsInfo in fsInfos)
                {
                    InsertDataTable(dt, fsInfo.FullName);
                }
                this.dgvFileData.DataSource = dt;
                this.lbl_filecount.Text = Resources.TotalFileCount + dt.Rows.Count;
                this.dgvFileData.Visible = true;
            }
        }

        /// <summary>
        /// 初始化DataTable，添加列
        /// </summary>
        /// <param name="dt"></param>
        private static void InitDataTable(DataTable dt)
        {
            dt.Columns.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("SourceFileName");
            dt.Columns.Add("NewFileName");
            dt.Columns.Add("FilePath");
            dt.Columns.Add("OptionState");
        }

        /// <summary>
        /// 往DataTable添加一行数据
        /// </summary>
        /// <param name="dt">待操作的DataTable</param>
        /// <param name="filepath">文件全路径</param>
        private static void InsertDataTable(DataTable dt, string filepath)
        {
            var row = dt.NewRow();
            var sourceFIleName = filepath.Substring(filepath.LastIndexOf("\\", StringComparison.Ordinal) + 1);
            row["Id"] = dt.Rows.Count + 1;
            row["SourceFileName"] = sourceFIleName;
            row["NewFileName"] = string.Empty;
            row["FilePath"] = filepath;
            row["OptionState"] = "待操作";
            dt.Rows.Add(row);
        }


        #endregion

        #region 页面显示隐藏逻辑

        /// <summary>
        /// 修改文件名时tab选项卡变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabOptionControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabOptionControl.SelectedIndex)
            {
                case 0:
                //当选项变更为“插入”操作时，默认选中“开头”,并使“编号设置”面板为可见
                case 1:
                    this.panelNumberSetting.Visible = true;
                    this.panelExtensionSetting.Location = new Point(3, 557);
                    this.rdoInsertStart.Checked = true;
                    break;
                //选项当变更为“删除”操作时，默认选中“指定内容”,并使“编号设置”面板为不可见
                case 2:
                case 3:
                    this.panelNumberSetting.Visible = false;
                    this.panelExtensionSetting.Location = new Point(3, 318);
                    this.cbEnableNumber.Checked = false;
                    this.rdoDeletebyContent.Checked = true;
                    break;
            }

            SetNewFileNameToDataTable(sender, e);
        }

        /// <summary>
        /// 修改文件名时插入操作的单选按钮变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoInsertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoInsertStart.Checked || this.rdoInsertEnd.Checked)
            {
                this.lblInsertCharPosition1.Visible = false;
                this.lblInsertCharPosition2.Visible = false;
                this.nudInsertCharPosition.Visible = false;

                this.lblInsertText.Visible = true;
                this.txtInsertText.Visible = true;

                this.lblInsertText.Location = new Point(6, 39);
                this.txtInsertText.Location = new Point(68, 39);
            }
            else
            {
                this.lblInsertCharPosition1.Visible = true;
                this.lblInsertCharPosition2.Visible = true;
                this.nudInsertCharPosition.Visible = true;

                this.lblInsertText.Visible = true;
                this.txtInsertText.Visible = true;

                this.lblInsertText.Location = new Point(6, 69);
                this.txtInsertText.Location = new Point(68, 66);
            }
            SetNewFileNameToDataTable(sender, e);
        }

        /// <summary>
        /// 修改文件名时删除操作的单选按钮变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeletebyContent.Checked)
            {
                this.lblDeleteCount1.Visible = false;
                this.lblDelteCount2.Visible = false;
                this.lblDeletePositon1.Visible = false;
                this.lblDeletePosition2.Visible = false;
                this.nudDeletePosition.Visible = false;
                this.nudDeleteCount.Visible = false;

                this.txtDeleteText.Visible = true;
                this.lblDeleteText.Visible = true;
            }
            else
            {
                this.txtDeleteText.Visible = false;
                this.lblDeleteText.Visible = false;

                this.lblDeleteCount1.Visible = true;
                this.lblDelteCount2.Visible = true;
                this.lblDeletePositon1.Visible = true;
                this.lblDeletePosition2.Visible = true;
                this.nudDeletePosition.Visible = true;
                this.nudDeleteCount.Visible = true;

                this.lblDeletePositon1.Location = new Point(12, 40);
                this.nudDeletePosition.Location = new Point(86, 37);
                this.lblDeletePosition2.Location = new Point(150, 40);

                this.lblDeleteCount1.Location = new Point(12, 66);
                this.nudDeleteCount.Location = new Point(62, 64);
                this.lblDelteCount2.Location = new Point(126, 66);
            }
            SetNewFileNameToDataTable(sender, e);
        }

        /// <summary>
        /// 设置编号时的单选按钮变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoNumberSettingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoNumberStart.Checked || this.rdoNumberEnd.Checked)
            {
                this.lblNumberCount1.Visible = false;
                this.lblNumberCount2.Visible = false;
                this.nudNumberCount.Visible = false;
            }
            else
            {
                this.lblNumberCount1.Visible = true;
                this.lblNumberCount2.Visible = true;
                this.nudNumberCount.Visible = true;
            }
            SetNewFileNameToDataTable(sender, e);
        }

        /// <summary>
        /// 修改扩展名时tab选项卡变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabExtensionControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabExtensionControl.SelectedIndex)
            {
                case 1:
                    this.rdoExtensionInsertStart.Checked = true;
                    break;
                case 3:
                    this.rdoExtensionDeleteByContent.Checked = true;
                    break;
            }
            SetNewFileNameToDataTable(sender, e);
        }

        /// <summary>
        /// 修改扩展名时插入操作的单选按钮变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoExtensionInsertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoExtensionInsertStart.Checked || this.rdoExtensionInsertEnd.Checked)
            {
                this.lblExtensionInsertChar1.Visible = false;
                this.lblExtensionInsertChar2.Visible = false;
                this.nudExtensionInsertChar.Visible = false;

                this.lblExtensionInsertText.Visible = true;
                this.txtExtensionInsertText.Visible = true;

                this.lblExtensionInsertText.Location = new Point(12, 45);
                this.txtExtensionInsertText.Location = new Point(69, 43);
            }
            else
            {
                this.lblExtensionInsertChar1.Visible = true;
                this.lblExtensionInsertChar2.Visible = true;
                this.nudExtensionInsertChar.Visible = true;

                this.lblExtensionInsertText.Visible = true;
                this.txtExtensionInsertText.Visible = true;

                this.lblExtensionInsertText.Location = new Point(12, 75);
                this.txtExtensionInsertText.Location = new Point(69, 72);
            }
            SetNewFileNameToDataTable(sender, e);
        }

        /// <summary>
        /// 修改扩展名时删除操作的单选按钮变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoExtensionDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoExtensionDeleteByContent.Checked)
            {
                this.lblExtensionDeleteCount1.Visible = false;
                this.lblExtensionDeleteCount2.Visible = false;
                this.lblExtensionDeletePosition1.Visible = false;
                this.lblExtensionDeletePosition2.Visible = false;
                this.nudExtensionDeletePosition.Visible = false;
                this.nudExtensionDeleteCount.Visible = false;

                this.txtExtensionDeleteContent.Visible = true;
                this.lblExtensionDeleteContent1.Visible = true;
            }
            else
            {
                this.txtExtensionDeleteContent.Visible = false;
                this.lblExtensionDeleteContent1.Visible = false;

                this.lblExtensionDeleteCount1.Visible = true;
                this.lblExtensionDeleteCount2.Visible = true;
                this.lblExtensionDeletePosition1.Visible = true;
                this.lblExtensionDeletePosition2.Visible = true;
                this.nudExtensionDeletePosition.Visible = true;
                this.nudExtensionDeleteCount.Visible = true;

                this.lblExtensionDeletePosition1.Location = new Point(12, 40);
                this.nudExtensionDeletePosition.Location = new Point(86, 37);
                this.lblExtensionDeletePosition2.Location = new Point(150, 40);

                this.lblExtensionDeleteCount1.Location = new Point(12, 66);
                this.nudExtensionDeleteCount.Location = new Point(62, 64);
                this.lblExtensionDeleteCount2.Location = new Point(126, 66);
            }
            SetNewFileNameToDataTable(sender, e);
        }

        #endregion

        #region 开始批量重命名
        private static bool ModifyFileName(string filepath, string newName)
        {
            var file = new FileInfo(filepath);

            if (!file.Exists) return false;

            try
            {
                File.Move(filepath,
                    filepath.Substring(0, filepath.LastIndexOf("\\", StringComparison.Ordinal) + 1) + newName);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        /// <summary>
        /// 开始批量重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartWork_Click(object sender, EventArgs e)
        {
            if (!(this.dgvFileData.DataSource is DataTable dt) || dt.Rows.Count < 1) return;
            if (this.cbEditFileName.Checked && this.tabOptionControl.SelectedIndex == 0 && !this.cbEnableNumber.Checked)
            {
                MessageBox.Show(Resources.MustEnableNumberSetting);
                return;
            }

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];
                var newFileName = row["NewFileName"] + string.Empty;
                if (string.IsNullOrWhiteSpace(newFileName))
                {
                    MessageBox.Show(Resources.OptionFirst);
                    return;
                }

                var filePath = row["FilePath"] + string.Empty;

                if (ModifyFileName(filePath, newFileName))
                {
                    row["OptionState"] = "操作成功";
                }
                else
                {
                    row["OptionState"] = "操作失败";
                }
            }
            this.dgvFileData.DataSource = dt;
        }

        #endregion

        #region 重命名预览
        /// <summary>
        /// 修改文件名称，添加至DataTable中以供预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetNewFileNameToDataTable(object sender, EventArgs e)
        {
            if (!(this.dgvFileData.DataSource is DataTable dt) || dt.Rows.Count < 1) return;
            if (!this.cbEditFileName.Checked && !this.cbEnableNumber.Checked && !this.cbEnableExtension.Checked && this.rdoNoToggle.Checked) return;

            var number = -99;

            try
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];

                    var sourceFileFullName = row["SourceFileName"] + string.Empty;

                    var sourceFileName = sourceFileFullName.Substring(0, sourceFileFullName.LastIndexOf('.'));

                    var fileExtension = sourceFileFullName.Substring(sourceFileFullName.LastIndexOf('.') + 1);

                    var newFileName = string.Empty;

                    var newFileExtension = string.Empty;

                    //需要修改文件名
                    if (this.cbEditFileName.Checked)
                    {
                        switch (this.tabOptionControl.SelectedIndex)
                        {
                            case 0:
                                var newName = this.txtNewName.Text;
                                if (string.IsNullOrWhiteSpace(newName))
                                {
                                    //MessageBox.Show(Resources.NewFileName);
                                    return;
                                }
                                newFileName = newName;
                                break;
                            case 1:
                                if (string.IsNullOrWhiteSpace(this.txtInsertText.Text))
                                {
                                    //MessageBox.Show(Resources.NewContent);
                                    return;
                                }
                                if (this.rdoInsertStart.Checked)
                                {
                                    newFileName = this.txtInsertText.Text + sourceFileName;
                                }
                                else if (this.rdoInsertEnd.Checked)
                                {
                                    newFileName = sourceFileName + this.txtInsertText.Text;
                                }
                                else
                                {
                                    var position = this.nudInsertCharPosition.Value;
                                    if (position <= 0)
                                    {
                                        //MessageBox.Show(Resources.GreaterThanZero);
                                        return;
                                    }

                                    newFileName = sourceFileName.Insert((int)position, this.txtInsertText.Text);
                                }
                                break;
                            case 2:
                                var searchText = this.txtSearchText.Text;
                                var replaceText = this.txtReplaceText.Text;
                                if (string.IsNullOrWhiteSpace(searchText))
                                {
                                    //MessageBox.Show(Resources.SearchContent);
                                    return;
                                }

                                newFileName = sourceFileName.Replace(searchText, replaceText);
                                break;
                            case 3:
                                if (this.rdoDeletebyContent.Checked)
                                {
                                    var content = this.txtDeleteText.Text;
                                    if (string.IsNullOrWhiteSpace(content))
                                    {
                                        //MessageBox.Show(Resources.DeleteContent);
                                        return;
                                    }

                                    newFileName = sourceFileName.Replace(content, string.Empty);
                                }
                                else
                                {
                                    var deletePosition = this.nudDeletePosition.Value;
                                    var deleteCount = this.nudDeleteCount.Value;
                                    if (deletePosition <= 0 || deleteCount <= 0)
                                    {
                                        //MessageBox.Show(Resources.PositionAndCountMustGreaterThanZero);
                                        return;
                                    }

                                    newFileName = sourceFileName.Remove((int)deletePosition - 1, (int)deleteCount);
                                }
                                break;
                        }
                    }

                    //需要进行编号
                    if (this.cbEnableNumber.Checked)
                    {
                        //初始数值
                        var initialValue = this.nudInitValue.Value;
                        //每次递增
                        var incremental = this.nudIncremental.Value;
                        //数字位数
                        var numberDigits = this.nudNumberDigits.Value;

                        var currentNumber = (number == -99 ? (int)initialValue : number + (int)incremental);

                        if (this.rdoNumberStart.Checked)
                        {
                            newFileName = AddPrefix(currentNumber, (int)numberDigits) + newFileName;
                        }
                        else if (this.rdoNumberEnd.Checked)
                        {
                            newFileName = newFileName + AddPrefix(currentNumber, (int)numberDigits);
                        }
                        else
                        {
                            var numberCount = this.nudNumberCount.Value;
                            newFileName = newFileName.Insert((int)numberCount - 1,
                                AddPrefix(currentNumber, (int)numberDigits));
                        }

                        number = currentNumber;
                    }

                    //需要修改扩展名
                    if (this.cbEnableExtension.Checked)
                    {
                        switch (this.tabExtensionControl.SelectedIndex)
                        {
                            case 0:
                                if (string.IsNullOrWhiteSpace(this.txtNewExtension.Text))
                                {
                                    //MessageBox.Show(Resources.NewExtension);
                                    return;
                                }
                                newFileExtension = this.txtNewExtension.Text;
                                break;
                            case 1:
                                if (string.IsNullOrWhiteSpace(this.txtExtensionInsertText.Text))
                                {
                                    //MessageBox.Show(Resources.NewContent);
                                    return;
                                }
                                if (this.rdoExtensionInsertStart.Checked)
                                {
                                    newFileExtension = this.txtExtensionInsertText.Text + fileExtension;
                                }
                                else if (this.rdoExtensionInsertEnd.Checked)
                                {
                                    newFileExtension = fileExtension + this.txtExtensionInsertText.Text;
                                }
                                else
                                {
                                    var position = this.nudExtensionInsertChar.Value;
                                    if (position <= 0)
                                    {
                                        //MessageBox.Show(Resources.GreaterThanZero);
                                        return;
                                    }

                                    newFileExtension = sourceFileName.Insert((int)position, this.txtExtensionInsertText.Text);
                                }
                                break;
                            case 2:
                                var searchText = this.txtExtensionSearchText.Text;
                                var replaceText = this.txtExtensionReplaceText.Text;
                                if (string.IsNullOrWhiteSpace(searchText))
                                {
                                    //MessageBox.Show(Resources.SearchContent);
                                    return;
                                }

                                newFileExtension = fileExtension.Replace(searchText, replaceText);
                                break;
                            case 3:
                                if (this.rdoExtensionDeleteByContent.Checked)
                                {
                                    var content = this.txtExtensionDeleteContent.Text;
                                    if (string.IsNullOrWhiteSpace(content))
                                    {
                                        //MessageBox.Show(Resources.DeleteContent);
                                        return;
                                    }

                                    newFileExtension = fileExtension.Replace(content, string.Empty);
                                }
                                else
                                {
                                    var deletePosition = this.nudExtensionDeletePosition.Value;
                                    var deleteCount = this.nudExtensionDeleteCount.Value;
                                    if (deletePosition <= 0 || deleteCount <= 0)
                                    {
                                        //MessageBox.Show(Resources.PositionAndCountMustGreaterThanZero);
                                        return;
                                    }
                                    newFileExtension = fileExtension.Remove((int)deletePosition - 1, (int)deleteCount);
                                }
                                break;
                        }
                    }

                    var newFileFullName = (string.IsNullOrWhiteSpace(newFileName) ? sourceFileName : newFileName) + "." +
                                      (string.IsNullOrWhiteSpace(newFileExtension) ? fileExtension : newFileExtension);

                    if (this.rdoAllLow.Checked)
                        newFileFullName = newFileFullName.ToLower();
                    else if (rdoAllUp.Checked)
                        newFileFullName = newFileFullName.ToUpper();

                    row["NewFileName"] = newFileFullName;

                }

            }
            catch
            {
                return;
            }

            this.dgvFileData.DataSource = dt;
        }

        /// <summary>
        /// 添加编号的前缀
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="numberDigits"></param>
        /// <returns></returns>
        private static string AddPrefix(int currentNumber, int numberDigits)
        {
            var currentNumberDigits = currentNumber.ToString().Length;
            if (numberDigits == 1 || numberDigits - currentNumberDigits <= 0) return currentNumber + string.Empty;

            return new string('0', numberDigits - currentNumberDigits) + currentNumber;

        }

        #endregion

        private void DgvFileData_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            var fileCount =
                int.Parse(this.lbl_filecount.Text.Substring(
                    this.lbl_filecount.Text.IndexOf("：", StringComparison.Ordinal) + 1));
            this.lbl_filecount.Text = Resources.TotalFileCount + (--fileCount);
        }
    }
}
