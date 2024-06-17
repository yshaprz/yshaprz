namespace bookingform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            roundedPanel1 = new RoundedPanel();
            CancelButton = new RoundedButtonVer2();
            ConfirmButton = new RoundedButtonVer2();
            textBox2 = new TextBox();
            label8 = new Label();
            TypePayment = new CustomComboBox();
            label7 = new Label();
            AvailableRooms = new CustomComboBox();
            label6 = new Label();
            BookingStatus = new CustomComboBox();
            label5 = new Label();
            CheckOutDate = new CustomDatePicker_();
            label4 = new Label();
            CheckInDate = new CustomDatePicker_();
            label3 = new Label();
            AddNewGuestButton = new RoundedButtonVer2();
            SelectExistingGuestButton = new RoundedButtonVer2();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 78);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(CancelButton);
            roundedPanel1.Controls.Add(ConfirmButton);
            roundedPanel1.Controls.Add(textBox2);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(TypePayment);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(AvailableRooms);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(BookingStatus);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(CheckOutDate);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(CheckInDate);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(AddNewGuestButton);
            roundedPanel1.Controls.Add(SelectExistingGuestButton);
            roundedPanel1.Controls.Add(textBox1);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 30;
            roundedPanel1.Size = new Size(1325, 702);
            roundedPanel1.TabIndex = 1;
            roundedPanel1.Thickness = 5F;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.LightGray;
            CancelButton.BackgroundColor = Color.LightGray;
            CancelButton.BorderColor = Color.RoyalBlue;
            CancelButton.BorderRadius = 10;
            CancelButton.BorderSize = 0;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(976, 575);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(136, 38);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "CANCEL";
            CancelButton.TextColor = Color.Black;
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.RoyalBlue;
            ConfirmButton.BackgroundColor = Color.RoyalBlue;
            ConfirmButton.BorderColor = Color.RoyalBlue;
            ConfirmButton.BorderRadius = 10;
            ConfirmButton.BorderSize = 0;
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(834, 575);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(136, 38);
            ConfirmButton.TabIndex = 17;
            ConfirmButton.Text = " CONFIRM";
            ConfirmButton.TextColor = Color.White;
            ConfirmButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderColor = Color.FromArgb(0, 7, 45);
            textBox2.BorderFocusColor = Color.FromArgb(0, 7, 45);
            textBox2.BorderRadius = 10;
            textBox2.BorderSize = 2;
            textBox2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(220, 442);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = false;
            textBox2.Name = "textBox2";
            textBox2.Padding = new Padding(10, 7, 10, 7);
            textBox2.PasswordChar = false;
            textBox2.PlaceholderColor = Color.DarkGray;
            textBox2.PlaceholderText = "₱##, ###.##";
            textBox2.Size = new Size(309, 33);
            textBox2.TabIndex = 16;
            textBox2.Texts = "";
            textBox2.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(61, 450);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 15;
            label8.Text = "Total Amount:";
            label8.Click += label8_Click;
            // 
            // TypePayment
            // 
            TypePayment.BackColor = Color.White;
            TypePayment.BorderColor = Color.FromArgb(0, 7, 45);
            TypePayment.BorderSize = 2;
            TypePayment.DropDownStyle = ComboBoxStyle.DropDown;
            TypePayment.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypePayment.ForeColor = Color.DimGray;
            TypePayment.IconColor = Color.FromArgb(0, 7, 45);
            TypePayment.Items.AddRange(new object[] { "Cash", "Credit Card", "Digital Wallet (GCASH, Paymaya, etc.)" });
            TypePayment.ListBackColor = Color.FromArgb(230, 228, 245);
            TypePayment.ListTextColor = Color.DimGray;
            TypePayment.Location = new Point(260, 380);
            TypePayment.MinimumSize = new Size(200, 30);
            TypePayment.Name = "TypePayment";
            TypePayment.Padding = new Padding(2);
            TypePayment.Size = new Size(269, 30);
            TypePayment.TabIndex = 14;
            TypePayment.Texts = "Type of Payment";
            TypePayment.OnSelectedIndexChanged += TypePayment_OnSelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 385);
            label7.Name = "label7";
            label7.Size = new Size(192, 25);
            label7.TabIndex = 13;
            label7.Text = "Payment Method:";
            // 
            // AvailableRooms
            // 
            AvailableRooms.BackColor = Color.White;
            AvailableRooms.BorderColor = Color.FromArgb(0, 7, 45);
            AvailableRooms.BorderSize = 2;
            AvailableRooms.DropDownStyle = ComboBoxStyle.DropDown;
            AvailableRooms.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableRooms.ForeColor = Color.DimGray;
            AvailableRooms.IconColor = Color.FromArgb(0, 7, 45);
            AvailableRooms.Items.AddRange(new object[] { "available rooms" });
            AvailableRooms.ListBackColor = Color.FromArgb(230, 228, 245);
            AvailableRooms.ListTextColor = Color.DimGray;
            AvailableRooms.Location = new Point(153, 315);
            AvailableRooms.MinimumSize = new Size(200, 30);
            AvailableRooms.Name = "AvailableRooms";
            AvailableRooms.Padding = new Padding(2);
            AvailableRooms.Size = new Size(231, 30);
            AvailableRooms.TabIndex = 12;
            AvailableRooms.Texts = "Available Rooms";
            AvailableRooms.OnSelectedIndexChanged += AvailableRooms_OnSelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 320);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 11;
            label6.Text = "Rooms:";
            // 
            // BookingStatus
            // 
            BookingStatus.BackColor = Color.White;
            BookingStatus.BorderColor = Color.FromArgb(0, 7, 45);
            BookingStatus.BorderSize = 2;
            BookingStatus.DropDownStyle = ComboBoxStyle.DropDown;
            BookingStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookingStatus.ForeColor = Color.DimGray;
            BookingStatus.IconColor = Color.FromArgb(0, 7, 45);
            BookingStatus.Items.AddRange(new object[] { "Confirmed", "Pending", "Completed", "Cancelled" });
            BookingStatus.ListBackColor = Color.FromArgb(230, 228, 245);
            BookingStatus.ListTextColor = Color.DimGray;
            BookingStatus.Location = new Point(153, 252);
            BookingStatus.MinimumSize = new Size(200, 30);
            BookingStatus.Name = "BookingStatus";
            BookingStatus.Padding = new Padding(2);
            BookingStatus.Size = new Size(231, 30);
            BookingStatus.TabIndex = 10;
            BookingStatus.Texts = "Booking Status";
            BookingStatus.OnSelectedIndexChanged += BookingStatus_OnSelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 257);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 9;
            label5.Text = "Status:";
            label5.Click += label5_Click;
            // 
            // CheckOutDate
            // 
            CheckOutDate.BorderColor = Color.FromArgb(0, 7, 45);
            CheckOutDate.BorderSize = 0;
            CheckOutDate.Checked = false;
            CheckOutDate.CustomFormat = "";
            CheckOutDate.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            CheckOutDate.ImeMode = ImeMode.On;
            CheckOutDate.Location = new Point(739, 190);
            CheckOutDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            CheckOutDate.MinimumSize = new Size(0, 35);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.RightToLeft = RightToLeft.No;
            CheckOutDate.Size = new Size(251, 35);
            CheckOutDate.SkinColor = Color.White;
            CheckOutDate.TabIndex = 8;
            CheckOutDate.TextColor = Color.FromArgb(0, 7, 45);
            CheckOutDate.ValueChanged += customDatePicker_1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(553, 195);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 7;
            label4.Text = "Check - out Date:";
            // 
            // CheckInDate
            // 
            CheckInDate.BorderColor = Color.FromArgb(0, 7, 45);
            CheckInDate.BorderSize = 0;
            CheckInDate.Checked = false;
            CheckInDate.CustomFormat = "";
            CheckInDate.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            CheckInDate.ImeMode = ImeMode.On;
            CheckInDate.Location = new Point(231, 190);
            CheckInDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            CheckInDate.MinimumSize = new Size(0, 35);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.RightToLeft = RightToLeft.No;
            CheckInDate.Size = new Size(261, 35);
            CheckInDate.SkinColor = Color.White;
            CheckInDate.TabIndex = 6;
            CheckInDate.TextColor = Color.FromArgb(0, 7, 45);
            CheckInDate.ValueChanged += CheckInDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 195);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 5;
            label3.Text = "Check - in Date:";
            label3.Click += label3_Click;
            // 
            // AddNewGuestButton
            // 
            AddNewGuestButton.BackColor = Color.RoyalBlue;
            AddNewGuestButton.BackgroundColor = Color.RoyalBlue;
            AddNewGuestButton.BorderColor = Color.RoyalBlue;
            AddNewGuestButton.BorderRadius = 10;
            AddNewGuestButton.BorderSize = 0;
            AddNewGuestButton.FlatAppearance.BorderSize = 0;
            AddNewGuestButton.FlatStyle = FlatStyle.Flat;
            AddNewGuestButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewGuestButton.ForeColor = Color.White;
            AddNewGuestButton.Location = new Point(635, 123);
            AddNewGuestButton.Name = "AddNewGuestButton";
            AddNewGuestButton.Size = new Size(127, 32);
            AddNewGuestButton.TabIndex = 4;
            AddNewGuestButton.Text = "Add New Guest ";
            AddNewGuestButton.TextColor = Color.White;
            AddNewGuestButton.UseVisualStyleBackColor = false;
            // 
            // SelectExistingGuestButton
            // 
            SelectExistingGuestButton.BackColor = Color.RoyalBlue;
            SelectExistingGuestButton.BackgroundColor = Color.RoyalBlue;
            SelectExistingGuestButton.BorderColor = Color.RoyalBlue;
            SelectExistingGuestButton.BorderRadius = 10;
            SelectExistingGuestButton.BorderSize = 0;
            SelectExistingGuestButton.FlatAppearance.BorderSize = 0;
            SelectExistingGuestButton.FlatStyle = FlatStyle.Flat;
            SelectExistingGuestButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectExistingGuestButton.ForeColor = Color.White;
            SelectExistingGuestButton.Location = new Point(480, 123);
            SelectExistingGuestButton.Name = "SelectExistingGuestButton";
            SelectExistingGuestButton.Size = new Size(149, 32);
            SelectExistingGuestButton.TabIndex = 3;
            SelectExistingGuestButton.Text = " Select Exisiting Guest ";
            SelectExistingGuestButton.TextColor = Color.White;
            SelectExistingGuestButton.UseVisualStyleBackColor = false;
            SelectExistingGuestButton.Click += roundedButtonVer21_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderColor = Color.FromArgb(0, 7, 45);
            textBox1.BorderFocusColor = Color.FromArgb(0, 7, 45);
            textBox1.BorderRadius = 10;
            textBox1.BorderSize = 2;
            textBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(144, 123);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(10, 7, 10, 7);
            textBox1.PasswordChar = false;
            textBox1.PlaceholderColor = Color.DarkGray;
            textBox1.PlaceholderText = "";
            textBox1.Size = new Size(329, 33);
            textBox1.TabIndex = 2;
            textBox1.Texts = "";
            textBox1.UnderlinedStyle = false;
            textBox1.Load += textBox1_Load;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 131);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Guest:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 0;
            label1.Text = "Booking Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 7, 45);
            ClientSize = new Size(1325, 702);
            Controls.Add(roundedPanel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private RoundedPanel roundedPanel1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private RoundedButtonVer2 SelectExistingGuestButton;
        private Label label3;
        private RoundedButtonVer2 AddNewGuestButton;
        private CustomDatePicker_ CheckInDate;
        private CustomDatePicker_ CheckOutDate;
        private Label label4;
        private Label label5;
        private CustomComboBox BookingStatus;
        private Label label6;
        private CustomComboBox AvailableRooms;
        private Label label7;
        private Label label8;
        private CustomComboBox TypePayment;
        private TextBox textBox2;
        private RoundedButtonVer2 CancelButton;
        private RoundedButtonVer2 ConfirmButton;
    }
}
