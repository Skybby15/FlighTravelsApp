namespace SuperFlightsApp.TopForms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            minimizeBox = new PictureBox();
            maximizeBox = new PictureBox();
            closeBox = new PictureBox();
            dragPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            guestButton = new Button();
            signUpButton = new Button();
            loginButton = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // minimizeBox
            // 
            minimizeBox.BorderStyle = BorderStyle.FixedSingle;
            minimizeBox.Image = (Image)resources.GetObject("minimizeBox.Image");
            minimizeBox.Location = new Point(368, 5);
            minimizeBox.Name = "minimizeBox";
            minimizeBox.Size = new Size(44, 39);
            minimizeBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeBox.TabIndex = 2;
            minimizeBox.TabStop = false;
            minimizeBox.Click += minimizeBox_Click;
            minimizeBox.MouseDown += minimizeBox_MouseDown;
            minimizeBox.MouseEnter += minimizeBox_MouseEnter;
            minimizeBox.MouseLeave += minimizeBox_MouseLeave;
            minimizeBox.MouseUp += minimizeBox_MouseUp;
            // 
            // maximizeBox
            // 
            maximizeBox.BorderStyle = BorderStyle.FixedSingle;
            maximizeBox.Image = Properties.Resources.fullScreen;
            maximizeBox.Location = new Point(418, 5);
            maximizeBox.Name = "maximizeBox";
            maximizeBox.Size = new Size(44, 39);
            maximizeBox.SizeMode = PictureBoxSizeMode.Zoom;
            maximizeBox.TabIndex = 1;
            maximizeBox.TabStop = false;
            maximizeBox.MouseDown += maximizeBox_MouseDown;
            maximizeBox.MouseEnter += maximizeBox_MouseEnter;
            maximizeBox.MouseLeave += maximizeBox_MouseLeave;
            maximizeBox.MouseHover += maximizeBox_MouseHover;
            maximizeBox.MouseUp += maximizeBox_MouseUp;
            // 
            // closeBox
            // 
            closeBox.BorderStyle = BorderStyle.FixedSingle;
            closeBox.Image = Properties.Resources.close;
            closeBox.Location = new Point(468, 5);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(44, 39);
            closeBox.SizeMode = PictureBoxSizeMode.Zoom;
            closeBox.TabIndex = 0;
            closeBox.TabStop = false;
            closeBox.Click += closeBox_Click;
            closeBox.MouseDown += closeBox_MouseDown;
            closeBox.MouseEnter += closeBox_MouseEnter;
            closeBox.MouseLeave += closeBox_MouseLeave;
            closeBox.MouseHover += closeBox_MouseHover;
            closeBox.MouseUp += closeBox_MouseUp;
            // 
            // dragPanel
            // 
            dragPanel.BackColor = Color.White;
            dragPanel.Controls.Add(label1);
            dragPanel.Controls.Add(minimizeBox);
            dragPanel.Controls.Add(maximizeBox);
            dragPanel.Controls.Add(closeBox);
            dragPanel.Location = new Point(0, 0);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(521, 50);
            dragPanel.TabIndex = 1;
            dragPanel.MouseDown += dragPanel_MouseDown;
            dragPanel.MouseMove += dragPanel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(198, 97);
            label2.Name = "label2";
            label2.Size = new Size(158, 37);
            label2.TabIndex = 2;
            label2.Text = "FlighTravel";
            // 
            // usernameTextBox
            // 
            emailTextBox.BackColor = SystemColors.Control;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Location = new Point(184, 217);
            emailTextBox.Name = "usernameTextBox";
            emailTextBox.Size = new Size(228, 20);
            emailTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Control;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(184, 304);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(228, 20);
            passwordTextBox.TabIndex = 1;
            // 
            // guestButton
            // 
            guestButton.Location = new Point(368, 421);
            guestButton.Name = "guestButton";
            guestButton.Size = new Size(118, 29);
            guestButton.TabIndex = 3;
            guestButton.Text = "Enter as guest";
            guestButton.UseVisualStyleBackColor = true;
            guestButton.Click += guestButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(380, 477);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(225, 382);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 453);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 8;
            label3.Text = "or";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 391);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account ?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.padlock;
            pictureBox1.Location = new Point(124, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(124, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(123, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(123, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 13;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(signUpButton);
            Controls.Add(guestButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(dragPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)minimizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            dragPanel.ResumeLayout(false);
            dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox minimizeBox;
        private PictureBox maximizeBox;
        private PictureBox closeBox;
        private Panel dragPanel;
        private Label label1;
        private Label label2;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button guestButton;
        private Button signUpButton;
        private Button loginButton;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
    }
}