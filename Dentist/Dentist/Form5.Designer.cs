namespace Dentist
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.radiography = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radiography)).BeginInit();
            this.SuspendLayout();
            // 
            // radiography
            // 
            this.radiography.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radiography.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiography.Location = new System.Drawing.Point(0, 0);
            this.radiography.Name = "radiography";
            this.radiography.Size = new System.Drawing.Size(988, 660);
            this.radiography.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.radiography.TabIndex = 0;
            this.radiography.TabStop = false;
            this.radiography.Click += new System.EventHandler(this.radiography_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 660);
            this.Controls.Add(this.radiography);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Radiografie pacient";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radiography)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox radiography;
    }
}