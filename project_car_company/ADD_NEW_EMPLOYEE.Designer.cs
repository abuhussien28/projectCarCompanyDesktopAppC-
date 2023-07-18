
namespace project_car_company
{
    partial class ADD_NEW_EMPLOYEE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_NEW_EMPLOYEE));
            this.view = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CV_label = new System.Windows.Forms.Label();
            this.phone_two_tb = new System.Windows.Forms.TextBox();
            this.phone_two_label = new System.Windows.Forms.Label();
            this.phone_one_tb = new System.Windows.Forms.TextBox();
            this.phone_one_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.d_b_label = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.National_ID_label = new System.Windows.Forms.Label();
            this.last_tb = new System.Windows.Forms.TextBox();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.fr_tb = new System.Windows.Forms.TextBox();
            this.Frist_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.Location = new System.Drawing.Point(145, 418);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(39, 20);
            this.view.TabIndex = 49;
            this.view.Text = "view";
            this.view.Visible = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.Title = "open";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "open";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBox1.Location = new System.Drawing.Point(490, 433);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 28);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(649, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 91);
            this.button1.TabIndex = 47;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.Location = new System.Drawing.Point(490, 682);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 91);
            this.login_btn.TabIndex = 46;
            this.login_btn.Text = "ADD";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 339);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 27);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(824, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 459);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CV_label
            // 
            this.CV_label.AutoSize = true;
            this.CV_label.BackColor = System.Drawing.Color.Transparent;
            this.CV_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CV_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CV_label.Location = new System.Drawing.Point(786, 152);
            this.CV_label.Name = "CV_label";
            this.CV_label.Size = new System.Drawing.Size(140, 31);
            this.CV_label.TabIndex = 43;
            this.CV_label.Text = "import CV *";
            this.CV_label.Click += new System.EventHandler(this.CV_label_Click);
            // 
            // phone_two_tb
            // 
            this.phone_two_tb.Location = new System.Drawing.Point(490, 552);
            this.phone_two_tb.Multiline = true;
            this.phone_two_tb.Name = "phone_two_tb";
            this.phone_two_tb.Size = new System.Drawing.Size(235, 34);
            this.phone_two_tb.TabIndex = 42;
            this.phone_two_tb.TextChanged += new System.EventHandler(this.phone_two_tb_TextChanged);
            // 
            // phone_two_label
            // 
            this.phone_two_label.AutoSize = true;
            this.phone_two_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_two_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phone_two_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_two_label.Location = new System.Drawing.Point(327, 552);
            this.phone_two_label.Name = "phone_two_label";
            this.phone_two_label.Size = new System.Drawing.Size(133, 31);
            this.phone_two_label.TabIndex = 41;
            this.phone_two_label.Text = "phone_two";
            this.phone_two_label.Click += new System.EventHandler(this.phone_two_label_Click);
            // 
            // phone_one_tb
            // 
            this.phone_one_tb.Location = new System.Drawing.Point(490, 494);
            this.phone_one_tb.Multiline = true;
            this.phone_one_tb.Name = "phone_one_tb";
            this.phone_one_tb.Size = new System.Drawing.Size(235, 34);
            this.phone_one_tb.TabIndex = 40;
            this.phone_one_tb.TextChanged += new System.EventHandler(this.phone_one_tb_TextChanged);
            // 
            // phone_one_label
            // 
            this.phone_one_label.AutoSize = true;
            this.phone_one_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_one_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phone_one_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_one_label.Location = new System.Drawing.Point(327, 497);
            this.phone_one_label.Name = "phone_one_label";
            this.phone_one_label.Size = new System.Drawing.Size(132, 31);
            this.phone_one_label.TabIndex = 39;
            this.phone_one_label.Text = "phone_one";
            this.phone_one_label.Click += new System.EventHandler(this.phone_one_label_Click);
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.Color.Transparent;
            this.gender_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gender_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gender_label.Location = new System.Drawing.Point(327, 438);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(91, 31);
            this.gender_label.TabIndex = 38;
            this.gender_label.Text = "Gender";
            this.gender_label.Click += new System.EventHandler(this.gender_label_Click);
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(490, 377);
            this.email_tb.Multiline = true;
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(235, 34);
            this.email_tb.TabIndex = 37;
            this.email_tb.TextChanged += new System.EventHandler(this.email_tb_TextChanged);
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.BackColor = System.Drawing.Color.Transparent;
            this.Email_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email_label.Location = new System.Drawing.Point(331, 380);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(73, 31);
            this.Email_label.TabIndex = 36;
            this.Email_label.Text = "Email";
            this.Email_label.Click += new System.EventHandler(this.Email_label_Click);
            // 
            // d_b_label
            // 
            this.d_b_label.AutoSize = true;
            this.d_b_label.BackColor = System.Drawing.Color.Transparent;
            this.d_b_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d_b_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.d_b_label.Location = new System.Drawing.Point(327, 339);
            this.d_b_label.Name = "d_b_label";
            this.d_b_label.Size = new System.Drawing.Size(120, 31);
            this.d_b_label.TabIndex = 35;
            this.d_b_label.Text = "brith date";
            this.d_b_label.Click += new System.EventHandler(this.d_b_label_Click);
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(490, 283);
            this.id_tb.Multiline = true;
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(235, 34);
            this.id_tb.TabIndex = 34;
            this.id_tb.TextChanged += new System.EventHandler(this.id_tb_TextChanged);
            // 
            // National_ID_label
            // 
            this.National_ID_label.AutoSize = true;
            this.National_ID_label.BackColor = System.Drawing.Color.Transparent;
            this.National_ID_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.National_ID_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.National_ID_label.Location = new System.Drawing.Point(327, 277);
            this.National_ID_label.Name = "National_ID_label";
            this.National_ID_label.Size = new System.Drawing.Size(137, 31);
            this.National_ID_label.TabIndex = 33;
            this.National_ID_label.Text = "National ID";
            this.National_ID_label.Click += new System.EventHandler(this.National_ID_label_Click);
            // 
            // last_tb
            // 
            this.last_tb.Location = new System.Drawing.Point(490, 222);
            this.last_tb.Multiline = true;
            this.last_tb.Name = "last_tb";
            this.last_tb.Size = new System.Drawing.Size(235, 34);
            this.last_tb.TabIndex = 32;
            this.last_tb.TextChanged += new System.EventHandler(this.last_tb_TextChanged);
            // 
            // Last_name_label
            // 
            this.Last_name_label.AutoSize = true;
            this.Last_name_label.BackColor = System.Drawing.Color.Transparent;
            this.Last_name_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Last_name_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Last_name_label.Location = new System.Drawing.Point(331, 222);
            this.Last_name_label.Name = "Last_name_label";
            this.Last_name_label.Size = new System.Drawing.Size(126, 31);
            this.Last_name_label.TabIndex = 31;
            this.Last_name_label.Text = "Last_name";
            this.Last_name_label.Click += new System.EventHandler(this.Last_name_label_Click);
            // 
            // fr_tb
            // 
            this.fr_tb.Location = new System.Drawing.Point(490, 152);
            this.fr_tb.Multiline = true;
            this.fr_tb.Name = "fr_tb";
            this.fr_tb.Size = new System.Drawing.Size(235, 34);
            this.fr_tb.TabIndex = 30;
            this.fr_tb.TextChanged += new System.EventHandler(this.fr_tb_TextChanged);
            // 
            // Frist_name_label
            // 
            this.Frist_name_label.AutoSize = true;
            this.Frist_name_label.BackColor = System.Drawing.Color.Transparent;
            this.Frist_name_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Frist_name_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Frist_name_label.Location = new System.Drawing.Point(327, 152);
            this.Frist_name_label.Name = "Frist_name_label";
            this.Frist_name_label.Size = new System.Drawing.Size(130, 31);
            this.Frist_name_label.TabIndex = 29;
            this.Frist_name_label.Text = "Frist_name";
            this.Frist_name_label.Click += new System.EventHandler(this.Frist_name_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "choose picture*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(78, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ADD_NEW_EMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1263, 853);
            this.Controls.Add(this.view);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CV_label);
            this.Controls.Add(this.phone_two_tb);
            this.Controls.Add(this.phone_two_label);
            this.Controls.Add(this.phone_one_tb);
            this.Controls.Add(this.phone_one_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.d_b_label);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.National_ID_label);
            this.Controls.Add(this.last_tb);
            this.Controls.Add(this.Last_name_label);
            this.Controls.Add(this.fr_tb);
            this.Controls.Add(this.Frist_name_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ADD_NEW_EMPLOYEE";
            this.Text = "ADD_NEW_EMPLOYEE";
            this.Load += new System.EventHandler(this.ADD_NEW_EMPLOYEE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label view;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        public System.Windows.Forms.OpenFileDialog openFileDialog2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CV_label;
        private System.Windows.Forms.TextBox phone_two_tb;
        private System.Windows.Forms.Label phone_two_label;
        private System.Windows.Forms.TextBox phone_one_tb;
        private System.Windows.Forms.Label phone_one_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label d_b_label;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label National_ID_label;
        private System.Windows.Forms.TextBox last_tb;
        private System.Windows.Forms.Label Last_name_label;
        private System.Windows.Forms.TextBox fr_tb;
        private System.Windows.Forms.Label Frist_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}