using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperFlightsApp.Model;
using SuperFlightsApp.Services;

namespace SuperFlightsApp.TopForms
{
    public partial class LoginForm : Form
    {
        private readonly Service service;

        public Point mouseLocation;

        public SignUpForm signUpForm;
        public MainForm mainForm;

        public LoginForm(Service service)
        {
            this.service = service;

            InitializeComponent();

            emailTextBox.TextChanged += (s, e) => emailTextBox.ForeColor = Color.Black;
            passwordTextBox.TextChanged += (s, e) => passwordTextBox.ForeColor = Color.Black;
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        #region Effects

        private void minimizeBox_MouseEnter(object sender, EventArgs e)
        {
            minimizeBox.BackColor = SystemColors.Control;
        }

        private void minimizeBox_MouseLeave(object sender, EventArgs e)
        {
            minimizeBox.BackColor = Color.Transparent;
        }

        private void closeBox_MouseEnter(object sender, EventArgs e)
        {
            closeBox.BackColor = SystemColors.Control;
        }

        private void closeBox_MouseHover(object sender, EventArgs e)
        {
            closeBox.BackColor = SystemColors.Control;
        }

        private void closeBox_MouseLeave(object sender, EventArgs e)
        {
            closeBox.BackColor = Color.Transparent;
        }

        private void maximizeBox_MouseEnter(object sender, EventArgs e)
        {
            maximizeBox.BackColor = SystemColors.Control;
        }

        private void maximizeBox_MouseHover(object sender, EventArgs e)
        {
            maximizeBox.BackColor = SystemColors.Control;
        }

        private void maximizeBox_MouseLeave(object sender, EventArgs e)
        {
            maximizeBox.BackColor = Color.Transparent;
        }

        private void minimizeBox_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeBox.BackColor = Color.Silver;
        }

        private void maximizeBox_MouseDown(object sender, MouseEventArgs e)
        {
            maximizeBox.BackColor = Color.Silver;
        }

        private void closeBox_MouseDown(object sender, MouseEventArgs e)
        {
            closeBox.BackColor = Color.Silver;
        }

        private void maximizeBox_MouseUp(object sender, MouseEventArgs e)
        {
            maximizeBox.BackColor = SystemColors.Control;
        }

        private void minimizeBox_MouseUp(object sender, MouseEventArgs e)
        {
            minimizeBox.BackColor = SystemColors.Control;
        }

        private void closeBox_MouseUp(object sender, MouseEventArgs e)
        {
            closeBox.BackColor = SystemColors.Control;
        }

        #endregion

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            if(mainForm == null)
                mainForm = new MainForm(service,this,null);

            mainForm.FormClosed += (s, args) => this.Close();

            this.Hide();
            mainForm.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (signUpForm == null)
                signUpForm = new SignUpForm(service, this);
            else
                this.FormClosed -= (s, args) => signUpForm.Close();
            signUpForm.FormClosed += (s, args) => this.Close();

            this.Hide();
            signUpForm.Show();
        }

        private bool allFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!allFieldsFilled())
                    throw new Exception("Please fill in all fields.");
                User loggedUser = new User(0, null, null, emailTextBox.Text, passwordTextBox.Text, null, null);
                service.Login(loggedUser); // service will have to return the user object with full info
                if (mainForm == null)
                    mainForm = new MainForm(service,this, loggedUser);
                else
                    mainForm.LoggedUser = loggedUser;
                mainForm.FormClosed += (s, args) => this.Close();

                this.Hide();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
