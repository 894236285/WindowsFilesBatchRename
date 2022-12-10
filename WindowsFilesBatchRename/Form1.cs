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
            this.lbl_filecount.Text = "文件数量：" + dt.Rows.Count;
        }

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
                this.lbl_filecount.Text = "文件数量：" + dt.Rows.Count;
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
            row["OptionState"] = "待操作";
            dt.Rows.Add(row);
        }
        
    }
}