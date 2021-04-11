using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Lincoln;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Mutli_Login
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            mtxtUsername.Focus();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
        }




        private String dataEncryption(String inputPassword)
        {
            //create an instance of SHA1CryptoServiceProvider and it is refered by sha.
            SHA1 sha = new SHA1CryptoServiceProvider();

            //computeHash will compute the hash value for specified byte array.
            /*Encodeing.UTF8:-
                This property returns a UTF8Encoding object that encodes Unicode (UTF-16-encoded) characters into a 
                sequence of one to four bytes per character
            */
            byte[] temp = sha.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < temp.Length; i++)
            {
                sb.Append(temp[i].ToString("x2"));
            }
            string password = sb.ToString();

            return password;
        }




        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                
                SqlCommand comd = new SqlCommand("select * from [users] where [username] = @userna and [password] = @pwd;", conn);
                comd.Parameters.AddWithValue("@userna", mtxtUsername.Text);
                //comd.Parameters.AddWithValue("@pwd", mtxtPassword.Text);
                comd.Parameters.AddWithValue("@pwd", dataEncryption(mtxtPassword.Text));
                
                SqlDataReader dr = comd.ExecuteReader();

                if (dr.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this, "OK", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Next n = new Next(mtxtUsername.Text);
                    n.Show();
                    Hide();
                    
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, mtxtUsername.Text, "Invalid User", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    conn.Close();
                    mtxtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message.ToString());
            }
        }

        private void mtxtPassword_TextChanged(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = mbtnLogin;
        }
    }
}