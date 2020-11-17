namespace Dentist
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mypacients = new System.Windows.Forms.GroupBox();
            this.backshow = new System.Windows.Forms.Button();
            this.mypacients_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Dentist.Database1DataSet();
            this.register_box = new System.Windows.Forms.GroupBox();
            this.backagain = new System.Windows.Forms.Button();
            this.register_now = new System.Windows.Forms.Button();
            this.age_pacient = new System.Windows.Forms.TextBox();
            this.phone_pacient = new System.Windows.Forms.TextBox();
            this.adress_pacient = new System.Windows.Forms.TextBox();
            this.cnp_pacient = new System.Windows.Forms.TextBox();
            this.first_namepacient = new System.Windows.Forms.TextBox();
            this.last_namepacient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activity_group = new System.Windows.Forms.GroupBox();
            this.activity_panel = new System.Windows.Forms.Panel();
            this.details_panel = new System.Windows.Forms.Panel();
            this.show_allpacients = new System.Windows.Forms.Button();
            this.pacient_register = new System.Windows.Forms.Button();
            this.show_appointment = new System.Windows.Forms.Button();
            this.change_photo = new System.Windows.Forms.Button();
            this.doctor_name = new System.Windows.Forms.Label();
            this.doctor_picture = new System.Windows.Forms.PictureBox();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.cico_DatabaseDataSet = new Dentist.Cico_DatabaseDataSet();
            this.cicoDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.mypacients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mypacients_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.register_box.SuspendLayout();
            this.activity_group.SuspendLayout();
            this.details_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cico_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicoDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.mypacients);
            this.groupBox1.Controls.Add(this.register_box);
            this.groupBox1.Controls.Add(this.activity_group);
            this.groupBox1.Controls.Add(this.details_panel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 773);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panoul doctorului";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mypacients
            // 
            this.mypacients.Controls.Add(this.backshow);
            this.mypacients.Controls.Add(this.mypacients_dgv);
            this.mypacients.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mypacients.Location = new System.Drawing.Point(472, 77);
            this.mypacients.Name = "mypacients";
            this.mypacients.Size = new System.Drawing.Size(649, 557);
            this.mypacients.TabIndex = 14;
            this.mypacients.TabStop = false;
            this.mypacients.Text = "Pacientii mei";
            this.mypacients.Visible = false;
            // 
            // backshow
            // 
            this.backshow.Location = new System.Drawing.Point(484, 498);
            this.backshow.Name = "backshow";
            this.backshow.Size = new System.Drawing.Size(143, 53);
            this.backshow.TabIndex = 1;
            this.backshow.Text = "Inapoi";
            this.backshow.UseVisualStyleBackColor = true;
            this.backshow.Click += new System.EventHandler(this.backshow_Click);
            // 
            // mypacients_dgv
            // 
            this.mypacients_dgv.AllowUserToAddRows = false;
            this.mypacients_dgv.AllowUserToDeleteRows = false;
            this.mypacients_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mypacients_dgv.AutoGenerateColumns = false;
            this.mypacients_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mypacients_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.mypacients_dgv.DataSource = this.cicoDatabaseDataSetBindingSource;
            this.mypacients_dgv.Location = new System.Drawing.Point(32, 70);
            this.mypacients_dgv.Name = "mypacients_dgv";
            this.mypacients_dgv.ReadOnly = true;
            this.mypacients_dgv.RowHeadersWidth = 51;
            this.mypacients_dgv.RowTemplate.Height = 24;
            this.mypacients_dgv.Size = new System.Drawing.Size(595, 422);
            this.mypacients_dgv.TabIndex = 0;
            this.mypacients_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mypacients_dgv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
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
            this.Column4.DataPropertyName = "phone_number";
            this.Column4.HeaderText = "Telefon";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Afiseaza";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 125;
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
            // register_box
            // 
            this.register_box.Controls.Add(this.backagain);
            this.register_box.Controls.Add(this.register_now);
            this.register_box.Controls.Add(this.age_pacient);
            this.register_box.Controls.Add(this.phone_pacient);
            this.register_box.Controls.Add(this.adress_pacient);
            this.register_box.Controls.Add(this.cnp_pacient);
            this.register_box.Controls.Add(this.first_namepacient);
            this.register_box.Controls.Add(this.last_namepacient);
            this.register_box.Controls.Add(this.label6);
            this.register_box.Controls.Add(this.label5);
            this.register_box.Controls.Add(this.label4);
            this.register_box.Controls.Add(this.label3);
            this.register_box.Controls.Add(this.label2);
            this.register_box.Controls.Add(this.label1);
            this.register_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.register_box.Location = new System.Drawing.Point(490, 64);
            this.register_box.Name = "register_box";
            this.register_box.Size = new System.Drawing.Size(649, 557);
            this.register_box.TabIndex = 2;
            this.register_box.TabStop = false;
            this.register_box.Text = "Inregistreaza pacient";
            this.register_box.Visible = false;
            // 
            // backagain
            // 
            this.backagain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backagain.Location = new System.Drawing.Point(344, 410);
            this.backagain.Name = "backagain";
            this.backagain.Size = new System.Drawing.Size(213, 102);
            this.backagain.TabIndex = 13;
            this.backagain.Text = "Inapoi";
            this.backagain.UseVisualStyleBackColor = true;
            this.backagain.Click += new System.EventHandler(this.backagain_Click);
            // 
            // register_now
            // 
            this.register_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.register_now.Location = new System.Drawing.Point(92, 410);
            this.register_now.Name = "register_now";
            this.register_now.Size = new System.Drawing.Size(213, 102);
            this.register_now.TabIndex = 12;
            this.register_now.Text = "Inregistreaza";
            this.register_now.UseVisualStyleBackColor = true;
            this.register_now.Click += new System.EventHandler(this.register_now_Click);
            // 
            // age_pacient
            // 
            this.age_pacient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.age_pacient.Location = new System.Drawing.Point(277, 331);
            this.age_pacient.Name = "age_pacient";
            this.age_pacient.Size = new System.Drawing.Size(198, 38);
            this.age_pacient.TabIndex = 11;
            // 
            // phone_pacient
            // 
            this.phone_pacient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_pacient.Location = new System.Drawing.Point(277, 282);
            this.phone_pacient.Name = "phone_pacient";
            this.phone_pacient.Size = new System.Drawing.Size(198, 38);
            this.phone_pacient.TabIndex = 10;
            // 
            // adress_pacient
            // 
            this.adress_pacient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adress_pacient.Location = new System.Drawing.Point(277, 232);
            this.adress_pacient.Name = "adress_pacient";
            this.adress_pacient.Size = new System.Drawing.Size(198, 38);
            this.adress_pacient.TabIndex = 9;
            // 
            // cnp_pacient
            // 
            this.cnp_pacient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cnp_pacient.Location = new System.Drawing.Point(277, 184);
            this.cnp_pacient.Name = "cnp_pacient";
            this.cnp_pacient.Size = new System.Drawing.Size(198, 38);
            this.cnp_pacient.TabIndex = 8;
            // 
            // first_namepacient
            // 
            this.first_namepacient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.first_namepacient.Location = new System.Drawing.Point(277, 139);
            this.first_namepacient.Name = "first_namepacient";
            this.first_namepacient.Size = new System.Drawing.Size(198, 38);
            this.first_namepacient.TabIndex = 7;
            // 
            // last_namepacient
            // 
            this.last_namepacient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.last_namepacient.Location = new System.Drawing.Point(277, 92);
            this.last_namepacient.Name = "last_namepacient";
            this.last_namepacient.Size = new System.Drawing.Size(198, 38);
            this.last_namepacient.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Varsta";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNP";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // activity_group
            // 
            this.activity_group.Controls.Add(this.activity_panel);
            this.activity_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.activity_group.Location = new System.Drawing.Point(507, 49);
            this.activity_group.Name = "activity_group";
            this.activity_group.Size = new System.Drawing.Size(597, 502);
            this.activity_group.TabIndex = 1;
            this.activity_group.TabStop = false;
            this.activity_group.Text = "Activitate zilnică";
            // 
            // activity_panel
            // 
            this.activity_panel.AutoScroll = true;
            this.activity_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.activity_panel.Location = new System.Drawing.Point(31, 64);
            this.activity_panel.Name = "activity_panel";
            this.activity_panel.Size = new System.Drawing.Size(542, 427);
            this.activity_panel.TabIndex = 0;
            // 
            // details_panel
            // 
            this.details_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.details_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.details_panel.Controls.Add(this.show_allpacients);
            this.details_panel.Controls.Add(this.pacient_register);
            this.details_panel.Controls.Add(this.show_appointment);
            this.details_panel.Controls.Add(this.change_photo);
            this.details_panel.Controls.Add(this.doctor_name);
            this.details_panel.Controls.Add(this.doctor_picture);
            this.details_panel.Location = new System.Drawing.Point(56, 108);
            this.details_panel.Name = "details_panel";
            this.details_panel.Size = new System.Drawing.Size(302, 427);
            this.details_panel.TabIndex = 0;
            // 
            // show_allpacients
            // 
            this.show_allpacients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.show_allpacients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_allpacients.Location = new System.Drawing.Point(23, 347);
            this.show_allpacients.Name = "show_allpacients";
            this.show_allpacients.Size = new System.Drawing.Size(173, 59);
            this.show_allpacients.TabIndex = 5;
            this.show_allpacients.Text = "Afiseaza pacientii";
            this.show_allpacients.UseVisualStyleBackColor = true;
            this.show_allpacients.Click += new System.EventHandler(this.show_allpacients_Click);
            // 
            // pacient_register
            // 
            this.pacient_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pacient_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacient_register.Location = new System.Drawing.Point(23, 282);
            this.pacient_register.Name = "pacient_register";
            this.pacient_register.Size = new System.Drawing.Size(173, 59);
            this.pacient_register.TabIndex = 4;
            this.pacient_register.Text = "Inregistreaza pacient";
            this.pacient_register.UseVisualStyleBackColor = true;
            this.pacient_register.Click += new System.EventHandler(this.pacient_register_Click);
            // 
            // show_appointment
            // 
            this.show_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.show_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_appointment.Location = new System.Drawing.Point(23, 217);
            this.show_appointment.Name = "show_appointment";
            this.show_appointment.Size = new System.Drawing.Size(173, 59);
            this.show_appointment.TabIndex = 3;
            this.show_appointment.Text = "Arata agenda";
            this.show_appointment.UseVisualStyleBackColor = true;
            this.show_appointment.Click += new System.EventHandler(this.button2_Click);
            // 
            // change_photo
            // 
            this.change_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.change_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_photo.Location = new System.Drawing.Point(23, 152);
            this.change_photo.Name = "change_photo";
            this.change_photo.Size = new System.Drawing.Size(173, 59);
            this.change_photo.TabIndex = 2;
            this.change_photo.Text = "Schimba fotografia";
            this.change_photo.UseVisualStyleBackColor = true;
            this.change_photo.Click += new System.EventHandler(this.change_photo_Click);
            // 
            // doctor_name
            // 
            this.doctor_name.AllowDrop = true;
            this.doctor_name.Location = new System.Drawing.Point(129, 19);
            this.doctor_name.Name = "doctor_name";
            this.doctor_name.Size = new System.Drawing.Size(149, 114);
            this.doctor_name.TabIndex = 1;
            this.doctor_name.Text = "<Doctor name>";
            // 
            // doctor_picture
            // 
            this.doctor_picture.BackgroundImage = global::Dentist.Properties.Resources.default_user_image;
            this.doctor_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doctor_picture.Location = new System.Drawing.Point(23, 19);
            this.doctor_picture.Name = "doctor_picture";
            this.doctor_picture.Size = new System.Drawing.Size(100, 97);
            this.doctor_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctor_picture.TabIndex = 0;
            this.doctor_picture.TabStop = false;
            // 
            // timerAction
            // 
            this.timerAction.Tick += new System.EventHandler(this.timerAction_Tick);
            // 
            // cico_DatabaseDataSet
            // 
            this.cico_DatabaseDataSet.DataSetName = "Cico_DatabaseDataSet";
            this.cico_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cicoDatabaseDataSetBindingSource
            // 
            this.cicoDatabaseDataSetBindingSource.DataSource = this.cico_DatabaseDataSet;
            this.cicoDatabaseDataSetBindingSource.Position = 0;
            // 
            // Form4
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1208, 797);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.mypacients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mypacients_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.register_box.ResumeLayout(false);
            this.register_box.PerformLayout();
            this.activity_group.ResumeLayout(false);
            this.details_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cico_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicoDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel details_panel;
        private System.Windows.Forms.Label doctor_name;
        private System.Windows.Forms.PictureBox doctor_picture;
        private System.Windows.Forms.GroupBox activity_group;
        private System.Windows.Forms.Panel activity_panel;
        private System.Windows.Forms.Button change_photo;
        private System.Windows.Forms.Button show_appointment;
        private System.Windows.Forms.Button show_allpacients;
        private System.Windows.Forms.Button pacient_register;
        private System.Windows.Forms.GroupBox register_box;
        private System.Windows.Forms.Button backagain;
        private System.Windows.Forms.Button register_now;
        private System.Windows.Forms.TextBox age_pacient;
        private System.Windows.Forms.TextBox phone_pacient;
        private System.Windows.Forms.TextBox adress_pacient;
        private System.Windows.Forms.TextBox cnp_pacient;
        private System.Windows.Forms.TextBox first_namepacient;
        private System.Windows.Forms.TextBox last_namepacient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mypacients;
        private System.Windows.Forms.DataGridView mypacients_dgv;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button backshow;
        public System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.BindingSource cicoDatabaseDataSetBindingSource;
        private Cico_DatabaseDataSet cico_DatabaseDataSet;
    }
}