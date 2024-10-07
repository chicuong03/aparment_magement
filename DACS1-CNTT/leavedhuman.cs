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
    public partial class leavedhuman : Form
    {
        function fu = new function();
        string query;
        public leavedhuman()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
        }

        private void leavedhuman_Load(object sender, EventArgs e)
        {
            query = "select * from newhuman where living ='Trong'";
            DataSet ds = fu.getData(query);
            dgvlist.DataSource = ds.Tables[0];
        }
    }
}
