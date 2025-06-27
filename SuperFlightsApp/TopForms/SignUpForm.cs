using SuperFlightsApp.Model;
using SuperFlightsApp.Services;

namespace SuperFlightsApp.TopForms
{
    public partial class SignUpForm : Form
    {
        bool passShown = false;
        bool verifShown = false;

        Service service;
        Form loginForm;

        public Point mouseLocation;

        public SignUpForm(Service service, Form parentForm)
        {
            this.service = service;
            this.loginForm = parentForm;
            InitializeComponent();

            passwordBox.TextChanged += (s,e) => passwordBox.ForeColor = Color.Black;
            verifyBox.TextChanged += (s, e) => verifyBox.ForeColor = Color.Black;
        }

        private void showPassPic_Click(object sender, EventArgs e)
        {
            if (passShown)
            {
                passShown = false;
                showPassPic.Image = Properties.Resources.showPass;
                passwordBox.PasswordChar = '*';
            }
            else
            {
                passShown = true;
                showPassPic.Image = Properties.Resources.hidePass;
                passwordBox.PasswordChar = '\0';
            }
        }

        private void showVerifyPic_Click(object sender, EventArgs e)
        {
            if (verifShown)
            {
                verifShown = false;
                showVerifyPic.Image = Properties.Resources.showPass;
                verifyBox.PasswordChar = '*';
            }
            else
            {
                verifShown = true;
                showVerifyPic.Image = Properties.Resources.hidePass;
                verifyBox.PasswordChar = '\0';
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (!allFieldsFilled())
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!verifyBox.Text.Equals(passwordBox.Text))
            {
                passwordBox.ForeColor = Color.Red;
                verifyBox.ForeColor = Color.Red;
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try { 

                    User signing = new User(0, firstNameBox.Text, lastNameBox.Text, emailBox.Text, passwordBox.Text, null, null);
                    service.SignUp(signing);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Account created Succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backButton_Click(sender, e);
                return;
            }


        }

        private bool allFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameBox.Text) ||
                string.IsNullOrWhiteSpace(emailBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text) ||
                string.IsNullOrWhiteSpace(verifyBox.Text))
            {
                return false;
            }
            return true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.FormClosed -= (s, args) => loginForm.Close();
            loginForm.FormClosed -= (s, args) => this.Close();

            this.Hide();

            loginForm.Show();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
