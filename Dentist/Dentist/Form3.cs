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
using System.IO;

namespace Dentist
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        private bool IsNumber(string number)
        {
            for(int i = 0; i <= number.Length - 1; i++)
            {
                if (number[i] < '0' || number[i] > '9')
                    return false; 
            }

            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            SqlCommand scm = new SqlCommand("select count (*) as cnt from Doctors where @id_medic = id_medic", scn);
            scm.Parameters.AddWithValue("@id_medic", number);
            if(scm.ExecuteScalar().ToString() == "1")
            {
                return false;
            }

            scn.Close();
            return true;
        }
        private bool pass(string pass)
        {
            if (pass.Length < 5)
                return false;

            for(int i = 0; i <= pass.Length - 1; i++)
            {
                if (pass[i] == ' ')
                    return false;
            }
            return true;
        }
        
        private void Clear_doctor()
        {
            id_medic.Clear();
            username.Clear();
            password.Clear();
            last_name.Clear();
            first_name.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            register_doctor.Enabled = true;
            show_doctors.Enabled = true;
            btnShowActivity.Enabled = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Clear_doctor();
        }

        private void register_doctor_Click(object sender, EventArgs e)
        {
            id_check.BackColor = Color.DarkGray;
            user_check.BackColor = Color.DarkGray;
            pass_check.BackColor = Color.DarkGray;
            Clear_doctor();
            new_doctor.Visible = true;
            register_doctor.Enabled = false;
            show_doctors.Enabled = false;
            btnShowActivity.Enabled = false;
            current_Activity.Visible = false;
            all_doctors.Visible = false;
            pass_char.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            register_doctor.Enabled = true;
            show_doctors.Enabled = true;
            btnShowActivity.Enabled = true;
            new_doctor.Visible = false;
            all_doctors.Visible = false;
            current_Activity.Visible = false;
        }

        private void register_now_Click(object sender, EventArgs e)
        {
            // we register a new doctor but we also check some situations

            if(id_medic.Text == "" || username.Text == "" || password.Text == "" || last_name.Text == "" || first_name.Text == "")
            {
                MessageBox.Show("Va rog completati toate campurile!");
                return;
            }
            // we also check if the doctor id will be unique and composed only of digits
            if(IsNumber(id_medic.Text) == false)
            {
                MessageBox.Show("Id-ul medicului trebuie sa fie alcatuit doar din cifre!");
                return;
            }

            if (pass(password.Text) == false)
            {
                MessageBox.Show("Parola trebuie sa fie alcatuita din minim 5 caractere fara spatii!");
                return;
            }

            if(user_check.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Va rog sa folositi un nume de utilizator valid!");
                return;
            }

            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            //we check if the username is taken
            // we create the image to upload in a newly created account by converting it to binary
            Image image = Properties.Resources.default_user_image;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var bytes = ms.ToArray();
      
            SqlCommand SCM = new SqlCommand("insert into Doctors (id_medic, username, password, last_name, first_name, profile_image) values (@id_medic, @username, @password, @last_name, @first_name, @image)", scn);
            SCM.Parameters.AddWithValue("@id_medic", id_medic.Text);
            SCM.Parameters.AddWithValue("@username", username.Text);
            SCM.Parameters.AddWithValue("@password", password.Text);
            SCM.Parameters.AddWithValue("@last_name", last_name.Text);
            SCM.Parameters.AddWithValue("@first_name", first_name.Text);
            SCM.Parameters.AddWithValue("@image", bytes); 
            SCM.ExecuteNonQuery();
            MessageBox.Show("Medicul a fost inregistrat!");

            Clear_doctor();
            scn.Close();

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if(username.Text.Length > 0 && username.Text.Length < 5)
            {
                user_check.BackColor = Color.IndianRed;
                return;
            }
            
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            //we check if the username is taken

            SqlCommand Check_Command = new SqlCommand("select count (*) as cnt from Doctors where @username = username", scn);
            Check_Command.Parameters.AddWithValue("@username", username.Text);
            if (Check_Command.ExecuteScalar().ToString() == "1")
            {
                user_check.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                user_check.BackColor = Color.ForestGreen;
            }

            if (username.Text == "")
                user_check.BackColor = Color.DarkGray;

            scn.Close();
        }

        private void id_medic_TextChanged(object sender, EventArgs e)
        {

            if (IsNumber(id_medic.Text) == false)
                id_check.BackColor = Color.IndianRed;
            else
                id_check.BackColor = Color.ForestGreen;

            if (id_medic.Text == "")
                id_check.BackColor = Color.DarkGray;

        }
        private void user_check_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (pass(password.Text) == false)
                pass_check.BackColor = Color.IndianRed;
            else
                pass_check.BackColor = Color.ForestGreen;

            if (password.Text == "")
                pass_check.BackColor = Color.DarkGray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_char.Checked == true)
                password.PasswordChar = '\0';
            else
                password.PasswordChar = '*';
        }

        private void show_doctors_Click(object sender, EventArgs e)
        {
            register_doctor.Enabled = false;
            show_doctors.Enabled = false;
            btnShowActivity.Enabled = false;
            new_doctor.Visible = false;
            all_doctors.Visible = true;
            current_Activity.Visible = false;

            // loading the doctors table with the current doctors in the clinic
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            SqlCommand Command = new SqlCommand("select * from Doctors", scn);
            Command.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(Command);
            DataTable table = new DataTable();
            sda.Fill(table);
            doctors_table.DataSource = table;



            scn.Close();
        }

        private void back_again_Click(object sender, EventArgs e)
        {
            register_doctor.Enabled = true;
            show_doctors.Enabled = true;
            btnShowActivity.Enabled = true;
            all_doctors.Visible = false;
            current_Activity.Visible = false;
            new_doctor.Visible = false;
        }

        private void all_doctors_Enter(object sender, EventArgs e)
        {

        }

        private void btnShowActivity_Click(object sender, EventArgs e)
        {
            register_doctor.Enabled = false;
            show_doctors.Enabled = false;
            btnShowActivity.Enabled = false;
            new_doctor.Visible = false;
            all_doctors.Visible = false;
            current_Activity.Visible = true;
            timer1.Start();




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register_doctor.Enabled = true;
            show_doctors.Enabled = true;
            btnShowActivity.Enabled = true;
            all_doctors.Visible = false;
            new_doctor.Visible = false;
            current_Activity.Visible = false;
            timer1.Stop();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dateTime = DateTime.Today;
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            string sqlQuery = $"select * from PacientActions";
            SqlCommand scm = new SqlCommand(sqlQuery, scn);
            scm.CommandType = CommandType.Text;

            SqlDataAdapter sda = new SqlDataAdapter(scm);
            DataTable table = new DataTable();
            sda.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["show_case"].ToString() == "OFF")
                {
                    string current_Row = "";

                    SqlConnection SCN = new SqlConnection(connection);
                    SCN.Open();
                    SqlCommand sqlCommand = new SqlCommand($"update PacientActions set show_case = '{"ON"}' where Id = '{Convert.ToInt32(row["Id"].ToString())}'", SCN);
                    sqlCommand.ExecuteNonQuery();
                    SCN.Close();

                    SCN.Open();
                    int doctorid = Convert.ToInt32(row["Id_medic"].ToString());
                    SqlCommand command = new SqlCommand($"select last_name, first_name from Doctors where id_medic = '{doctorid}'", scn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();
                    current_Row = dataReader.GetValue(0).ToString() + " " + dataReader.GetValue(0).ToString();
                    dataReader.Close();
                    current_Row = current_Row + "; Actiune: " + row["Action"].ToString() + "; Pacient: " + row["Pacient_name"];
                    Random rand = new Random();
                    int a = rand.Next(1, 255);
                    int b = rand.Next(1, 255);
                    int c = rand.Next(1, 255);
                    Label lblMedic = new Label();
                    lblMedic.Name = $"lbl{i}";
                    lblMedic.Text = current_Row;
                    lblMedic.Dock = DockStyle.Top;
                    lblMedic.AutoEllipsis = true;
                    lblMedic.Font = new Font("Microsoft Sans Serif", 14);
                    lblMedic.AllowDrop = true;
                    lblMedic.ForeColor = Color.FromArgb(a, b, c);
                    activity_panel.Controls.Add(lblMedic);

                    SCN.Close();
                    i++;
                }
            }

            scn.Close();
        }
    }
}
