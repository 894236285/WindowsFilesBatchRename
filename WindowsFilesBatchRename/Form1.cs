using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFilesBatchRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //设置不自动新增数据列
            this.dataGridView1.AutoGenerateColumns = false;
        }

        #region 选择文件或文件夹获取文件数据


        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chooseFiles_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Filter = "所有文件(*.*)|*.*";

            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;


            var dt = new DataTable();
            initDatatable(dt);

            if (dialog.Multiselect)
            {
                foreach (var t in dialog.FileNames)
                {
                    insertDataTable(dt, t);
                }
            }
            else
            {
                insertDataTable(dt, dialog.FileName);
            }


            this.dataGridView1.DataSource = dt;
            this.lbl_filecount.Text = "文件总数：" + dt.Rows.Count;
            this.dataGridView1.Visible = true;
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chooseFolder_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            if (string.IsNullOrEmpty(dialog.SelectedPath))
            {
                MessageBox.Show(this, "文件夹路径不能为空", "提示");
                return;
            }
            //指定的文件夹目录
            var dir = new DirectoryInfo(dialog.SelectedPath);
            if (dir.Exists == false)
            {
                MessageBox.Show("路径不存在！请重新输入");
            }
            else
            {
                var dt = new DataTable();
                initDatatable(dt);
                //检索表示当前目录的文件和子目录
                FileSystemInfo[] fsInfos = dir.GetFiles();
                //遍历检索的文件和子目录
                foreach (var fsInfo in fsInfos)
                {
                    insertDataTable(dt, fsInfo.FullName);

                }
                this.dataGridView1.DataSource = dt;
                this.lbl_filecount.Text = "文件总数：" + dt.Rows.Count;
                this.dataGridView1.Visible = true;
            }
        }

        /// <summary>
        /// 初始化DataTable，添加列
        /// </summary>
        /// <param name="dt"></param>
        private void initDatatable(DataTable dt)
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
        private void insertDataTable(DataTable dt, string filepath)
        {
            var row = dt.NewRow();
            var sourceFIleName = filepath[(filepath.LastIndexOf("\\", StringComparison.Ordinal) + 1)..];
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
        private void tabOptionControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabOptionControl.SelectedIndex)
            {
                //当选项变更为“插入”操作时，默认选中“开头”
                case 1:
                    this.rdoInsertStart.Checked = true;
                    break;
                //选项当变更为“删除”操作时，默认选中“指定内容”
                case 3:
                    this.rdoDeletebyContent.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// 修改文件名时插入操作的单选按钮变更事件
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
        /// 修改文件名时删除操作的单选按钮变更事件
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
        /// 设置编号时的单选按钮变更事件
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
        /// 修改扩展名时tab选项卡变更事件
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
        /// 修改扩展名时插入操作的单选按钮变更事件
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
        /// 修改扩展名时删除操作的单选按钮变更事件
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


    }
}