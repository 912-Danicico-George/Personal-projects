namespace Dentist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.pacient_button = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.pacient_button);
            this.panel1.Controls.Add(this.menu_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 826);
            this.panel1.TabIndex = 0;
            // 
            // logout_button
            // 
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_button.Location = new System.Drawing.Point(0, 398);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(288, 88);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Delogare";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Visible = false;
            this.logout_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // pacient_button
            // 
            this.pacient_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacient_button.FlatAppearance.BorderSize = 0;
            this.pacient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacient_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pacient_button.Location = new System.Drawing.Point(0, 300);
            this.pacient_button.Name = "pacient_button";
            this.pacient_button.Size = new System.Drawing.Size(288, 98);
            this.pacient_button.TabIndex = 2;
            this.pacient_button.Text = "Pacienți";
            this.pacient_button.UseVisualStyleBackColor = true;
            this.pacient_button.Visible = false;
            this.pacient_button.Click += new System.EventHandler(this.pacient_button_Click);
            // 
            // menu_button
            // 
            this.menu_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_button.FlatAppearance.BorderSize = 0;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_button.Location = new System.Drawing.Point(0, 204);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(288, 96);
            this.menu_button.TabIndex = 1;
            this.menu_button.Text = "Meniu";
            this.menu_button.UseVisualStyleBackColor = true;
            this.menu_button.Visible = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Dentist.Properties.Resources.dinte_1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1339, 826);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button pacient_button;
        private System.Windows.Forms.Timer timer1;
    }
}

