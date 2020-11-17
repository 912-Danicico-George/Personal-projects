namespace Dentist
{
    partial class Form3
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
            this.admin_menu = new System.Windows.Forms.GroupBox();
            this.current_Activity = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.activity_panel = new System.Windows.Forms.Panel();
            this.btnShowActivity = new System.Windows.Forms.Button();
            this.all_doctors = new System.Windows.Forms.GroupBox();
            this.doctors_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicoDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cico_DatabaseDataSet = new Dentist.Cico_DatabaseDataSet();
            this.back_again = new System.Windows.Forms.Button();
            this.new_doctor = new System.Windows.Forms.GroupBox();
            this.pass_char = new System.Windows.Forms.CheckBox();
            this.pass_check = new System.Windows.Forms.PictureBox();
            this.id_check = new System.Windows.Forms.PictureBox();
            this.user_check = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.register_now = new System.Windows.Forms.Button();
            this.id_medic = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.iddoctorlabel = new System.Windows.Forms.Label();
            this.show_doctors = new System.Windows.Forms.Button();
            this.register_doctor = new System.Windows.Forms.Button();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Dentist.Database1DataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.admin_menu.SuspendLayout();
            this.current_Activity.SuspendLayout();
            this.all_doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicoDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cico_DatabaseDataSet)).BeginInit();
            this.new_doctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_menu
            // 
            this.admin_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_menu.AutoSize = true;
            this.admin_menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_menu.Controls.Add(this.current_Activity);
            this.admin_menu.Controls.Add(this.btnShowActivity);
            this.admin_menu.Controls.Add(this.all_doctors);
            this.admin_menu.Controls.Add(this.new_doctor);
            this.admin_menu.Controls.Add(this.show_doctors);
            this.admin_menu.Controls.Add(this.register_doctor);
            this.admin_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_menu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.admin_menu.Location = new System.Drawing.Point(25, 42);
            this.admin_menu.Name = "admin_menu";
            this.admin_menu.Size = new System.Drawing.Size(1386, 789);
            this.admin_menu.TabIndex = 0;
            this.admin_menu.TabStop = false;
            this.admin_menu.Text = "Meniul administratorului";
            // 
            // current_Activity
            // 
            this.current_Activity.Controls.Add(this.btnBack);
            this.current_Activity.Controls.Add(this.activity_panel);
            this.current_Activity.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.current_Activity.Location = new System.Drawing.Point(411, 95);
            this.current_Activity.Name = "current_Activity";
            this.current_Activity.Size = new System.Drawing.Size(693, 547);
            this.current_Activity.TabIndex = 18;
            this.current_Activity.TabStop = false;
            this.current_Activity.Text = "Activitate curenta";
            this.current_Activity.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(522, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 56);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // activity_panel
            // 
            this.activity_panel.AutoScroll = true;
            this.activity_panel.AutoSize = true;
            this.activity_panel.Location = new System.Drawing.Point(24, 47);
            this.activity_panel.Name = "activity_panel";
            this.activity_panel.Size = new System.Drawing.Size(633, 434);
            this.activity_panel.TabIndex = 0;
            // 
            // btnShowActivity
            // 
            this.btnShowActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowActivity.Location = new System.Drawing.Point(81, 452);
            this.btnShowActivity.Name = "btnShowActivity";
            this.btnShowActivity.Size = new System.Drawing.Size(227, 105);
            this.btnShowActivity.TabIndex = 17;
            this.btnShowActivity.Text = "Urmareste activitate curentă";
            this.btnShowActivity.UseVisualStyleBackColor = true;
            this.btnShowActivity.Click += new System.EventHandler(this.btnShowActivity_Click);
            // 
            // all_doctors
            // 
            this.all_doctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.all_doctors.Controls.Add(this.doctors_table);
            this.all_doctors.Controls.Add(this.back_again);
            this.all_doctors.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.all_doctors.Location = new System.Drawing.Point(425, 110);
            this.all_doctors.Name = "all_doctors";
            this.all_doctors.Size = new System.Drawing.Size(695, 532);
            this.all_doctors.TabIndex = 16;
            this.all_doctors.TabStop = false;
            this.all_doctors.Text = "Doctori";
            this.all_doctors.Visible = false;
            this.all_doctors.Enter += new System.EventHandler(this.all_doctors_Enter);
            // 
            // doctors_table
            // 
            this.doctors_table.AllowDrop = true;
            this.doctors_table.AllowUserToAddRows = false;
            this.doctors_table.AllowUserToDeleteRows = false;
            this.doctors_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.doctors_table.AutoGenerateColumns = false;
            this.doctors_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctors_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.doctors_table.DataSource = this.cicoDatabaseDataSetBindingSource;
            this.doctors_table.Location = new System.Drawing.Point(74, 59);
            this.doctors_table.Name = "doctors_table";
            this.doctors_table.ReadOnly = true;
            this.doctors_table.RowHeadersWidth = 51;
            this.doctors_table.RowTemplate.Height = 24;
            this.doctors_table.Size = new System.Drawing.Size(602, 307);
            this.doctors_table.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_medic";
            this.Column1.HeaderText = "Id medic";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "last_name";
            this.Column2.HeaderText = "Nume";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "first_name";
            this.Column3.HeaderText = "Prenume";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "username";
            this.Column4.HeaderText = "Username";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "password";
            this.Column5.HeaderText = "Password";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // cicoDatabaseDataSetBindingSource
            // 
            this.cicoDatabaseDataSetBindingSource.DataSource = this.cico_DatabaseDataSet;
            this.cicoDatabaseDataSetBindingSource.Position = 0;
            // 
            // cico_DatabaseDataSet
            // 
            this.cico_DatabaseDataSet.DataSetName = "Cico_DatabaseDataSet";
            this.cico_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back_again
            // 
            this.back_again.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.back_again.Location = new System.Drawing.Point(437, 408);
            this.back_again.Name = "back_again";
            this.back_again.Size = new System.Drawing.Size(239, 105);
            this.back_again.TabIndex = 11;
            this.back_again.Text = "Inapoi";
            this.back_again.UseVisualStyleBackColor = true;
            this.back_again.Click += new System.EventHandler(this.back_again_Click);
            // 
            // new_doctor
            // 
            this.new_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.new_doctor.Controls.Add(this.pass_char);
            this.new_doctor.Controls.Add(this.pass_check);
            this.new_doctor.Controls.Add(this.id_check);
            this.new_doctor.Controls.Add(this.user_check);
            this.new_doctor.Controls.Add(this.button3);
            this.new_doctor.Controls.Add(this.register_now);
            this.new_doctor.Controls.Add(this.id_medic);
            this.new_doctor.Controls.Add(this.username);
            this.new_doctor.Controls.Add(this.password);
            this.new_doctor.Controls.Add(this.last_name);
            this.new_doctor.Controls.Add(this.first_name);
            this.new_doctor.Controls.Add(this.firstnamelabel);
            this.new_doctor.Controls.Add(this.lastnamelabel);
            this.new_doctor.Controls.Add(this.passlabel);
            this.new_doctor.Controls.Add(this.userlabel);
            this.new_doctor.Controls.Add(this.iddoctorlabel);
            this.new_doctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.new_doctor.Location = new System.Drawing.Point(431, 110);
            this.new_doctor.Name = "new_doctor";
            this.new_doctor.Size = new System.Drawing.Size(695, 532);
            this.new_doctor.TabIndex = 3;
            this.new_doctor.TabStop = false;
            this.new_doctor.Text = "Medic nou";
            this.new_doctor.Visible = false;
            // 
            // pass_char
            // 
            this.pass_char.AutoSize = true;
            this.pass_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_char.Location = new System.Drawing.Point(86, 201);
            this.pass_char.Name = "pass_char";
            this.pass_char.Size = new System.Drawing.Size(122, 24);
            this.pass_char.TabIndex = 15;
            this.pass_char.Text = "Arata parola";
            this.pass_char.UseVisualStyleBackColor = true;
            this.pass_char.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pass_check
            // 
            this.pass_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_check.BackColor = System.Drawing.Color.DarkGray;
            this.pass_check.Location = new System.Drawing.Point(470, 163);
            this.pass_check.Name = "pass_check";
            this.pass_check.Size = new System.Drawing.Size(24, 19);
            this.pass_check.TabIndex = 14;
            this.pass_check.TabStop = false;
            // 
            // id_check
            // 
            this.id_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.id_check.BackColor = System.Drawing.Color.DarkGray;
            this.id_check.Location = new System.Drawing.Point(470, 47);
            this.id_check.Name = "id_check";
            this.id_check.Size = new System.Drawing.Size(24, 19);
            this.id_check.TabIndex = 13;
            this.id_check.TabStop = false;
            // 
            // user_check
            // 
            this.user_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user_check.BackColor = System.Drawing.Color.DarkGray;
            this.user_check.Location = new System.Drawing.Point(470, 106);
            this.user_check.Name = "user_check";
            this.user_check.Size = new System.Drawing.Size(24, 19);
            this.user_check.TabIndex = 12;
            this.user_check.TabStop = false;
            this.user_check.Click += new System.EventHandler(this.user_check_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(437, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 105);
            this.button3.TabIndex = 11;
            this.button3.Text = "Inapoi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // register_now
            // 
            this.register_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.register_now.Location = new System.Drawing.Point(74, 408);
            this.register_now.Name = "register_now";
            this.register_now.Size = new System.Drawing.Size(246, 105);
            this.register_now.TabIndex = 10;
            this.register_now.Text = "Inregistreaza";
            this.register_now.UseVisualStyleBackColor = true;
            this.register_now.Click += new System.EventHandler(this.register_now_Click);
            // 
            // id_medic
            // 
            this.id_medic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.id_medic.Location = new System.Drawing.Point(302, 47);
            this.id_medic.Name = "id_medic";
            this.id_medic.Size = new System.Drawing.Size(148, 38);
            this.id_medic.TabIndex = 9;
            this.id_medic.TextChanged += new System.EventHandler(this.id_medic_TextChanged);
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username.Location = new System.Drawing.Point(302, 106);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(148, 38);
            this.username.TabIndex = 8;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Location = new System.Drawing.Point(302, 163);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(148, 38);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // last_name
            // 
            this.last_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.last_name.Location = new System.Drawing.Point(302, 225);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(148, 38);
            this.last_name.TabIndex = 6;
            // 
            // first_name
            // 
            this.first_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.first_name.Location = new System.Drawing.Point(302, 290);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(148, 38);
            this.first_name.TabIndex = 5;
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Location = new System.Drawing.Point(80, 296);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(130, 32);
            this.firstnamelabel.TabIndex = 4;
            this.firstnamelabel.Text = "Prenume";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Location = new System.Drawing.Point(80, 231);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(90, 32);
            this.lastnamelabel.TabIndex = 3;
            this.lastnamelabel.Text = "Nume";
            // 
            // passlabel
            // 
            this.passlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(80, 163);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(98, 32);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = "Parola";
            // 
            // userlabel
            // 
            this.userlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(80, 112);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(127, 32);
            this.userlabel.TabIndex = 1;
            this.userlabel.Text = "Utilizator";
            // 
            // iddoctorlabel
            // 
            this.iddoctorlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iddoctorlabel.AutoSize = true;
            this.iddoctorlabel.Location = new System.Drawing.Point(80, 53);
            this.iddoctorlabel.Name = "iddoctorlabel";
            this.iddoctorlabel.Size = new System.Drawing.Size(121, 32);
            this.iddoctorlabel.TabIndex = 0;
            this.iddoctorlabel.Text = "Id medic";
            // 
            // show_doctors
            // 
            this.show_doctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.show_doctors.Location = new System.Drawing.Point(81, 311);
            this.show_doctors.Name = "show_doctors";
            this.show_doctors.Size = new System.Drawing.Size(227, 105);
            this.show_doctors.TabIndex = 2;
            this.show_doctors.Text = "Afiseaza medicii";
            this.show_doctors.UseVisualStyleBackColor = true;
            this.show_doctors.Click += new System.EventHandler(this.show_doctors_Click);
            // 
            // register_doctor
            // 
            this.register_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.register_doctor.Location = new System.Drawing.Point(81, 169);
            this.register_doctor.Name = "register_doctor";
            this.register_doctor.Size = new System.Drawing.Size(227, 105);
            this.register_doctor.TabIndex = 1;
            this.register_doctor.Text = "Inregistreaza un medic nou";
            this.register_doctor.UseVisualStyleBackColor = true;
            this.register_doctor.Click += new System.EventHandler(this.register_doctor_Click);
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1208, 717);
            this.Controls.Add(this.admin_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.admin_menu.ResumeLayout(false);
            this.current_Activity.ResumeLayout(false);
            this.current_Activity.PerformLayout();
            this.all_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctors_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicoDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cico_DatabaseDataSet)).EndInit();
            this.new_doctor.ResumeLayout(false);
            this.new_doctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_menu;
        private System.Windows.Forms.Button show_doctors;
        private System.Windows.Forms.Button register_doctor;
        private System.Windows.Forms.GroupBox new_doctor;
        private System.Windows.Forms.TextBox id_medic;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label iddoctorlabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button register_now;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pass_check;
        private System.Windows.Forms.PictureBox id_check;
        private System.Windows.Forms.PictureBox user_check;
        private System.Windows.Forms.CheckBox pass_char;
        private System.Windows.Forms.GroupBox all_doctors;
        private System.Windows.Forms.Button back_again;
        private System.Windows.Forms.Button btnShowActivity;
        private System.Windows.Forms.DataGridView doctors_table;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox current_Activity;
        private System.Windows.Forms.Panel activity_panel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource cicoDatabaseDataSetBindingSource;
        private Cico_DatabaseDataSet cico_DatabaseDataSet;
    }
}