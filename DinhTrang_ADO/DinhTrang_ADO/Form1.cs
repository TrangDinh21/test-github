using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DinhTrang_ADO
{
    public partial class Form1 : Form
    {
        string constring = @"Data Source=PRO-PC\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    //conn.Open();
                    //string sql = "select * from SinhVien ";
                    //SqlCommand cmd = new SqlCommand(sql, conn);
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //DataTable table = new DataTable();
                    //dataGridView1.DataSource = table;
                    //table.Load(reader);


                    //tạo bản sao, không duy trì kết nối
                    //string sql = "select * from SinhVien";
                    //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    //DataTable table = new DataTable();
                    //adapter.Fill(table);
                    //dataGridView1.DataSource = table;


                    //Xem dữ liệu từ nhiều bảng
                    //string sql = "exec inTrongKhoangNam @tu, @den";
                    string sql = "select * from SinhVien";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    //adapter.SelectCommand.Parameters.AddWithValue("@tu",2000);
                    //adapter.SelectCommand.Parameters.AddWithValue("@den", 2005);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    DataTable table = dataSet.Tables[0];
                    dataGridView1.DataSource = table;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

            //conn.Open();
            //conn = new SqlConnection(constring);
            //string sql = "select * form ";
            //SqlCommand cmd = new SqlCommand(sql,conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable table = new DataTable();
            //dataGridView1.DataSource = table;
            //table.Load(reader);
            //conn.Close();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string gt="";
                    if (rdo_nam.Checked) gt = rdo_nam.Text;
                    else gt = rdo_nu.Text;
                    //string sql = "insert into SinhVien values ('"+txt_ma.Text+ "',N'" + txt_ten.Text + "','" + dtp_ngaysinh.Value.ToString("yyyy-MM-dd") + "',N'" +gt+ "') ";
                    string sql = "insert into SinhVien values(@masv,@hoten,@ngaysinh, @gioitinh)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.CommandText;
                    //cmd.CommandType;
                    cmd.Parameters.AddWithValue("@masv", txt_ma.Text);
                    cmd.Parameters.AddWithValue("@hoten", txt_ten.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", dtp_ngaysinh.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gioitinh", gt);
                    cmd.ExecuteNonQuery();

                    Form1_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void butProcedure_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string sql = @"inTrongKhoangNam";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tu", 2000);
                    cmd.Parameters.AddWithValue("@den", 2005);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(read);
                    dataGridView1.DataSource = table;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
