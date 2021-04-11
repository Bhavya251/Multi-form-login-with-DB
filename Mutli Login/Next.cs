using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lincoln;
using System.Data.SqlClient;

namespace Mutli_Login
{
    public partial class Next : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = null;
        string user;
        public Next()
        {
            InitializeComponent();
        }

        public Next(string str)
        {
            InitializeComponent();
            this.Text = "Welcome " + str;
            user = str;
            enableAll(false);
        }

        Lincoln.Lincoln lin = new Lincoln.Lincoln();

        private void Next_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand comd = new SqlCommand("select * from [users] where [username]='" + user + "';", conn);
            SqlDataReader dr = comd.ExecuteReader();

            if (dr.Read()==true)
            {
                mtxtUsername.Text = dr.GetString(1);
                mtxtPassword.Text = dr.GetString(2);
                mtxtName.Text = dr.GetString(3);
                mtxtEmail.Text = dr.GetString(4);
                mtxtContact.Text = dr.GetString(5);
                mtxtbday.Text = dr.GetDateTime(6).ToShortDateString();
                pictureBox.ImageLocation = dr.GetString(7);
            }
            dr.Close();
            using (comd = new SqlCommand("select * from [users] where [username]='" + user + "' and [admin]='admin';", conn))
            {
                dr = comd.ExecuteReader();
                if (dr.HasRows)
                    mtlAddUser.Visible = true;
                else
                    mtlAddUser.Visible = false;
                dr.Close();
            }

            conn.Close();
        }

        private void mtlLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void mtlUpdate_Click(object sender, EventArgs e)
        {
            bool correct;
            conn.Open();

            String name = mtxtName.Text;
            String contact = mtxtContact.Text;
            String email = mtxtEmail.Text;
            String image = openImage.FileName;


            if (name.Equals("") || contact.Equals("") || email.Equals(""))
            {
                MessageBox.Show("Enter All Field");
                correct = false;
            }
            else
            {
                correct = (Validation.validateContact(contact) && Validation.valideEmail(email));
            }

            try
            {
                if (correct)
                {
                    SqlCommand comd = new SqlCommand("update [users] set [fullname]=@name, [contact]=@contact, [email]=@email, [photo]=@image where [username]='" + user + "';", conn);
                    comd.Parameters.AddWithValue("@name",name);
                    comd.Parameters.AddWithValue("@email", email);
                    comd.Parameters.AddWithValue("@contact", contact);
                    comd.Parameters.AddWithValue("@image", image);

                    int i = comd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "OK", "Successfully UPDATED", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error", "Failed to UPDATE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    enableAll(false);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message.ToString());
            }
            conn.Close();
        }

        public void enableAll(bool status)
        {
            mtlUpdate.Enabled = status;           
            mtxtUsername.Enabled = status;
            mtxtPassword.Enabled = status;
            mtxtName.Enabled = status;
            mtxtContact.Enabled = status;
            mtxtEmail.Enabled = status;
            mtxtbday.Enabled = status;
            mbtnChange.Visible = status;
        }

        private void mbtnChange_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openImage.FileName;
            }
        }

        private void mtlEdit_Click(object sender, EventArgs e)
        {
            enableAll(true);
        }

        private void mtlAddUser_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            Hide();
        }

        private void mtlStock_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            Hide();
        }
    }
}