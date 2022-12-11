using System.Data;
using WindowsFilesBatchRename.Properties;

namespace WindowsFilesBatchRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //���ò��Զ�����������
            this.dgvFileData.AutoGenerateColumns = false;
            //ȥ�����һ�пհ���
            this.dgvFileData.AllowUserToAddRows = false;
            //����ͷһ�пհ���
            this.dgvFileData.RowHeadersVisible = false;
        }

        #region ѡ���ļ����ļ��л�ȡ�ļ�����


        /// <summary>
        /// ѡ���ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chooseFiles_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;//��ֵȷ���Ƿ����ѡ�����ļ�
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
        /// ѡ���ļ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chooseFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            if (string.IsNullOrEmpty(dialog.SelectedPath))
            {
                MessageBox.Show(this, Resources.FilePathIsNotEmpty, Resources.Tips);
                return;
            }
            //ָ�����ļ���Ŀ¼
            var dir = new DirectoryInfo(dialog.SelectedPath);
            if (dir.Exists == false)
            {
                MessageBox.Show(Resources.FilePathIsNotExists);
            }
            else
            {
                var dt = new DataTable();
                InitDataTable(dt);
                //������ʾ��ǰĿ¼���ļ�����Ŀ¼
                var fsInfos = dir.GetFiles();
                //�����������ļ�����Ŀ¼
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
        /// ��ʼ��DataTable�������
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
        /// ��DataTable���һ������
        /// </summary>
        /// <param name="dt">��������DataTable</param>
        /// <param name="filepath">�ļ�ȫ·��</param>
        private void InsertDataTable(DataTable dt, string filepath)
        {
            var row = dt.NewRow();
            var sourceFIleName = filepath[(filepath.LastIndexOf("\\", StringComparison.Ordinal) + 1)..];
            row["Id"] = dt.Rows.Count + 1;
            row["SourceFileName"] = sourceFIleName;
            row["NewFileName"] = string.Empty;
            row["FilePath"] = filepath;
            row["OptionState"] = "������";
            dt.Rows.Add(row);
        }


        #endregion

        #region ҳ����ʾ�����߼�

        /// <summary>
        /// �޸��ļ���ʱtabѡ�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabOptionControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabOptionControl.SelectedIndex)
            {
                //��ѡ����Ϊ�����롱����ʱ��Ĭ��ѡ�С���ͷ��
                case 1:
                    this.rdoInsertStart.Checked = true;
                    break;
                //ѡ����Ϊ��ɾ��������ʱ��Ĭ��ѡ�С�ָ�����ݡ�
                case 3:
                    this.rdoDeletebyContent.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// �޸��ļ���ʱ��������ĵ�ѡ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoInsertRadioButton_CheckedChanged(object sender, EventArgs e)
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
        }
        
        /// <summary>
        /// �޸��ļ���ʱɾ�������ĵ�ѡ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
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
        }

        /// <summary>
        /// ���ñ��ʱ�ĵ�ѡ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoNumberSettingRadioButton_CheckedChanged(object sender, EventArgs e)
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
        }

        /// <summary>
        /// �޸���չ��ʱtabѡ�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabExtensionControl_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        /// <summary>
        /// �޸���չ��ʱ��������ĵ�ѡ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoExtensionInsertRadioButton_CheckedChanged(object sender, EventArgs e)
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
        }

        /// <summary>
        /// �޸���չ��ʱɾ�������ĵ�ѡ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoExtensionDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
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
        }

        #endregion

        private void ModifyFileName(string filepath,string newName)
        {
            var file = new FileInfo(filepath);

            if (file.Exists)
            {
                File.Move(filepath, newName);
            }
        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            if (this.dgvFileData.DataSource is not DataTable dt || dt.Rows.Count < 1) return;

            var number = -99;

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];

                var sourceFileFullName = row["SourceFileName"] + string.Empty;

                var filePath = row["FilePath"] + string.Empty;

                var sourceFileName = sourceFileFullName[..sourceFileFullName.LastIndexOf('.')];

                var fileExtension = sourceFileFullName[(sourceFileFullName.LastIndexOf('.') + 1)..];

                var newFileName = string.Empty;

                var newFileExtension = string.Empty;
                
                //��Ҫ�޸��ļ���
                if (this.cbEditFileName.Checked)
                {
                    switch (this.tabOptionControl.SelectedIndex)
                    {
                        case 0:
                            var newName = this.txtNewName.Text;
                            if (string.IsNullOrWhiteSpace(newName))
                            {
                                MessageBox.Show(Resources.NewFileName);
                                return;
                            }
                            newFileName = newName;
                            break;
                        case 1:
                            if (string.IsNullOrWhiteSpace(this.txtInsertText.Text))
                            {
                                MessageBox.Show(Resources.NewContent);
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
                                    MessageBox.Show(Resources.GreaterThanZero);
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
                                MessageBox.Show(Resources.SearchContent);
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
                                    MessageBox.Show(Resources.DeleteContent);
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
                                    MessageBox.Show(Resources.PositionAndCountMustGreaterThanZero);
                                    return;
                                }

                                newFileName = sourceFileName.Remove((int)deletePosition - 1, (int)deleteCount);
                            }
                            break;
                    }
                }

                //��Ҫ���б��
                if (this.cbEnableNumber.Checked)
                {
                    //��ʼ��ֵ
                    var initialValue = this.nudInitValue.Value;
                    //ÿ�ε���
                    var incremental = this.nudIncremental.Value;
                    //����λ��
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

                //��Ҫ�޸���չ��
                if (this.cbEnableExtension.Checked)
                {
                    switch (this.tabExtensionControl.SelectedIndex)
                    {
                        case 0:
                            if (string.IsNullOrWhiteSpace(this.txtNewExtension.Text))
                            {
                                MessageBox.Show(Resources.NewExtension);
                                return;
                            }
                            newFileExtension = this.txtNewExtension.Text;
                            break;
                        case 1:
                            if (string.IsNullOrWhiteSpace(this.txtExtensionInsertText.Text))
                            {
                                MessageBox.Show(Resources.NewContent);
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
                                    MessageBox.Show(Resources.GreaterThanZero);
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
                                MessageBox.Show(Resources.SearchContent);
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
                                    MessageBox.Show(Resources.DeleteContent);
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
                                    MessageBox.Show(Resources.PositionAndCountMustGreaterThanZero);
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

                if (filePath == string.Empty)
                {
                    ModifyFileName(filePath, newFileFullName);
                }
            }

            this.dgvFileData.DataSource = dt;
        }
        
        private static string AddPrefix(int currentNumber,int numberDigits)
        {
            var currentNumberDigits = currentNumber.ToString().Length;
            if (numberDigits == 1 || numberDigits - currentNumberDigits <= 0) return currentNumber + string.Empty;
            
            return new string('0', numberDigits - currentNumberDigits) + currentNumber;
            
        }
        

    }
}