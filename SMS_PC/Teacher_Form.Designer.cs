namespace SMS_PC
{
    partial class Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.teacherJoinDateTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.teacherAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.teacherEmail = new MaterialSkin.Controls.MaterialLabel();
            this.teacherPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.teacherDesignation = new MaterialSkin.Controls.MaterialLabel();
            this.teacherQualification = new MaterialSkin.Controls.MaterialLabel();
            this.teacherFullName = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teacherPictureBox = new System.Windows.Forms.PictureBox();
            this.teacherWelcomeText = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 189);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(781, 34);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 223);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(781, 312);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.teacherJoinDateTextBox);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.teacherAddressTextBox1);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.teacherEmail);
            this.tabPage1.Controls.Add(this.teacherPhoneNumber);
            this.tabPage1.Controls.Add(this.teacherDesignation);
            this.tabPage1.Controls.Add(this.teacherQualification);
            this.tabPage1.Controls.Add(this.teacherFullName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // teacherJoinDateTextBox
            // 
            this.teacherJoinDateTextBox.Location = new System.Drawing.Point(433, 133);
            this.teacherJoinDateTextBox.Multiline = true;
            this.teacherJoinDateTextBox.Name = "teacherJoinDateTextBox";
            this.teacherJoinDateTextBox.Size = new System.Drawing.Size(175, 46);
            this.teacherJoinDateTextBox.TabIndex = 9;
            this.teacherJoinDateTextBox.Text = "2013-01-01";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(427, 110);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Join Date";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(429, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Address";
            // 
            // teacherAddressTextBox1
            // 
            this.teacherAddressTextBox1.Location = new System.Drawing.Point(433, 45);
            this.teacherAddressTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.teacherAddressTextBox1.Multiline = true;
            this.teacherAddressTextBox1.Name = "teacherAddressTextBox1";
            this.teacherAddressTextBox1.Size = new System.Drawing.Size(186, 52);
            this.teacherAddressTextBox1.TabIndex = 6;
            this.teacherAddressTextBox1.Text = "2nd Phase, Sonadanga Residential Area, Khulna";
            this.teacherAddressTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(323, 22);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 157);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // teacherEmail
            // 
            this.teacherEmail.AutoSize = true;
            this.teacherEmail.Depth = 0;
            this.teacherEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.teacherEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teacherEmail.Location = new System.Drawing.Point(45, 100);
            this.teacherEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherEmail.Name = "teacherEmail";
            this.teacherEmail.Size = new System.Drawing.Size(182, 19);
            this.teacherEmail.TabIndex = 4;
            this.teacherEmail.Text = "cse.inzamam@gmail.com";
            // 
            // teacherPhoneNumber
            // 
            this.teacherPhoneNumber.AutoSize = true;
            this.teacherPhoneNumber.Depth = 0;
            this.teacherPhoneNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.teacherPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teacherPhoneNumber.Location = new System.Drawing.Point(45, 124);
            this.teacherPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherPhoneNumber.Name = "teacherPhoneNumber";
            this.teacherPhoneNumber.Size = new System.Drawing.Size(97, 19);
            this.teacherPhoneNumber.TabIndex = 3;
            this.teacherPhoneNumber.Text = "01725986547";
            // 
            // teacherDesignation
            // 
            this.teacherDesignation.AutoSize = true;
            this.teacherDesignation.Depth = 0;
            this.teacherDesignation.Font = new System.Drawing.Font("Roboto", 11F);
            this.teacherDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teacherDesignation.Location = new System.Drawing.Point(45, 78);
            this.teacherDesignation.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherDesignation.Name = "teacherDesignation";
            this.teacherDesignation.Size = new System.Drawing.Size(115, 19);
            this.teacherDesignation.TabIndex = 2;
            this.teacherDesignation.Text = "Dept. Head CSE";
            // 
            // teacherQualification
            // 
            this.teacherQualification.AutoSize = true;
            this.teacherQualification.Depth = 0;
            this.teacherQualification.Font = new System.Drawing.Font("Roboto", 11F);
            this.teacherQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teacherQualification.Location = new System.Drawing.Point(45, 59);
            this.teacherQualification.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherQualification.Name = "teacherQualification";
            this.teacherQualification.Size = new System.Drawing.Size(36, 19);
            this.teacherQualification.TabIndex = 1;
            this.teacherQualification.Text = "PhD";
            // 
            // teacherFullName
            // 
            this.teacherFullName.AutoSize = true;
            this.teacherFullName.Depth = 0;
            this.teacherFullName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teacherFullName.Location = new System.Drawing.Point(46, 36);
            this.teacherFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherFullName.Name = "teacherFullName";
            this.teacherFullName.Size = new System.Drawing.Size(129, 18);
            this.teacherFullName.TabIndex = 0;
            this.teacherFullName.Text = "Inzamam Hossain";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // teacherPictureBox
            // 
            this.teacherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("teacherPictureBox.Image")));
            this.teacherPictureBox.Location = new System.Drawing.Point(23, 85);
            this.teacherPictureBox.Name = "teacherPictureBox";
            this.teacherPictureBox.Size = new System.Drawing.Size(100, 90);
            this.teacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherPictureBox.TabIndex = 3;
            this.teacherPictureBox.TabStop = false;
            // 
            // teacherWelcomeText
            // 
            this.teacherWelcomeText.AutoSize = true;
            this.teacherWelcomeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.teacherWelcomeText.Depth = 0;
            this.teacherWelcomeText.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.teacherWelcomeText.ForeColor = System.Drawing.Color.White;
            this.teacherWelcomeText.Location = new System.Drawing.Point(149, 111);
            this.teacherWelcomeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherWelcomeText.Name = "teacherWelcomeText";
            this.teacherWelcomeText.Size = new System.Drawing.Size(294, 33);
            this.teacherWelcomeText.TabIndex = 4;
            this.teacherWelcomeText.Text = "Welcome, Inzamam Sir";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(692, 122);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Logout";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 532);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.teacherWelcomeText);
            this.Controls.Add(this.teacherPictureBox);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher_Form";
            this.Text = "Teacher Area";
            this.Load += new System.EventHandler(this.Teacher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox teacherAddressTextBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel teacherEmail;
        private MaterialSkin.Controls.MaterialLabel teacherPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel teacherDesignation;
        private MaterialSkin.Controls.MaterialLabel teacherQualification;
        private MaterialSkin.Controls.MaterialLabel teacherFullName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox teacherPictureBox;
        private MaterialSkin.Controls.MaterialLabel teacherWelcomeText;
        private System.Windows.Forms.TextBox teacherJoinDateTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}