///This program was created by Alyssa Pogson
///on May 25 2018
///to provide a way for clients to check inventory securely 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSW_Inventory
{
    public partial class LoginScreen : UserControl
    {
        //declare variables
        string username;
        string password;
        public static string company;

        public LoginScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets enter press to activate loginButton.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                loginButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            checkCredentials();
        }

        /// <summary>
        /// Checks for correct username and password combinations.
        /// </summary>
        private void checkCredentials()
        {
            //store entered credentials in variables and ensure errorLabel is invisible
            username = userBox.Text;
            password = passBox.Text;
            errorLabel.Visible = false;

            //check for correct combinations
            if (username == "betterhockey" && password == "greenbiscuit342")
            {
                company = "BH";
                ChangeScreen();
            }
            else if (username == "ecosmart")
            {
                company = "ES";
                ChangeScreen();
            }
            else if (username == "omegapaw" && password == "mouse12")
            {
                company = "OP";
                ChangeScreen();
            }
            else if (username == "ontherighttrack" && password == "jumprocket912")
            {
                company = "OTRT";
                ChangeScreen();
            }
            else if (username == "phileolesaffre" && password == "yeast305")
            {
                company = "PL";
                ChangeScreen();
            }
            else if (username == "samsung" && password == "resin160")
            {
                company = "SS";
                ChangeScreen();
            }
            else if (username == "blank" && password == "blank")
            {
                company = "OTRT";
                ChangeScreen();
            }
            else
            {
                errorLabel.Visible = true;
                userBox.Clear();
                passBox.Clear();
            }
        }

        /// <summary>
        /// Changes the user control to InventoryScreen.
        /// </summary>
        public void ChangeScreen()
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            InventoryScreen vs = new InventoryScreen();
            f.Controls.Add(vs);
        }
    }
}
