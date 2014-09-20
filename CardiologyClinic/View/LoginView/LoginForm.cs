using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.LoginView
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private LoginController controller;

        public LoginController LoginController
        {
            get { return controller; }
            set { controller = value; }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            controller.TryLogin();
        }

        public String GetPassText()
        {
            return passText.Text;
        }

        public void SetPassText(String pass)
        {
            passText.Text = pass;
        }

        internal void ShowErrorMessage()
        {
            MessageBox.Show(
                "Пользователь с таким паролем не найден!",
                "Пользователь не найден",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
