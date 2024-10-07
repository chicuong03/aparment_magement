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
    public partial class Service : Form
    {
        function fu = new function();
        string query;

        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            query = "select id_service,nameservice, priceservice from service";
            DataSet ds = fu.getData(query);
            dgvservice.DataSource = ds.Tables[0];
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnameservice.Text != "" && txtpriceservice.Text != "")
                {
                    query = "update service set nameservice = N'" + txtnameservice.Text + "' , priceservice = " + txtpriceservice.Text + " where id_service = '" + txtid.Text + "'";
                    fu.setData(query, "Cập nhật thành công");
                    Service_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn đang để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtnameservice.Text;
                string price = txtpriceservice.Text;
                query = "insert into service (nameservice, priceservice) values (N'" + name + "','" + price + "')";
                if (txtnameservice.Text != "" && txtpriceservice.Text != "")
                {
                    fu.setData(query, "Thêm thành công");
                    txtnameservice.Clear();
                    txtpriceservice.Clear();
                    Service_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn đang để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvservice.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox tương ứng
                txtid.Text = row.Cells["id_service"].Value.ToString();
                txtnameservice.Text = row.Cells["nameservice"].Value.ToString();
                txtpriceservice.Text = row.Cells["priceservice"].Value.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnameservice.Clear();
            txtpriceservice.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try { 
                if (txtnameservice.Text != "" && txtpriceservice.Text != "")
                {
                    query = "delete from service where id_service =" + txtid.Text + "";
                    fu.setData(query, "Xóa Thành Công");
                    Service_Load(this, null);
                    txtid.Clear();
                    txtnameservice.Clear();
                    txtpriceservice.Clear();
                }
                else
                {
                    MessageBox.Show("Bạn đang để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
