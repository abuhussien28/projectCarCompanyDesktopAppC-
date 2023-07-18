
namespace project_car_company
{
    partial class mainscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainscreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDNEWEMPLOYEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWEMPLOYEEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHEMPLOYEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datacustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplydataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletegroupBox4 = new System.Windows.Forms.GroupBox();
            this.button2_clear = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.deletegroupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWEMPLOYEEToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.carToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aDDNEWEMPLOYEEToolStripMenuItem
            // 
            this.aDDNEWEMPLOYEEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWEMPLOYEEToolStripMenuItem1,
            this.uPDATEToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.sEARCHEMPLOYEEToolStripMenuItem});
            this.aDDNEWEMPLOYEEToolStripMenuItem.Name = "aDDNEWEMPLOYEEToolStripMenuItem";
            this.aDDNEWEMPLOYEEToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.aDDNEWEMPLOYEEToolStripMenuItem.Text = "Employee";
            this.aDDNEWEMPLOYEEToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWEMPLOYEEToolStripMenuItem_Click);
            // 
            // aDDNEWEMPLOYEEToolStripMenuItem1
            // 
            this.aDDNEWEMPLOYEEToolStripMenuItem1.Name = "aDDNEWEMPLOYEEToolStripMenuItem1";
            this.aDDNEWEMPLOYEEToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.aDDNEWEMPLOYEEToolStripMenuItem1.Text = "ADD NEW EMPLOYEE";
            this.aDDNEWEMPLOYEEToolStripMenuItem1.Click += new System.EventHandler(this.aDDNEWEMPLOYEEToolStripMenuItem1_Click);
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            this.uPDATEToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // sEARCHEMPLOYEEToolStripMenuItem
            // 
            this.sEARCHEMPLOYEEToolStripMenuItem.Name = "sEARCHEMPLOYEEToolStripMenuItem";
            this.sEARCHEMPLOYEEToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sEARCHEMPLOYEEToolStripMenuItem.Text = "SEARCH EMPLOYEE";
            this.sEARCHEMPLOYEEToolStripMenuItem.Click += new System.EventHandler(this.sEARCHEMPLOYEEToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datacustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // datacustomerToolStripMenuItem
            // 
            this.datacustomerToolStripMenuItem.Name = "datacustomerToolStripMenuItem";
            this.datacustomerToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.datacustomerToolStripMenuItem.Text = "Data_customer";
            this.datacustomerToolStripMenuItem.Click += new System.EventHandler(this.datacustomerToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.carToolStripMenuItem.Text = "car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplydataToolStripMenuItem});
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // supplydataToolStripMenuItem
            // 
            this.supplydataToolStripMenuItem.Name = "supplydataToolStripMenuItem";
            this.supplydataToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.supplydataToolStripMenuItem.Text = "supply_data";
            this.supplydataToolStripMenuItem.Click += new System.EventHandler(this.supplydataToolStripMenuItem_Click);
            // 
            // deletegroupBox4
            // 
            this.deletegroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.deletegroupBox4.Controls.Add(this.button2_clear);
            this.deletegroupBox4.Controls.Add(this.comboBox4);
            this.deletegroupBox4.Controls.Add(this.label7);
            this.deletegroupBox4.Location = new System.Drawing.Point(363, 52);
            this.deletegroupBox4.Name = "deletegroupBox4";
            this.deletegroupBox4.Size = new System.Drawing.Size(712, 128);
            this.deletegroupBox4.TabIndex = 78;
            this.deletegroupBox4.TabStop = false;
            this.deletegroupBox4.Text = "Delete";
            this.deletegroupBox4.Visible = false;
            this.deletegroupBox4.Enter += new System.EventHandler(this.phonegroupBox4_Enter);
            // 
            // button2_clear
            // 
            this.button2_clear.BackColor = System.Drawing.Color.Transparent;
            this.button2_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2_clear.BackgroundImage")));
            this.button2_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_clear.Location = new System.Drawing.Point(519, 26);
            this.button2_clear.Name = "button2_clear";
            this.button2_clear.Size = new System.Drawing.Size(100, 91);
            this.button2_clear.TabIndex = 79;
            this.button2_clear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2_clear.UseVisualStyleBackColor = false;
            this.button2_clear.Click += new System.EventHandler(this.button2_clear_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(265, 52);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(235, 28);
            this.comboBox4.TabIndex = 77;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(114, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 31);
            this.label7.TabIndex = 74;
            this.label7.Text = "Frist_name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(363, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 399);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee data";
            this.groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(465, 28);
            this.comboBox1.TabIndex = 82;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 235);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn.BackgroundImage")));
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(630, 16);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 91);
            this.search_btn.TabIndex = 79;
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 74;
            this.label1.Text = "search";
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deletegroupBox4);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainscreen";
            this.Text = "mainscreen";
            this.Load += new System.EventHandler(this.mainscreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.deletegroupBox4.ResumeLayout(false);
            this.deletegroupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWEMPLOYEEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWEMPLOYEEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHEMPLOYEEToolStripMenuItem;
        private System.Windows.Forms.GroupBox deletegroupBox4;
        private System.Windows.Forms.Button button2_clear;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datacustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplydataToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}