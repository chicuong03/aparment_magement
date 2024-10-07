using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DACS1_CNTT
{
    public partial class addroom : Form
    {
        function fu = new function();
        string query;
        public addroom()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            this.Close(); // Đóng Form2



        }

 

        private void addroom_Load(object sender, EventArgs e)
        {         
            query = "select * from rooms order by roomNo DESC";
            DataSet ds = fu.getData(query);
            dgvinfo.DataSource = ds.Tables[0];

        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from rooms where roomNo=" + txtroomnumber2.Text + "";
                DataSet ds = fu.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    string status;
                    if (checkbox2.Checked)
                    {
                        status = "san sang";
                    }
                    else
                    {
                        status = "khong san sang";
                    }
                    query = "insert into rooms (roomNo,roomStatus) values('" + txtroomnumber2.Text + "','" + status + "')";
                    fu.setData(query, "Đã Thêm thành công *");
                    lbnoti2.Visible = false;
                    txtroomnumber2.Clear();
                    addroom_Load(this, null);
                }
                else
                {
                    lbnoti2.Text = "Phòng đã có trong hệ thống *";
                    lbnoti2.Visible = true;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {               
                    query = "delete from rooms where roomNo ='" + txtroomnumber2.Text + "'";
                    fu.setData(query, "Xóa thành công !");
                    addroom_Load(this, null);
                    lbnoti2.Visible = false;
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtroomnumber2.Text != "")
                {
                    query = "select * from rooms where roomNo=" + txtroomnumber2.Text + "";
                    DataSet ds = fu.getData(query);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        lbnoti2.Text = "Phòng không tồn tại";
                        lbnoti2.Visible = true;
                        
                    }
                    else
                    {
                        lbnoti2.Text = "Phòng đã tìm được";
                        lbnoti2.Visible = true;
                        if (ds.Tables[0].Rows[0][1].ToString() == "yes")
                        {
                            checkbox2.Checked = true;
                        }
                        dgvinfo.DataSource = ds.Tables[0];
                    }

                }
                else
                { MessageBox.Show("Bạn cần nhập số phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string status;
                if (checkbox2.Checked)
                {
                    status = "san sang";
                }
                else { status = "khong san sang"; }

                if (txtroomnumber2.Text != "")
                {
                    query = "update rooms set roomStatus ='" + status + "'where roomNo= " + txtroomnumber2.Text + "";
                    fu.setData(query, "Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập Số phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addroom_Load(this, null);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void dgvinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addroom_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dgvinfo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvinfo.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox tương ứng
                txtroomnumber2.Text = row.Cells["roomNo"].Value.ToString();
            }
        }

        private void txtroomnumber2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
