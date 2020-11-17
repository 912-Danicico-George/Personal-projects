using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.IO;

namespace Dentist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        public static int ok = 0;
        public static string username;
        public static int Check = 0; // we use this variable in order to change Form9 texts for different " are you sure u want to save " 
        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Properties.Resources.default_user_image;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var bytes = ms.ToArray();
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            SqlCommand scm = new SqlCommand("update Doctors set profile_image = @image where @username = username", scn);
            scm.Parameters.AddWithValue("@username", "gg");
            scm.Parameters.AddWithValue("@image", bytes);
            scm.ExecuteNonQuery();

            scn.Close();


            timer1.Start();
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Location = new Point(0, 0);
            //form2.Size = this.Size;
            form2.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Ati fost delogat cu succes!");
            Application.Restart();
            Environment.Exit(0);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ok == 1 || ok == 2)
            {
                logout_button.Visible = true;
                menu_button.Visible = true; 
            }
            if (ok == 2)
                pacient_button.Visible = true;
            else
                pacient_button.Visible = false;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if(ok == 2)
            {
                Form3 form3 = new Form3();
                form3.MdiParent = this;
                form3.Location = new Point(0, 0);
                form3.Show();
            }
            else
            {
                if(ok == 1)
                {
                    Form4 form4 = new Form4();
                    form4.MdiParent = this;
                    form4.Location = new Point(0, 0);
                    form4.Show();
                }
            }
        }

        private void pacient_button_Click(object sender, EventArgs e)
        {
            
                    Form6 form6 = new Form6();
                    form6.MdiParent = this;
                    form6.Location = new Point(0, 0);
                    form6.Show();
                
        }
    }
}
