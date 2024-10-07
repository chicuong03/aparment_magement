using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DACS1_CNTT
{
    public partial class bill : Form
    {
        function fu = new function();
        string query;
        public string SelectedId { get; set; }
        public bill()
        {
            InitializeComponent();
            SelectedId = cbxroomnumber.Text;
        }

        private void bill_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Selected Order ID: " + SelectedId);
                txtid.Text = SelectedId;
                query = "select roomNo from rooms where roomStatus = 'san sang' and Booked = 'da thue'";
                DataSet ds = fu.getData(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                    cbxroomnumber.Items.Add(room);
                }

                query = "select nameservice,priceservice, choose from service";
                DataSet d = fu.getData(query);
                lstservice.DataSource = d.Tables[0];
                lstservice.DisplayMember = "nameservice";
                if (txtid.Text != "")
                {
                    cbxroomnumber.Visible = false;
                }
                else
                {
                    txtid.Visible = false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {           
            this.Hide();
            
        }

        private decimal oldElectricValue = 0;
        private decimal oldWaterValue = 0;
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsodien.Text == "" || txtsonuoc.Text == "" || txtgiaphong.Text == "")
                {
                    MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   if(txtid.Text != "")
                    {
                        
                        DateTime selectedDate = datetime.Value;
                        // Extract year from the selectedDate
                        int year = selectedDate.Year;
                        // Định dạng DateTime thành chuỗi
                        string dateString = selectedDate.ToString("yyyy/MM/dd");
                        string giadien = txtgiadien.Text;
                        string gianuoc = txtgianuoc.Text;
                        string sodien = txtsodien.Text;
                        string sonuoc = txtsonuoc.Text;
                        string giaphong = txtgiaphong.Text;
                        Int64 sophong = Int64.Parse(txtid.Text);
                        // Lấy số điện cũ nhất từ cơ sở dữ liệu
                        string query1 = "SELECT TOP 1 electric FROM priceroom WHERE roomNo = " + sophong + " ORDER BY year DESC, month DESC";
                        DataSet ds1 = fu.getData(query1);

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            oldElectricValue = Convert.ToDecimal(ds1.Tables[0].Rows[0]["electric"]);
                        }

                        float toatalelcetric = Convert.ToSingle(txtsodien.Text) - Convert.ToSingle(oldElectricValue);

                        string totalelectri = toatalelcetric.ToString();

                        // Lấy số nước cũ nhất từ cơ sở dữ liệu
                        string query2 = "SELECT TOP 1 water FROM priceroom WHERE roomNo = " + sophong + " ORDER BY year DESC, month DESC";
                        DataSet ds2 = fu.getData(query2);

                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            oldWaterValue = Convert.ToDecimal(ds2.Tables[0].Rows[0]["water"]);
                        }

                        float toatalwater = Convert.ToSingle(txtsonuoc.Text) - Convert.ToSingle(oldWaterValue);

                        string totalwater = toatalwater.ToString();
                        // tổng tiền service
                        string sumservice = txtpriceservice.Text;
                        // Tính tổng tiền
                        decimal giadien_sodien = decimal.Parse(giadien) * decimal.Parse(totalelectri);
                        decimal gianuoc_sonuoc = decimal.Parse(gianuoc) * decimal.Parse(totalwater);
                        decimal tongtien_value = giadien_sodien + gianuoc_sonuoc + decimal.Parse(giaphong) + decimal.Parse(sumservice);

                        // Hiển thị tổng tiền lên txttongtien
                        txttongtien.Text = tongtien_value.ToString("N2"); // Hiển thị với 2 chữ số sau dấu phẩy
                        txttongdien.Text = giadien_sodien.ToString();
                        txttongnuoc.Text = gianuoc_sonuoc.ToString();
                        
                        string query = "INSERT INTO priceroom (roomNo, year, month, electric, unitpriceelectric, water, unitpricewater, autumnday, price, moneyelectric, moneywater, summoney) " +
                        "VALUES (" + sophong + ", " + year + ", " + selectedDate.Month + ", " + sodien + ", " + giadien + ", " + sonuoc + ", " + gianuoc + ", '" + dateString + "', " + giaphong + ", " + giadien_sodien + ", " + gianuoc_sonuoc + ", " + tongtien_value + ")";
                        //MessageBox.Show(query);
                         fu.setData(query, "Thêm tiền phòng Thành công");

                    }
                    else
                    {
                        
                        DateTime selectedDate = datetime.Value;
                        // Extract year from the selectedDate
                        int year = selectedDate.Year;
                        // Định dạng DateTime thành chuỗi
                        string dateString = selectedDate.ToString("yyyy/MM/dd");
                        string giadien = txtgiadien.Text;
                        string gianuoc = txtgianuoc.Text;
                        string sodien = txtsodien.Text;
                        string sonuoc = txtsonuoc.Text;
                        string giaphong = txtgiaphong.Text;
                        Int64 sophong = Int64.Parse(cbxroomnumber.Text);
                        // Lấy số điện cũ nhất từ cơ sở dữ liệu
                        string query1 = "SELECT TOP 1 electric FROM priceroom WHERE roomNo = " + cbxroomnumber.Text + " ORDER BY year DESC, month DESC";
                        DataSet ds1 = fu.getData(query1);

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            oldElectricValue = Convert.ToDecimal(ds1.Tables[0].Rows[0]["electric"]);
                        }

                        float toatalelcetric = Convert.ToSingle(txtsodien.Text) - Convert.ToSingle(oldElectricValue);

                        string totalelectri = toatalelcetric.ToString();

                        // Lấy số nước cũ nhất từ cơ sở dữ liệu
                        string query2 = "SELECT TOP 1 water FROM priceroom WHERE roomNo = " + cbxroomnumber.Text + " ORDER BY year DESC, month DESC";
                        DataSet ds2 = fu.getData(query2);

                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            oldWaterValue = Convert.ToDecimal(ds2.Tables[0].Rows[0]["water"]);
                        }

                        float toatalwater = Convert.ToSingle(txtsonuoc.Text) - Convert.ToSingle(oldWaterValue);

                        string totalwater = toatalwater.ToString();
                        // tổng tiền service
                        string sumservice = txtpriceservice.Text;
                        // Tính tổng tiền
                        decimal giadien_sodien = decimal.Parse(giadien) * decimal.Parse(totalelectri);
                        decimal gianuoc_sonuoc = decimal.Parse(gianuoc) * decimal.Parse(totalwater);
                        decimal tongtien_value = giadien_sodien + gianuoc_sonuoc + decimal.Parse(giaphong) + decimal.Parse(sumservice);

                        // Hiển thị tổng tiền lên txttongtien
                        txttongtien.Text = tongtien_value.ToString("N2"); // Hiển thị với 2 chữ số sau dấu phẩy
                        txttongdien.Text = giadien_sodien.ToString();
                        txttongnuoc.Text = gianuoc_sonuoc.ToString();
                        string idr = txtid.Text;
                        string query = "INSERT INTO priceroom (roomNo, year, month, electric, unitpriceelectric, water, unitpricewater, autumnday, price, moneyelectric, moneywater, summoney) " +
                        "VALUES (" + sophong + ", " + year + ", " + selectedDate.Month + ", " + sodien + ", " + giadien + ", " + sonuoc + ", " + gianuoc + ", '" + dateString + "', " + giaphong + ", " + giadien_sodien + ", " + gianuoc_sonuoc + ", " + tongtien_value + ")";

                        fu.setData(query, "Thêm tiền phòng Thành công");


                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


           private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (cbxroomnumber.Text == "" && txtid.Text == "")
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(cbxroomnumber.Text != "")
                {
                    string query = "SELECT electric,unitpriceelectric, water, unitpricewater, autumnday,price,moneyelectric,moneywater,summoney  FROM priceroom WHERE roomNo = " + cbxroomnumber.Text + "";
                    DataSet ds = fu.getData(query);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Hiển thị dữ liệu lên các TextBox hoặc Controls khác
                        txtsodien.Text = ds.Tables[0].Rows[0]["electric"].ToString();
                        txtsonuoc.Text = ds.Tables[0].Rows[0]["water"].ToString();
                        txtgiadien.Text = ds.Tables[0].Rows[0]["unitpriceelectric"].ToString();
                        txtgianuoc.Text = ds.Tables[0].Rows[0]["unitpricewater"].ToString();
                        txttongdien.Text = ds.Tables[0].Rows[0]["moneyelectric"].ToString();
                        txttongnuoc.Text = ds.Tables[0].Rows[0]["moneywater"].ToString();
                        txttongtien.Text = ds.Tables[0].Rows[0]["summoney"].ToString();
                        txtgiaphong.Text = ds.Tables[0].Rows[0]["price"].ToString();
                        datetime.Text = ds.Tables[0].Rows[0]["autumnday"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }  
                else
                {
                    Int64 sophong = Int64.Parse(txtid.Text);
                    string query = "SELECT electric,unitpriceelectric, water, unitpricewater, autumnday,price,moneyelectric,moneywater,summoney  FROM priceroom WHERE roomNo = " + sophong + "";
                    DataSet ds = fu.getData(query);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Hiển thị dữ liệu lên các TextBox hoặc Controls khác
                        txtsodien.Text = ds.Tables[0].Rows[0]["electric"].ToString();
                        txtsonuoc.Text = ds.Tables[0].Rows[0]["water"].ToString();
                        txtgiadien.Text = ds.Tables[0].Rows[0]["unitpriceelectric"].ToString();
                        txtgianuoc.Text = ds.Tables[0].Rows[0]["unitpricewater"].ToString();
                        txttongdien.Text = ds.Tables[0].Rows[0]["moneyelectric"].ToString();
                        txttongnuoc.Text = ds.Tables[0].Rows[0]["moneywater"].ToString();
                        txttongtien.Text = ds.Tables[0].Rows[0]["summoney"].ToString();
                        txtgiaphong.Text = ds.Tables[0].Rows[0]["price"].ToString();
                        datetime.Text = ds.Tables[0].Rows[0]["autumnday"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
              
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }  
        }

        private void cbxroomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cbxroomnumber.SelectedItem = null;
            txtgiadien.Clear();
            txtsodien.Clear();
            txtgianuoc.Clear();
            txttongdien.Clear();
            txtgiaphong.Clear();
            txttongnuoc.Clear();
            txttongtien.Clear();
            txtsonuoc.Clear();
            txtpriceservice.Clear();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from priceroom where roomNo ='" + cbxroomnumber.Text + "'";
                DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    fu.setData(query, "Xóa Thành công");
                    cbxroomnumber.SelectedItem = null;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi thao tác", "Lỗi");
            }
        }

        
        private void dgvservice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
        private bool IsDBNull(object value)
        {
            return value == DBNull.Value;
        }
        private void dgvservice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void txtsodien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstservice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataRowView item in lstservice.SelectedItems)
            {
                int price = Convert.ToInt32(item["priceservice"]);
                total += price;
            }
            txtpriceservice.Text = total.ToString();
        }

        private void cbxroomnumber_Click(object sender, EventArgs e)
        {
            txtid.Clear();
        }
    }
}
