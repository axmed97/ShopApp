using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcWelcome.Location = new Point((pcWelcome.Parent.ClientSize.Width - pcWelcome.ClientSize.Width) / 2,
                (pcWelcome.Parent.ClientSize.Height - pcWelcome.ClientSize.Height) / 2
                );
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
