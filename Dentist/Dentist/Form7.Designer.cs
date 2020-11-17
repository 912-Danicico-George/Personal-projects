namespace Dentist
{
    partial class AppointmentManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.next_month = new System.Windows.Forms.Button();
            this.previous_month = new System.Windows.Forms.Button();
            this.lblMonthAndYear = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flDays = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMonthAndYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToday);
            this.panel2.Controls.Add(this.Close_button);
            this.panel2.Controls.Add(this.next_month);
            this.panel2.Controls.Add(this.previous_month);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(889, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 109);
            this.panel2.TabIndex = 2;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(89, 41);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(71, 52);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Close_button.BackgroundImage = global::Dentist.Properties.Resources._83904325_181410779773438_1042126011388395520_n;
            this.Close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Location = new System.Drawing.Point(243, 41);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 52);
            this.Close_button.TabIndex = 2;
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // next_month
            // 
            this.next_month.Location = new System.Drawing.Point(166, 41);
            this.next_month.Name = "next_month";
            this.next_month.Size = new System.Drawing.Size(71, 52);
            this.next_month.TabIndex = 1;
            this.next_month.Text = ">";
            this.next_month.UseVisualStyleBackColor = true;
            this.next_month.Click += new System.EventHandler(this.next_month_Click);
            // 
            // previous_month
            // 
            this.previous_month.Location = new System.Drawing.Point(12, 41);
            this.previous_month.Name = "previous_month";
            this.previous_month.Size = new System.Drawing.Size(71, 52);
            this.previous_month.TabIndex = 0;
            this.previous_month.Text = "<";
            this.previous_month.UseVisualStyleBackColor = true;
            this.previous_month.Click += new System.EventHandler(this.previous_month_Click);
            // 
            // lblMonthAndYear
            // 
            this.lblMonthAndYear.AutoSize = true;
            this.lblMonthAndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthAndYear.Location = new System.Drawing.Point(31, 42);
            this.lblMonthAndYear.Name = "lblMonthAndYear";
            this.lblMonthAndYear.Size = new System.Drawing.Size(176, 51);
            this.lblMonthAndYear.TabIndex = 0;
            this.lblMonthAndYear.Text = "January";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1227, 50);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1057, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 44);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(881, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flDays
            // 
            this.flDays.AutoScroll = true;
            this.flDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flDays.Location = new System.Drawing.Point(0, 159);
            this.flDays.Name = "flDays";
            this.flDays.Size = new System.Drawing.Size(1227, 648);
            this.flDays.TabIndex = 3;
            // 
            // AppointmentManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1227, 807);
            this.Controls.Add(this.flDays);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.AppointmentManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button next_month;
        private System.Windows.Forms.Button previous_month;
        private System.Windows.Forms.Label lblMonthAndYear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flDays;
        private System.Windows.Forms.Button btnToday;
    }
}