using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class Battery : Form
    {
        MySqlConnection conn;//mysql连接
        MySqlDataAdapter myadp;//mysql数据适配器
        DataSet myds;//数据集
        int start_edit = 0;
        public Battery()
        {
            InitializeComponent();
        }

        private void battery_Load(object sender, EventArgs e)
        {
            try
            {//打开菜单配置数据库连接
                conn = new MySqlConnection();//实例化数据库连接
                conn.ConnectionString = Global.MyConnectionString;//配置连接
                conn.Open();//打开连接
                myadp = new MySqlDataAdapter("select*from battery", conn);
                myds = new DataSet();//填充和绑定数据
                myadp.Fill(myds, "battery");
                dataGridView.AutoGenerateColumns = false;//不生成新的列
                dataGridView.DataSource = myds.Tables["battery"];
                //把数据赋给名称对应的列并显示

                dataGridView.Columns["bat_time"].DataPropertyName = myds.Tables["battery"].Columns["bat_time"].ToString();
                dataGridView.Columns["bus_index"].DataPropertyName = myds.Tables["battery"].Columns["bus_index"].ToString();
                dataGridView.Columns["bat_num"].DataPropertyName = myds.Tables["battery"].Columns["bat_num"].ToString();
                dataGridView.Columns["bat_Pmax"].DataPropertyName = myds.Tables["battery"].Columns["bat_Pmax"].ToString();
                dataGridView.Columns["bat_Pmin"].DataPropertyName = myds.Tables["battery"].Columns["bat_Pmin"].ToString();
                dataGridView.Columns["bat_p"].DataPropertyName = myds.Tables["battery"].Columns["bat_P"].ToString();

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (start_edit == 0)
            {
                try
                {
                    dataGridView.DataSource = myds.Tables["battery"];
                    MySqlCommandBuilder mycb = new MySqlCommandBuilder(myadp);
                    myadp.Update(myds.Tables["battery"]);
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1452:
                            MessageBox.Show("不能在没有父表格的情况下直接对子表格赋值！"); break;
                        default:
                            MessageBox.Show(ex.Message); break;
                    }
                }
            }
            else
            {
                MessageBox.Show("请退出修改模式再插入数据！");
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
                        String str = String.Format("delete from battery where bat_num={0}", index0);
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            start_edit += 1;
            if (start_edit == 2)
            {
                start_edit = 0;
                dataGridView.DefaultCellStyle.BackColor = Color.White;
                MessageBox.Show("成功完成修改");
            }
            if (start_edit == 1)
            {
                dataGridView.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (start_edit == 1)
            {
                String xl_row0 = "";
                String xl_column = "";
                String xl_cell = "";
                xl_row0 = dataGridView.Rows[dataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString();
                xl_column = dataGridView.Columns[dataGridView.CurrentCellAddress.X].Name;
                xl_cell = dataGridView.CurrentCell.Value.ToString();
                try
                {
                    String str = String.Format("update battery set {0}={1} where bat_num={2}", xl_column, xl_cell, xl_row0);
                    MySqlCommand strsql = new MySqlCommand(str, conn);
                    strsql.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1452:
                            MessageBox.Show("不能在没有父表格的情况下直接对子表格赋值！"); break;
                        default:
                            MessageBox.Show(ex.Message); break;
                    }
                }
            }
        }
    }
}
