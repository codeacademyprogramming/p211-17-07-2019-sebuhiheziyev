using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work_17_07_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            #region Dynamc Welcom Name Change
            //erroru gizlemek
            lblError.Visible = false;
            string username = txtUsername.Text;
            if(username.Trim() == string.Empty)
            {
                lblWelcom.Text = $"Welcome, honey";

            }
            else
            {
                lblWelcom.Text = $"Welcome, {username}";

            }

            #endregion

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();

            if (username == "sebuhi" && password == "sebuhi2002")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else if (username == "" || password == "")
            {
                MessageBox.Show("Butun Xanalari Doldurun", "Info", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Daxil Etdiyniz Melumatlar Sefdi", "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error );
                lblError.Text = "Username or password is invalid!";
                lblError.Visible = true;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
