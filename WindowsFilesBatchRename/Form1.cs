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

            //���ò��Զ�����������
            this.dataGridView1.AutoGenerateColumns = false;
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
            dialog.Filter = "�����ļ�(*.*)|*.*";

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
            this.lbl_filecount.Text = "�ļ�������" + dt.Rows.Count;
            this.dataGridView1.Visible = true;
        }

        /// <summary>
        /// ѡ���ļ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chooseFolder_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            if (string.IsNullOrEmpty(dialog.SelectedPath))
            {
                MessageBox.Show(this, "�ļ���·������Ϊ��", "��ʾ");
                return;
            }
            //ָ�����ļ���Ŀ¼
            var dir = new DirectoryInfo(dialog.SelectedPath);
            if (dir.Exists == false)
            {
                MessageBox.Show("·�������ڣ�����������");
            }
            else
            {
                var dt = new DataTable();
                initDatatable(dt);
                //������ʾ��ǰĿ¼���ļ�����Ŀ¼
                FileSystemInfo[] fsInfos = dir.GetFiles();
                //�����������ļ�����Ŀ¼
                foreach (var fsInfo in fsInfos)
                {
                    insertDataTable(dt, fsInfo.FullName);

                }
                this.dataGridView1.DataSource = dt;
                this.lbl_filecount.Text = "�ļ�������" + dt.Rows.Count;
                this.dataGridView1.Visible = true;
            }
        }

        /// <summary>
        /// ��ʼ��DataTable�������
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
        /// ��DataTable���һ������
        /// </summary>
        /// <param name="dt">��������DataTable</param>
        /// <param name="filepath">�ļ�ȫ·��</param>
        private void insertDataTable(DataTable dt, string filepath)
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


    }
}