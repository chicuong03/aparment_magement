namespace DACS1_CNTT
{
    partial class changepassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changepassword));
            this.label1 = new System.Windows.Forms.Label();
            this.txtoldpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnewpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtconfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnshow = new Guna.UI2.WinForms.Guna2Button();
            this.btnhide = new Guna.UI2.WinForms.Guna2Button();
            this.btncfshow = new Guna.UI2.WinForms.Guna2Button();
            this.btncfhide = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.lbnoti = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtoldpass
            // 
            this.txtoldpass.BorderRadius = 10;
            this.txtoldpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtoldpass.DefaultText = "";
            this.txtoldpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtoldpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtoldpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtoldpass.DisabledState.Parent = this.txtoldpass;
            this.txtoldpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtoldpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtoldpass.FocusedState.Parent = this.txtoldpass;
            this.txtoldpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtoldpass.HoverState.Parent = this.txtoldpass;
            this.txtoldpass.Location = new System.Drawing.Point(342, 177);
            this.txtoldpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.PasswordChar = '\0';
            this.txtoldpass.PlaceholderText = "Mật khẩu hiện tại";
            this.txtoldpass.SelectedText = "";
            this.txtoldpass.ShadowDecoration.Parent = this.txtoldpass;
            this.txtoldpass.Size = new System.Drawing.Size(349, 44);
            this.txtoldpass.TabIndex = 1;
            // 
            // txtnewpass
            // 
            this.txtnewpass.BorderRadius = 10;
            this.txtnewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnewpass.DefaultText = "";
            this.txtnewpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnewpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnewpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnewpass.DisabledState.Parent = this.txtnewpass;
            this.txtnewpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnewpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnewpass.FocusedState.Parent = this.txtnewpass;
            this.txtnewpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnewpass.HoverState.Parent = this.txtnewpass;
            this.txtnewpass.Location = new System.Drawing.Point(342, 257);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '\0';
            this.txtnewpass.PlaceholderText = "Mật khẩu mới";
            this.txtnewpass.SelectedText = "";
            this.txtnewpass.ShadowDecoration.Parent = this.txtnewpass;
            this.txtnewpass.Size = new System.Drawing.Size(349, 44);
            this.txtnewpass.TabIndex = 2;
            this.txtnewpass.UseSystemPasswordChar = true;
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // txtconfirm
            // 
            this.txtconfirm.BorderRadius = 10;
            this.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirm.DefaultText = "";
            this.txtconfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirm.DisabledState.Parent = this.txtconfirm;
            this.txtconfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirm.FocusedState.Parent = this.txtconfirm;
            this.txtconfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirm.HoverState.Parent = this.txtconfirm;
            this.txtconfirm.Location = new System.Drawing.Point(342, 332);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '\0';
            this.txtconfirm.PlaceholderText = "Xác nhận mật khẩu";
            this.txtconfirm.SelectedText = "";
            this.txtconfirm.ShadowDecoration.Parent = this.txtconfirm;
            this.txtconfirm.Size = new System.Drawing.Size(349, 44);
            this.txtconfirm.TabIndex = 3;
            this.txtconfirm.UseSystemPasswordChar = true;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Transparent;
            this.btnshow.CheckedState.Parent = this.btnshow;
            this.btnshow.CustomImages.Parent = this.btnshow;
            this.btnshow.FillColor = System.Drawing.Color.Transparent;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.HoverState.Parent = this.btnshow;
            this.btnshow.Image = ((System.Drawing.Image)(resources.GetObject("btnshow.Image")));
            this.btnshow.Location = new System.Drawing.Point(698, 275);
            this.btnshow.Name = "btnshow";
            this.btnshow.ShadowDecoration.Parent = this.btnshow;
            this.btnshow.Size = new System.Drawing.Size(45, 26);
            this.btnshow.TabIndex = 6;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.Transparent;
            this.btnhide.CheckedState.Parent = this.btnhide;
            this.btnhide.CustomImages.Parent = this.btnhide;
            this.btnhide.FillColor = System.Drawing.Color.Transparent;
            this.btnhide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhide.ForeColor = System.Drawing.Color.White;
            this.btnhide.HoverState.Parent = this.btnhide;
            this.btnhide.Image = ((System.Drawing.Image)(resources.GetObject("btnhide.Image")));
            this.btnhide.Location = new System.Drawing.Point(698, 275);
            this.btnhide.Name = "btnhide";
            this.btnhide.ShadowDecoration.Parent = this.btnhide;
            this.btnhide.Size = new System.Drawing.Size(45, 26);
            this.btnhide.TabIndex = 6;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btncfshow
            // 
            this.btncfshow.BackColor = System.Drawing.Color.Transparent;
            this.btncfshow.CheckedState.Parent = this.btncfshow;
            this.btncfshow.CustomImages.Parent = this.btncfshow;
            this.btncfshow.FillColor = System.Drawing.Color.Transparent;
            this.btncfshow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncfshow.ForeColor = System.Drawing.Color.White;
            this.btncfshow.HoverState.Parent = this.btncfshow;
            this.btncfshow.Image = ((System.Drawing.Image)(resources.GetObject("btncfshow.Image")));
            this.btncfshow.Location = new System.Drawing.Point(698, 350);
            this.btncfshow.Name = "btncfshow";
            this.btncfshow.ShadowDecoration.Parent = this.btncfshow;
            this.btncfshow.Size = new System.Drawing.Size(45, 26);
            this.btncfshow.TabIndex = 8;
            this.btncfshow.Click += new System.EventHandler(this.btncfshow_Click);
            // 
            // btncfhide
            // 
            this.btncfhide.BackColor = System.Drawing.Color.Transparent;
            this.btncfhide.CheckedState.Parent = this.btncfhide;
            this.btncfhide.CustomImages.Parent = this.btncfhide;
            this.btncfhide.FillColor = System.Drawing.Color.Transparent;
            this.btncfhide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncfhide.ForeColor = System.Drawing.Color.White;
            this.btncfhide.HoverState.Parent = this.btncfhide;
            this.btncfhide.Image = ((System.Drawing.Image)(resources.GetObject("btncfhide.Image")));
            this.btncfhide.Location = new System.Drawing.Point(698, 350);
            this.btncfhide.Name = "btncfhide";
            this.btncfhide.ShadowDecoration.Parent = this.btncfhide;
            this.btncfhide.Size = new System.Drawing.Size(45, 26);
            this.btncfhide.TabIndex = 9;
            this.btncfhide.Click += new System.EventHandler(this.btncfhide_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(434, 416);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Lưu";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.CheckedState.Parent = this.btnexit;
            this.btnexit.CustomImages.Parent = this.btnexit;
            this.btnexit.FillColor = System.Drawing.Color.Transparent;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.HoverState.Parent = this.btnexit;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(0, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Parent = this.btnexit;
            this.btnexit.Size = new System.Drawing.Size(50, 50);
            this.btnexit.TabIndex = 11;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbnoti
            // 
            this.lbnoti.AutoSize = true;
            this.lbnoti.ForeColor = System.Drawing.Color.Red;
            this.lbnoti.Location = new System.Drawing.Point(351, 312);
            this.lbnoti.Name = "lbnoti";
            this.lbnoti.Size = new System.Drawing.Size(226, 16);
            this.lbnoti.TabIndex = 12;
            this.lbnoti.Text = "mật khẩu xác nhận khùng trùng khớp*";
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(212)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1030, 616);
            this.Controls.Add(this.lbnoti);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btncfshow);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtoldpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.btncfhide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "changepassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.changepassword_FormClosing);
            this.Load += new System.EventHandler(this.changepassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtoldpass;
        private Guna.UI2.WinForms.Guna2TextBox txtnewpass;
        private Guna.UI2.WinForms.Guna2TextBox txtconfirm;
        private Guna.UI2.WinForms.Guna2Button btnshow;
        private Guna.UI2.WinForms.Guna2Button btnhide;
        private Guna.UI2.WinForms.Guna2Button btncfshow;
        private Guna.UI2.WinForms.Guna2Button btncfhide;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.Label lbnoti;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}