namespace DACS1_CNTT
{
    partial class listrentperson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listrentperson));
            this.label1 = new System.Windows.Forms.Label();
            this.btnfind = new Guna.UI2.WinForms.Guna2Button();
            this.dgvlistperson = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtfind = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnbill = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NGƯỜI THUÊ";
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Transparent;
            this.btnfind.BorderRadius = 9;
            this.btnfind.BorderThickness = 2;
            this.btnfind.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnfind.CheckedState.Parent = this.btnfind;
            this.btnfind.CustomImages.Parent = this.btnfind;
            this.btnfind.FillColor = System.Drawing.Color.Transparent;
            this.btnfind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.Color.Black;
            this.btnfind.HoverState.Parent = this.btnfind;
            this.btnfind.Location = new System.Drawing.Point(707, 55);
            this.btnfind.Name = "btnfind";
            this.btnfind.ShadowDecoration.Parent = this.btnfind;
            this.btnfind.Size = new System.Drawing.Size(168, 45);
            this.btnfind.TabIndex = 1;
            this.btnfind.Text = "Tìm Kiếm";
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // dgvlistperson
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvlistperson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlistperson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlistperson.BackgroundColor = System.Drawing.Color.White;
            this.dgvlistperson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvlistperson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvlistperson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistperson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlistperson.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlistperson.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlistperson.EnableHeadersVisualStyles = false;
            this.dgvlistperson.GridColor = System.Drawing.Color.Black;
            this.dgvlistperson.Location = new System.Drawing.Point(12, 119);
            this.dgvlistperson.Name = "dgvlistperson";
            this.dgvlistperson.RowHeadersVisible = false;
            this.dgvlistperson.RowHeadersWidth = 51;
            this.dgvlistperson.RowTemplate.Height = 24;
            this.dgvlistperson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistperson.Size = new System.Drawing.Size(1006, 381);
            this.dgvlistperson.TabIndex = 2;
            this.dgvlistperson.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvlistperson.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvlistperson.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvlistperson.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvlistperson.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvlistperson.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvlistperson.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvlistperson.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvlistperson.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvlistperson.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvlistperson.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvlistperson.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvlistperson.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvlistperson.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvlistperson.ThemeStyle.ReadOnly = false;
            this.dgvlistperson.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvlistperson.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvlistperson.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvlistperson.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvlistperson.ThemeStyle.RowsStyle.Height = 24;
            this.dgvlistperson.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvlistperson.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvlistperson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistperson_CellContentClick);
            // 
            // txtfind
            // 
            this.txtfind.BorderRadius = 4;
            this.txtfind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfind.DefaultText = "";
            this.txtfind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfind.DisabledState.Parent = this.txtfind;
            this.txtfind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfind.FocusedState.Parent = this.txtfind;
            this.txtfind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfind.HoverState.Parent = this.txtfind;
            this.txtfind.Location = new System.Drawing.Point(12, 56);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfind.Name = "txtfind";
            this.txtfind.PasswordChar = '\0';
            this.txtfind.PlaceholderText = "";
            this.txtfind.SelectedText = "";
            this.txtfind.ShadowDecoration.Parent = this.txtfind;
            this.txtfind.Size = new System.Drawing.Size(688, 44);
            this.txtfind.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.CheckedState.Parent = this.btnback;
            this.btnback.CustomImages.Parent = this.btnback;
            this.btnback.FillColor = System.Drawing.Color.Transparent;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.HoverState.Parent = this.btnback;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(0, 0);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Parent = this.btnback;
            this.btnback.Size = new System.Drawing.Size(50, 50);
            this.btnback.TabIndex = 4;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(881, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(148, 109);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 21;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnbill
            // 
            this.btnbill.BackColor = System.Drawing.Color.Transparent;
            this.btnbill.BorderRadius = 9;
            this.btnbill.BorderThickness = 2;
            this.btnbill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnbill.CheckedState.Parent = this.btnbill;
            this.btnbill.CustomImages.Parent = this.btnbill;
            this.btnbill.FillColor = System.Drawing.Color.Transparent;
            this.btnbill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.ForeColor = System.Drawing.Color.Black;
            this.btnbill.HoverState.Parent = this.btnbill;
            this.btnbill.Location = new System.Drawing.Point(403, 533);
            this.btnbill.Name = "btnbill";
            this.btnbill.ShadowDecoration.Parent = this.btnbill;
            this.btnbill.Size = new System.Drawing.Size(168, 45);
            this.btnbill.TabIndex = 22;
            this.btnbill.Text = "Xem Hóa Đơn";
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // listrentperson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(212)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1030, 616);
            this.Controls.Add(this.btnbill);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.dgvlistperson);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listrentperson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listrentperson";
            this.Load += new System.EventHandler(this.listrentperson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnfind;
        private Guna.UI2.WinForms.Guna2DataGridView dgvlistperson;
        private Guna.UI2.WinForms.Guna2TextBox txtfind;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnbill;
    }
}