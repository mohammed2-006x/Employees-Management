namespace Employees_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2001",
            "محمد طاهر",
            "0916216683",
            "19 سنة",
            "10 ساعة",
            "mohammedtaher@gmail.com",
            "M",
            "10000د.ل"}, 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "2002",
            "علي عكيكة",
            "0925478896",
            "20 سنة",
            "20 ساعة",
            "ali@ha.frs",
            "M",
            "500د.ل"}, 0);
            this.label1 = new System.Windows.Forms.Label();
            this.gbEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.mtxtSalary = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtTo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFrom = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblWorkingPeriod = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.btnColorBackGround = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckEmployees = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFontControl = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbEmployeeInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = " ادارة الموظفين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbEmployeeInfo
            // 
            this.gbEmployeeInfo.BackColor = System.Drawing.SystemColors.Window;
            this.gbEmployeeInfo.Controls.Add(this.mtxtSalary);
            this.gbEmployeeInfo.Controls.Add(this.label17);
            this.gbEmployeeInfo.Controls.Add(this.label16);
            this.gbEmployeeInfo.Controls.Add(this.dtpBirthDay);
            this.gbEmployeeInfo.Controls.Add(this.groupBox1);
            this.gbEmployeeInfo.Controls.Add(this.gbGender);
            this.gbEmployeeInfo.Controls.Add(this.txtEmail);
            this.gbEmployeeInfo.Controls.Add(this.txtPhone);
            this.gbEmployeeInfo.Controls.Add(this.btnAdd);
            this.gbEmployeeInfo.Controls.Add(this.txtFullName);
            this.gbEmployeeInfo.Controls.Add(this.label5);
            this.gbEmployeeInfo.Controls.Add(this.label4);
            this.gbEmployeeInfo.Controls.Add(this.label3);
            this.gbEmployeeInfo.Controls.Add(this.label2);
            this.gbEmployeeInfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbEmployeeInfo.Location = new System.Drawing.Point(597, 35);
            this.gbEmployeeInfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbEmployeeInfo.Name = "gbEmployeeInfo";
            this.gbEmployeeInfo.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbEmployeeInfo.Size = new System.Drawing.Size(729, 295);
            this.gbEmployeeInfo.TabIndex = 1;
            this.gbEmployeeInfo.TabStop = false;
            this.gbEmployeeInfo.Text = "بيانات الموظف";
            // 
            // mtxtSalary
            // 
            this.mtxtSalary.Location = new System.Drawing.Point(528, 251);
            this.mtxtSalary.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.mtxtSalary.Mask = "000999";
            this.mtxtSalary.Name = "mtxtSalary";
            this.mtxtSalary.Size = new System.Drawing.Size(61, 24);
            this.mtxtSalary.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(483, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 19);
            this.label17.TabIndex = 14;
            this.label17.Text = " د.ل";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(591, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = " الراتب :";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(348, 199);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthDay.RightToLeftLayout = true;
            this.dtpBirthDay.Size = new System.Drawing.Size(241, 30);
            this.dtpBirthDay.TabIndex = 3;
            this.dtpBirthDay.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtTo);
            this.groupBox1.Controls.Add(this.mtxtFrom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(36, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(255, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " الدوام";
            // 
            // mtxtTo
            // 
            this.mtxtTo.Location = new System.Drawing.Point(27, 27);
            this.mtxtTo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.mtxtTo.Mask = "00:00";
            this.mtxtTo.Name = "mtxtTo";
            this.mtxtTo.Size = new System.Drawing.Size(49, 24);
            this.mtxtTo.TabIndex = 1;
            this.mtxtTo.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFrom
            // 
            this.mtxtFrom.Location = new System.Drawing.Point(141, 27);
            this.mtxtFrom.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.mtxtFrom.Mask = "00:00";
            this.mtxtFrom.Name = "mtxtFrom";
            this.mtxtFrom.Size = new System.Drawing.Size(49, 24);
            this.mtxtFrom.TabIndex = 0;
            this.mtxtFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(81, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "إلى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(201, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = " من";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(36, 36);
            this.gbGender.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbGender.Size = new System.Drawing.Size(255, 79);
            this.gbGender.TabIndex = 5;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "الجنس";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.rbFemale.Location = new System.Drawing.Point(27, 27);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(65, 23);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = " انثى";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.rbMale.Location = new System.Drawing.Point(147, 27);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 23);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = " ذكر";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(348, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(348, 144);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.BackgroundImage = global::Employees_Management.Properties.Resources.add_Button;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.Location = new System.Drawing.Point(15, 225);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 55);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtFullName.Location = new System.Drawing.Point(348, 35);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(241, 27);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(591, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = " تاريخ الميلاد :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(591, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "البريد الالكتروني:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(591, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "رقم الهاتف :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(591, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم الكامل :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(394, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = " طريقة العرض :";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ايقونات صغيرة",
            "ايقونات كبيرة",
            "تفاصيل",
            "قائمة",
            "لوحات"});
            this.comboBox1.Location = new System.Drawing.Point(230, 350);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 27);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(276, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "المعرف :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(276, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = " الإيميل :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(276, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = " العمر :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(276, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = " الهاتف :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(276, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = " الاسم :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(276, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "مدة الدوام :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(276, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = " الجنس :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(15, 13);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblID.Size = new System.Drawing.Size(105, 19);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "UNDEFINED";
            // 
            // lblWorkingPeriod
            // 
            this.lblWorkingPeriod.AutoSize = true;
            this.lblWorkingPeriod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblWorkingPeriod.ForeColor = System.Drawing.Color.Blue;
            this.lblWorkingPeriod.Location = new System.Drawing.Point(15, 140);
            this.lblWorkingPeriod.Name = "lblWorkingPeriod";
            this.lblWorkingPeriod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWorkingPeriod.Size = new System.Drawing.Size(105, 19);
            this.lblWorkingPeriod.TabIndex = 23;
            this.lblWorkingPeriod.Text = "UNDEFINED";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.Blue;
            this.lblAge.Location = new System.Drawing.Point(15, 108);
            this.lblAge.Name = "lblAge";
            this.lblAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAge.Size = new System.Drawing.Size(105, 19);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "UNDEFINED";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.Blue;
            this.lblPhone.Location = new System.Drawing.Point(15, 77);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhone.Size = new System.Drawing.Size(105, 19);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "UNDEFINED";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(15, 43);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(105, 19);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "UNDEFINED";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.Blue;
            this.lblGender.Location = new System.Drawing.Point(15, 199);
            this.lblGender.Name = "lblGender";
            this.lblGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGender.Size = new System.Drawing.Size(105, 19);
            this.lblGender.TabIndex = 27;
            this.lblGender.Text = "UNDEFINED";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblEmail.Location = new System.Drawing.Point(15, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(105, 19);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "UNDEFINED";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.pbEmployee);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblWorkingPeriod);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(9, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 289);
            this.panel1.TabIndex = 29;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalary.ForeColor = System.Drawing.Color.Blue;
            this.lblSalary.Location = new System.Drawing.Point(15, 235);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSalary.Size = new System.Drawing.Size(105, 19);
            this.lblSalary.TabIndex = 30;
            this.lblSalary.Text = "UNDEFINED";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(276, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 19);
            this.label18.TabIndex = 29;
            this.label18.Text = " الراتب :";
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEmployee.Location = new System.Drawing.Point(381, 14);
            this.pbEmployee.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(191, 227);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 15;
            this.pbEmployee.TabStop = false;
            // 
            // btnColorBackGround
            // 
            this.btnColorBackGround.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.btnColorBackGround.Location = new System.Drawing.Point(23, 350);
            this.btnColorBackGround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColorBackGround.Name = "btnColorBackGround";
            this.btnColorBackGround.Size = new System.Drawing.Size(95, 27);
            this.btnColorBackGround.TabIndex = 32;
            this.btnColorBackGround.Tag = "1";
            this.btnColorBackGround.Text = "لون الخلفية";
            this.btnColorBackGround.UseVisualStyleBackColor = true;
            this.btnColorBackGround.Click += new System.EventHandler(this.btnColorBackGround_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Man.jpg");
            this.imageList1.Images.SetKeyName(1, "Woman.jpg");
            this.imageList1.Images.SetKeyName(2, "5794436045595151902_121.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Man.jpg");
            this.imageList2.Images.SetKeyName(1, "Woman.jpg");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "المعرف";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "الاسم كامل";
            this.columnHeader2.Width = 266;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "رقم الهاتف";
            this.columnHeader3.Width = 237;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "العمر";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "مدة الدوام";
            this.columnHeader5.Width = 144;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "الإيميل";
            this.columnHeader6.Width = 319;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "الجنس";
            this.columnHeader7.Width = 79;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(9, 381);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1317, 374);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "الراتب";
            this.columnHeader8.Width = 146;
            // 
            // btnCheckEmployees
            // 
            this.btnCheckEmployees.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnCheckEmployees.Location = new System.Drawing.Point(819, 328);
            this.btnCheckEmployees.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCheckEmployees.Name = "btnCheckEmployees";
            this.btnCheckEmployees.Size = new System.Drawing.Size(219, 49);
            this.btnCheckEmployees.TabIndex = 31;
            this.btnCheckEmployees.Tag = "1";
            this.btnCheckEmployees.Text = "تحديد العناصر";
            this.btnCheckEmployees.UseVisualStyleBackColor = true;
            this.btnCheckEmployees.Click += new System.EventHandler(this.btnCheckEmployees_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.Cyan;
            this.btnEditEmployee.BackgroundImage = global::Employees_Management.Properties.Resources.edit_user_removebg_preview;
            this.btnEditEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEditEmployee.FlatAppearance.BorderSize = 3;
            this.btnEditEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditEmployee.Location = new System.Drawing.Point(1071, 328);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(117, 49);
            this.btnEditEmployee.TabIndex = 14;
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemove.BackgroundImage = global::Employees_Management.Properties.Resources.Delete_button_removebg_preview__1_;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemove.FlatAppearance.BorderSize = 3;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(1209, 328);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 49);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btnFontControl
            // 
            this.btnFontControl.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.btnFontControl.Location = new System.Drawing.Point(124, 350);
            this.btnFontControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFontControl.Name = "btnFontControl";
            this.btnFontControl.Size = new System.Drawing.Size(95, 27);
            this.btnFontControl.TabIndex = 33;
            this.btnFontControl.Tag = "1";
            this.btnFontControl.Text = "شكل الخط";
            this.btnFontControl.UseVisualStyleBackColor = true;
            this.btnFontControl.Click += new System.EventHandler(this.btnFontControl_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1346, 767);
            this.Controls.Add(this.btnFontControl);
            this.Controls.Add(this.btnColorBackGround);
            this.Controls.Add(this.btnCheckEmployees);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbEmployeeInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برنامج إدارة الموظفين";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEmployeeInfo.ResumeLayout(false);
            this.gbEmployeeInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEmployeeInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtTo;
        private System.Windows.Forms.MaskedTextBox mtxtFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblWorkingPeriod;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnCheckEmployees;
        private System.Windows.Forms.MaskedTextBox mtxtSalary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnColorBackGround;
        private System.Windows.Forms.Button btnFontControl;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

