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
namespace Dentist
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string user;
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            show_pass.Checked = false;
            password.PasswordChar = '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Va rog sa completati campurile!");
                username.Clear();
                password.Clear();
                return;
            }

            if(username.Text == "administrator" && password.Text == "admin123")
            {
                Form1.ok = 2;
                MessageBox.Show("Ati intrat in contul de administrator!");
                Form3 form3 = new Form3();
                form3.MdiParent = Form1.ActiveForm;
                form3.Location = new Point(0, 0);
                form3.Show();
                this.Close();

                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand Command = new SqlCommand($"update PacientActions set show_case = @show", con);
                Command.Parameters.AddWithValue("@show", "OFF");
                Command.ExecuteNonQuery();
                con.Close();

                return;
            }
           
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand SCM = new SqlCommand("select count (*) as cnt from Doctors where @username = username and @password = password", scn);
            SCM.Parameters.AddWithValue("@username", username.Text);
            SCM.Parameters.AddWithValue("@password", password.Text);
            if (SCM.ExecuteScalar().ToString() == "1")
            {
                Form1.username = username.Text;
                MessageBox.Show("Ati intrat in cont!");

                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand Command = new SqlCommand($"update PacientActions set show_case = @show ", con);
                Command.Parameters.AddWithValue("@show", "OFF");
                Command.ExecuteNonQuery();
                con.Close();

                Form1.ok = 1;
                Form4 form4 = new Form4();
                form4.MdiParent = Form1.ActiveForm;
                form4.Location = new Point(0, 0);
                form4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Utilizator sau parola gresite!");
                username.Clear();
                password.Clear();
            }
            scn.Close();
            return;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass.Checked == false)
                password.PasswordChar = '*';
            else
                password.PasswordChar = '\0';
        }
    }
}
