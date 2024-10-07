using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DACS1_CNTT
{
    public partial class update : Form
    {
        function fu = new function();
        string query; public string SelectedOrderId { get; set; }
        public update()
        {
            InitializeComponent();
        }
        public update(string orderId)
        {
            InitializeComponent();
           
            SelectedOrderId = txtidroom.Text;
        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
 

        private void update_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Selected Order ID: " + SelectedOrderId);
                txtidroom.Text = SelectedOrderId;
                lbnoti.Visible = false;
                query = "select * from newhuman where roomNo ='" + txtidroom.Text + "'";
                DataSet ds = fu.getData(query);
                txthovaten.Text = ds.Tables[0].Rows[0]["name_"].ToString();
                txtcccd.Text = ds.Tables[0].Rows[0]["idproof"].ToString();
                txtdc.Text = ds.Tables[0].Rows[0]["paddress"].ToString();
                txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                cbxstatus.Text = ds.Tables[0].Rows[0]["living"].ToString();
                txtphone.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            txthovaten.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtidroom.Clear();
            txtdc.Clear();
            txtcccd.Clear();
            cbxstatus.Text = "";
        }

        

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string idroom = txtidroom.Text;
                string hovaten = txthovaten.Text;
                string dc = txtdc.Text;
                Int64 phone = Int64.Parse(txtphone.Text);
                string email = txtemail.Text;
                string cccd = txtcccd.Text;
                string status = cbxstatus.Text;
                query = "update newhuman set name_= N'" + hovaten + "', paddress =N'" + dc + "', mobile= " + phone + ", email='" + email + "', idproof='" + cccd + "', living='" + status + "'  where roomNo=" + idroom + "update rooms set booked ='" + status + "' where roomNo=" + idroom + "";
                fu.setData(query, "Cập nhật thành công");
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void lbnoti_Click(object sender, EventArgs e)
        {

        }

        private void txtidroom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxidroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
        }

        private void btncapnhat_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idroom = txtidroom.Text;
                string hovaten = txthovaten.Text;
                string dc = txtdc.Text;
                Int64 phone = Int64.Parse(txtphone.Text);
                string email = txtemail.Text;
                string cccd = txtcccd.Text;
                string status = cbxstatus.Text;
                query = "update newhuman set name_= '" + hovaten + "', paddress ='" + dc + "', mobile= " + phone + ", email='" + email + "', idproof='" + cccd + "', living='" + status + "  where roomNo=" + idroom + "update rooms set Booked ='" + status + "' where roomNo=" + idroom + "";
                fu.setData(query, "Cập nhật thành công");
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void cbxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndeletepeople_Click(object sender, EventArgs e)
        {
            try
            {
                string idroom = txtidroom.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "DELETE FROM newhuman WHERE roomNo = " + idroom + "; " +
                                   "UPDATE rooms SET Booked = 'Trong' WHERE roomNo = " + idroom + " delete from priceroom where roomNo = " + idroom + "";
                    fu.setData(query, "xóa Thành công");


                    txthovaten.Clear();
                    txtphone.Clear();
                    txtemail.Clear();
                    txtdc.Clear();
                    txtcccd.Clear();
                    cbxstatus.Text = "";
                    txtidroom.Clear();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi","Thông báo");
            }
        }

        private void txtidroom_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
