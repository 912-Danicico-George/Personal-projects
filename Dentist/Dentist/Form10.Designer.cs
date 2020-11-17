namespace Dentist
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.lblPacient = new System.Windows.Forms.Label();
            this.pacientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pacientAdress = new System.Windows.Forms.Label();
            this.pacientAge = new System.Windows.Forms.Label();
            this.pacientPhone = new System.Windows.Forms.Label();
            this.pacientData_panel = new System.Windows.Forms.Panel();
            this.btnShowRad = new System.Windows.Forms.Button();
            this.btnUploadRad = new System.Windows.Forms.Button();
            this.pacientdata = new System.Windows.Forms.Label();
            this.pacientHistory_panel = new System.Windows.Forms.Panel();
            this.pacientHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Dentist.Database1DataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.currentSchedule = new System.Windows.Forms.Panel();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.pacientProblems = new System.Windows.Forms.Label();
            this.lblProgramare = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataFutureProgramation = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pacientData_panel.SuspendLayout();
            this.pacientHistory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.currentSchedule.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFutureProgramation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacient
            // 
            this.lblPacient.AutoSize = true;
            this.lblPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacient.Location = new System.Drawing.Point(3, 22);
            this.lblPacient.Name = "lblPacient";
            this.lblPacient.Size = new System.Drawing.Size(98, 32);
            this.lblPacient.TabIndex = 0;
            this.lblPacient.Text = "Nume:";
            // 
            // pacientName
            // 
            this.pacientName.AutoSize = true;
            this.pacientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientName.Location = new System.Drawing.Point(97, 22);
            this.pacientName.Name = "pacientName";
            this.pacientName.Size = new System.Drawing.Size(221, 32);
            this.pacientName.TabIndex = 1;
            this.pacientName.Text = "<Pacient name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa:";
            // 
            // pacientAdress
            // 
            this.pacientAdress.AutoSize = true;
            this.pacientAdress.Location = new System.Drawing.Point(130, 187);
            this.pacientAdress.Name = "pacientAdress";
            this.pacientAdress.Size = new System.Drawing.Size(132, 32);
            this.pacientAdress.TabIndex = 5;
            this.pacientAdress.Text = "<adress>";
            // 
            // pacientAge
            // 
            this.pacientAge.AutoSize = true;
            this.pacientAge.Location = new System.Drawing.Point(125, 135);
            this.pacientAge.Name = "pacientAge";
            this.pacientAge.Size = new System.Drawing.Size(95, 32);
            this.pacientAge.TabIndex = 6;
            this.pacientAge.Text = "<age>";
            // 
            // pacientPhone
            // 
            this.pacientPhone.AutoSize = true;
            this.pacientPhone.Location = new System.Drawing.Point(125, 84);
            this.pacientPhone.Name = "pacientPhone";
            this.pacientPhone.Size = new System.Drawing.Size(127, 32);
            this.pacientPhone.TabIndex = 7;
            this.pacientPhone.Text = "<phone>";
            // 
            // pacientData_panel
            // 
            this.pacientData_panel.AutoScroll = true;
            this.pacientData_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pacientData_panel.Controls.Add(this.btnShowRad);
            this.pacientData_panel.Controls.Add(this.btnUploadRad);
            this.pacientData_panel.Controls.Add(this.pacientAdress);
            this.pacientData_panel.Controls.Add(this.pacientAge);
            this.pacientData_panel.Controls.Add(this.label3);
            this.pacientData_panel.Controls.Add(this.pacientPhone);
            this.pacientData_panel.Controls.Add(this.lblPacient);
            this.pacientData_panel.Controls.Add(this.pacientName);
            this.pacientData_panel.Controls.Add(this.label2);
            this.pacientData_panel.Controls.Add(this.label1);
            this.pacientData_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientData_panel.Location = new System.Drawing.Point(25, 60);
            this.pacientData_panel.Name = "pacientData_panel";
            this.pacientData_panel.Size = new System.Drawing.Size(331, 325);
            this.pacientData_panel.TabIndex = 4;
            // 
            // btnShowRad
            // 
            this.btnShowRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRad.Location = new System.Drawing.Point(173, 243);
            this.btnShowRad.Name = "btnShowRad";
            this.btnShowRad.Size = new System.Drawing.Size(133, 56);
            this.btnShowRad.TabIndex = 9;
            this.btnShowRad.Text = "Arata radiografie";
            this.btnShowRad.UseVisualStyleBackColor = true;
            this.btnShowRad.Visible = false;
            this.btnShowRad.Click += new System.EventHandler(this.btnShowRad_Click);
            // 
            // btnUploadRad
            // 
            this.btnUploadRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadRad.Location = new System.Drawing.Point(17, 243);
            this.btnUploadRad.Name = "btnUploadRad";
            this.btnUploadRad.Size = new System.Drawing.Size(133, 56);
            this.btnUploadRad.TabIndex = 8;
            this.btnUploadRad.Text = "Incarca radiografie";
            this.btnUploadRad.UseVisualStyleBackColor = true;
            this.btnUploadRad.Visible = false;
            this.btnUploadRad.Click += new System.EventHandler(this.btnUploadRad_Click);
            // 
            // pacientdata
            // 
            this.pacientdata.AutoSize = true;
            this.pacientdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientdata.Location = new System.Drawing.Point(19, 25);
            this.pacientdata.Name = "pacientdata";
            this.pacientdata.Size = new System.Drawing.Size(175, 32);
            this.pacientdata.TabIndex = 8;
            this.pacientdata.Text = "Date pacient";
            // 
            // pacientHistory_panel
            // 
            this.pacientHistory_panel.AutoScroll = true;
            this.pacientHistory_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pacientHistory_panel.Controls.Add(this.pacientHistory);
            this.pacientHistory_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientHistory_panel.Location = new System.Drawing.Point(397, 60);
            this.pacientHistory_panel.Name = "pacientHistory_panel";
            this.pacientHistory_panel.Size = new System.Drawing.Size(475, 389);
            this.pacientHistory_panel.TabIndex = 9;
            // 
            // pacientHistory
            // 
            this.pacientHistory.AllowUserToAddRows = false;
            this.pacientHistory.AllowUserToDeleteRows = false;
            this.pacientHistory.AutoGenerateColumns = false;
            this.pacientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.pacientHistory.DataSource = this.database1DataSetBindingSource;
            this.pacientHistory.Location = new System.Drawing.Point(4, 4);
            this.pacientHistory.Name = "pacientHistory";
            this.pacientHistory.ReadOnly = true;
            this.pacientHistory.RowHeadersWidth = 51;
            this.pacientHistory.RowTemplate.Height = 24;
            this.pacientHistory.Size = new System.Drawing.Size(464, 379);
            this.pacientHistory.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "AppDate";
            this.Column1.HeaderText = "Data";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 104;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Action";
            this.Column2.HeaderText = "Actiune";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Pret";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 96;
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
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Istoric pacient";
            // 
            // currentSchedule
            // 
            this.currentSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentSchedule.Controls.Add(this.label4);
            this.currentSchedule.Controls.Add(this.lblHour);
            this.currentSchedule.Controls.Add(this.btnCancel);
            this.currentSchedule.Controls.Add(this.txtPrice);
            this.currentSchedule.Controls.Add(this.label9);
            this.currentSchedule.Controls.Add(this.btnSolve);
            this.currentSchedule.Controls.Add(this.pacientProblems);
            this.currentSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSchedule.Location = new System.Drawing.Point(25, 425);
            this.currentSchedule.Name = "currentSchedule";
            this.currentSchedule.Size = new System.Drawing.Size(339, 255);
            this.currentSchedule.TabIndex = 10;
            this.currentSchedule.Visible = false;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(92, 16);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(75, 25);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "<hour>";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 84);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Anuleaza sedinta\r\n";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 124);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 38);
            this.txtPrice.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pret:";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(11, 168);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(156, 84);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Sedinta terminata";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // pacientProblems
            // 
            this.pacientProblems.AutoEllipsis = true;
            this.pacientProblems.AutoSize = true;
            this.pacientProblems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pacientProblems.Location = new System.Drawing.Point(9, 63);
            this.pacientProblems.Name = "pacientProblems";
            this.pacientProblems.Size = new System.Drawing.Size(264, 32);
            this.pacientProblems.TabIndex = 0;
            this.pacientProblems.Text = "<pacient problems>";
            // 
            // lblProgramare
            // 
            this.lblProgramare.AutoSize = true;
            this.lblProgramare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramare.Location = new System.Drawing.Point(391, 452);
            this.lblProgramare.Name = "lblProgramare";
            this.lblProgramare.Size = new System.Drawing.Size(255, 32);
            this.lblProgramare.TabIndex = 11;
            this.lblProgramare.Text = "Programari viitoare";
            this.lblProgramare.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(701, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 32);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "<Date>";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataFutureProgramation);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(397, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 204);
            this.panel1.TabIndex = 13;
            // 
            // dataFutureProgramation
            // 
            this.dataFutureProgramation.AllowUserToAddRows = false;
            this.dataFutureProgramation.AllowUserToDeleteRows = false;
            this.dataFutureProgramation.AutoGenerateColumns = false;
            this.dataFutureProgramation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFutureProgramation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column5});
            this.dataFutureProgramation.DataSource = this.database1DataSetBindingSource;
            this.dataFutureProgramation.Location = new System.Drawing.Point(3, 3);
            this.dataFutureProgramation.Name = "dataFutureProgramation";
            this.dataFutureProgramation.ReadOnly = true;
            this.dataFutureProgramation.RowHeadersWidth = 51;
            this.dataFutureProgramation.RowTemplate.Height = 24;
            this.dataFutureProgramation.Size = new System.Drawing.Size(460, 188);
            this.dataFutureProgramation.TabIndex = 0;
            this.dataFutureProgramation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFutureProgramation_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Afiseaza";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AppDate";
            this.Column4.HeaderText = "Data";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Comment";
            this.Column5.HeaderText = "Probleme";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ora: ";
            // 
            // Form10
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(989, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblProgramare);
            this.Controls.Add(this.currentSchedule);
            this.Controls.Add(this.pacientHistory_panel);
            this.Controls.Add(this.pacientdata);
            this.Controls.Add(this.pacientData_panel);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.pacientData_panel.ResumeLayout(false);
            this.pacientData_panel.PerformLayout();
            this.pacientHistory_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.currentSchedule.ResumeLayout(false);
            this.currentSchedule.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFutureProgramation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacient;
        private System.Windows.Forms.Label pacientName;
        private System.Windows.Forms.Label pacientPhone;
        private System.Windows.Forms.Label pacientAge;
        private System.Windows.Forms.Label pacientAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pacientData_panel;
        private System.Windows.Forms.Label pacientdata;
        private System.Windows.Forms.Panel pacientHistory_panel;
        private System.Windows.Forms.DataGridView pacientHistory;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel currentSchedule;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label pacientProblems;
        private System.Windows.Forms.Label lblProgramare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataFutureProgramation;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnShowRad;
        private System.Windows.Forms.Button btnUploadRad;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
    }
}