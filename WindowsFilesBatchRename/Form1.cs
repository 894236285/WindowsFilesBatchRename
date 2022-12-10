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

            this.dataGridView1.AutoGenerateColumns = false;
        }

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
        }

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
            }
        }
        

        private void initDatatable(DataTable dt)
        {
            dt.Columns.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("SourceFileName");
            dt.Columns.Add("NewFileName");
            dt.Columns.Add("FilePath");
            dt.Columns.Add("OptionState");
        }

        private void insertDataTable(DataTable dt, string filepath)
        {
            var row = dt.NewRow();
            var sourceFIleName = filepath[(filepath.LastIndexOf("\\", StringComparison.Ordinal)+1)..];
            row["Id"] = dt.Rows.Count + 1;
            row["SourceFileName"] = sourceFIleName;
            row["NewFileName"] = string.Empty;
            row["FilePath"] = filepath;
            row["OptionState"] = "������";
            dt.Rows.Add(row);
        }
        
    }
}