///This program was created by Alyssa Pogson
///on May 25 2018
///to provide a way for clients to check inventory securely 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSW_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //change user control
            LoginScreen ls = new LoginScreen();
            this.Controls.Add(ls);
            ls.Location = new Point((this.Width - ls.Width) / 2, (this.Height - ls.Height) / 2);
        }
    }
}
