
namespace project_car_company
{
    partial class delete_and_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_and_view));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewstatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.deletegroupBox2 = new System.Windows.Forms.GroupBox();
            this.button4_clear = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_serach = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.deletegroupBox2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_serach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewstatusToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // viewstatusToolStripMenuItem
            // 
            this.viewstatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soldToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.preiumToolStripMenuItem});
            this.viewstatusToolStripMenuItem.Name = "viewstatusToolStripMenuItem";
            this.viewstatusToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.viewstatusToolStripMenuItem.Text = "view_status";
            // 
            // soldToolStripMenuItem
            // 
            this.soldToolStripMenuItem.Name = "soldToolStripMenuItem";
            this.soldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.soldToolStripMenuItem.Text = "sold";
            this.soldToolStripMenuItem.Click += new System.EventHandler(this.soldToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rentToolStripMenuItem.Text = "rent";
            this.rentToolStripMenuItem.Click += new System.EventHandler(this.rentToolStripMenuItem_Click);
            // 
            // preiumToolStripMenuItem
            // 
            this.preiumToolStripMenuItem.Name = "preiumToolStripMenuItem";
            this.preiumToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.preiumToolStripMenuItem.Text = "premium";
            this.preiumToolStripMenuItem.Click += new System.EventHandler(this.preiumToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "customer_data";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Location = new System.Drawing.Point(6, 43);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.RowHeadersWidth = 51;
            this.dataGridView_data.RowTemplate.Height = 29;
            this.dataGridView_data.Size = new System.Drawing.Size(568, 340);
            this.dataGridView_data.TabIndex = 0;
            // 
            // deletegroupBox2
            // 
            this.deletegroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.deletegroupBox2.Controls.Add(this.button4_clear);
            this.deletegroupBox2.Controls.Add(this.comboBox2);
            this.deletegroupBox2.Controls.Add(this.label3);
            this.deletegroupBox2.Location = new System.Drawing.Point(18, 453);
            this.deletegroupBox2.Name = "deletegroupBox2";
            this.deletegroupBox2.Size = new System.Drawing.Size(568, 128);
            this.deletegroupBox2.TabIndex = 80;
            this.deletegroupBox2.TabStop = false;
            this.deletegroupBox2.Text = "Delete";
            this.deletegroupBox2.Visible = false;
            // 
            // button4_clear
            // 
            this.button4_clear.BackColor = System.Drawing.Color.Transparent;
            this.button4_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4_clear.BackgroundImage")));
            this.button4_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4_clear.Location = new System.Drawing.Point(421, 15);
            this.button4_clear.Name = "button4_clear";
            this.button4_clear.Size = new System.Drawing.Size(100, 94);
            this.button4_clear.TabIndex = 79;
            this.button4_clear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4_clear.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(235, 28);
            this.comboBox2.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 74;
            this.label3.Text = "Frist_name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dataGridView_serach);
            this.groupBox2.Controls.Add(this.search_btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(607, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 399);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "customer search data";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(437, 28);
            this.comboBox1.TabIndex = 82;
            // 
            // dataGridView_serach
            // 
            this.dataGridView_serach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_serach.Location = new System.Drawing.Point(19, 113);
            this.dataGridView_serach.Name = "dataGridView_serach";
            this.dataGridView_serach.RowHeadersWidth = 51;
            this.dataGridView_serach.RowTemplate.Height = 29;
            this.dataGridView_serach.Size = new System.Drawing.Size(744, 235);
            this.dataGridView_serach.TabIndex = 81;
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
            // delete_and_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 895);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deletegroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "delete_and_view";
            this.Text = "delete_and_view";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.deletegroupBox2.ResumeLayout(false);
            this.deletegroupBox2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_serach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewstatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.GroupBox deletegroupBox2;
        private System.Windows.Forms.Button button4_clear;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_serach;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}