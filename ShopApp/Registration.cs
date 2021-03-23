using ShopApp.Models;
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
    public partial class Registration : Form
    {
        ShopDbEntities _context = new ShopDbEntities();
        public Registration()
        {
            InitializeComponent();
        }

        private void ClearAllField()
        {
            txtConPassword.Text = txtFullname.Text = txtPassword.Text = txtUsername.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string conPassword = txtConPassword.Text;
            string[] array = { fullname, username, password, conPassword };
            if (Utilities.IsEmpty(array, string.Empty))
            {
                Worker selectedWorker = _context.Workers.FirstOrDefault(w => w.Username == username);
                if (selectedWorker == null)
                {
                    if (password == conPassword)
                    {
                        lblError.Visible = false;
                        Worker worker = new Worker();
                        worker.Fullname = fullname;
                        worker.Username = username;
                        worker.Password = password.HashCode();
                        _context.Workers.Add(worker);
                        _context.SaveChanges();
                        ClearAllField();
                        MessageBox.Show($"User {username} registreted successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "Password or Confirm Password is not the same!";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Username already exist!";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please fill all field!";
                lblError.Visible = true;
            }
        }
    }
}
