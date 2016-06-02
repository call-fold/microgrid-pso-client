using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class History : Form
    {
        MySqlConnection conn;//mysql连接
        MySqlDataAdapter myadp;//mysql数据适配器
        DataSet myds;//数据集
        int start_edit = 0;

        public History()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            try
            {//打开菜单配置数据库连接
                conn = new MySqlConnection();//实例化数据库连接
                conn.ConnectionString = Global.MyConnectionString;//配置连接
                conn.Open();//打开连接
                myadp = new MySqlDataAdapter("select * from history", conn);
                myds = new DataSet();//填充和绑定数据
                myadp.Fill(myds, "history");
                dataGridView.AutoGenerateColumns = false;//不生成新的列
                dataGridView.DataSource = myds.Tables["history"];
                //把数据赋给名称对应的列并显示

                dataGridView.Columns["history_id"].DataPropertyName = myds.Tables["history"].Columns["history_id"].ToString();
                dataGridView.Columns["algorithm_id"].DataPropertyName = myds.Tables["history"].Columns["algorithm_id"].ToString();
                dataGridView.Columns["cost_time"].DataPropertyName = myds.Tables["history"].Columns["cost_time"].ToString();
                dataGridView.Columns["iter"].DataPropertyName = myds.Tables["history"].Columns["iter"].ToString();
                dataGridView.Columns["gather_num"].DataPropertyName = myds.Tables["history"].Columns["gather_num"].ToString();
                dataGridView.Columns["g_max"].DataPropertyName = myds.Tables["history"].Columns["g_max"].ToString();
                dataGridView.Columns["process_num"].DataPropertyName = myds.Tables["history"].Columns["process_num"].ToString();
                dataGridView.Columns["date_time"].DataPropertyName = myds.Tables["history"].Columns["date_time"].ToString();
                dataGridView.Columns["result"].DataPropertyName = myds.Tables["history"].Columns["result"].ToString();

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("不能连接到数据库服务器，请联系数据库管理员！"); break;
                    case 1045:
                        MessageBox.Show("无效的用户名/密码，请重试！"); break;
                    case 1049:
                        MessageBox.Show("数据库不存在，或数据库名错误"); break;
                    default:
                        MessageBox.Show(ex.Message); break;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (start_edit == 0)
                {
                    int del = dataGridView.SelectedRows.Count;
                    for (int i = del; i >= 1; i--)//从下往上，避免沙漏效应
                    {
                        String index0 = dataGridView.Rows[dataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString();
                        dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[i - 1].Index);
                        String str = String.Format("delete from history where history_id={0}", index0);
                        MySqlCommand sql = new MySqlCommand(str, conn);
                        sql.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("请退出修改模式再进行删除操作！");
                }
            }
        }

        private void buttonMoreThings_Click(object sender, EventArgs e)
        {
            int current_id = Convert.ToInt16(((DataTable)this.dataGridView.DataSource).Rows[dataGridView.CurrentRow.Index].ItemArray[0].ToString());

            MoreThings moreThings = new MoreThings(current_id);
            moreThings.Show();
        }

        private void buttonFresh_Click(object sender, EventArgs e)
        {
            history_Load(null, null);
        }
    }
}
