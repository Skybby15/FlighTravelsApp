namespace SuperFlightsApp.TopForms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            dragPanel = new Panel();
            label2 = new Label();
            minimizeBox = new PictureBox();
            maximizeBox = new PictureBox();
            closeBox = new PictureBox();
            signUpButton = new Button();
            backButton = new Button();
            verifyBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            showPassPic = new PictureBox();
            showVerifyPic = new PictureBox();
            dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showVerifyPic).BeginInit();
            SuspendLayout();
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(44, 135);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(144, 27);
            firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(250, 135);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(144, 27);
            lastNameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(103, 193);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(242, 27);
            emailBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(51, 253);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(262, 27);
            passwordBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 64);
            label1.Name = "label1";
            label1.Size = new Size(280, 20);
            label1.TabIndex = 4;
            label1.Text = "Please fill in all boxes in order to sign up.";
            // 
            // dragPanel
            // 
            dragPanel.BackColor = Color.White;
            dragPanel.Controls.Add(label2);
            dragPanel.Controls.Add(minimizeBox);
            dragPanel.Controls.Add(maximizeBox);
            dragPanel.Controls.Add(closeBox);
            dragPanel.Location = new Point(0, 0);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(429, 50);
            dragPanel.TabIndex = 5;
            dragPanel.MouseDown += dragPanel_MouseDown;
            dragPanel.MouseMove += dragPanel_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 3;
            label2.Text = "Sign Up";
            // 
            // minimizeBox
            // 
            minimizeBox.BorderStyle = BorderStyle.FixedSingle;
            minimizeBox.Image = (Image)resources.GetObject("minimizeBox.Image");
            minimizeBox.Location = new Point(278, 5);
            minimizeBox.Name = "minimizeBox";
            minimizeBox.Size = new Size(44, 39);
            minimizeBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeBox.TabIndex = 2;
            minimizeBox.TabStop = false;
            minimizeBox.MouseDown += minimizeBox_MouseDown;
            minimizeBox.MouseEnter += minimizeBox_MouseEnter;
            minimizeBox.MouseLeave += minimizeBox_MouseLeave;
            minimizeBox.MouseUp += minimizeBox_MouseUp;
            // 
            // maximizeBox
            // 
            maximizeBox.BorderStyle = BorderStyle.FixedSingle;
            maximizeBox.Image = Properties.Resources.fullScreen;
            maximizeBox.Location = new Point(328, 5);
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
            closeBox.Location = new Point(378, 5);
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
            // signUpButton
            // 
            signUpButton.Location = new Point(108, 369);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(225, 31);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 409);
            backButton.Name = "backButton";
            backButton.Size = new Size(58, 29);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // verifyBox
            // 
            verifyBox.Location = new Point(51, 306);
            verifyBox.Name = "verifyBox";
            verifyBox.PasswordChar = '*';
            verifyBox.Size = new Size(262, 27);
            verifyBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 111);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 111);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 170);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 229);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 283);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 13;
            label7.Text = "Verify Password";
            // 
            // showPassPic
            // 
            showPassPic.Image = Properties.Resources.showPass;
            showPassPic.Location = new Point(328, 253);
            showPassPic.Name = "showPassPic";
            showPassPic.Size = new Size(35, 27);
            showPassPic.SizeMode = PictureBoxSizeMode.Zoom;
            showPassPic.TabIndex = 14;
            showPassPic.TabStop = false;
            showPassPic.Click += showPassPic_Click;
            showPassPic.DoubleClick += showPassPic_Click;
            // 
            // showVerifyPic
            // 
            showVerifyPic.Image = Properties.Resources.showPass;
            showVerifyPic.Location = new Point(328, 306);
            showVerifyPic.Name = "showVerifyPic";
            showVerifyPic.Size = new Size(35, 27);
            showVerifyPic.SizeMode = PictureBoxSizeMode.Zoom;
            showVerifyPic.TabIndex = 15;
            showVerifyPic.TabStop = false;
            showVerifyPic.Click += showVerifyPic_Click;
            showVerifyPic.DoubleClick += showVerifyPic_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(showVerifyPic);
            Controls.Add(showPassPic);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(verifyBox);
            Controls.Add(backButton);
            Controls.Add(signUpButton);
            Controls.Add(dragPanel);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            dragPanel.ResumeLayout(false);
            dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)showVerifyPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Label label1;
        private Panel dragPanel;
        private Label label2;
        private PictureBox minimizeBox;
        private PictureBox maximizeBox;
        private PictureBox closeBox;
        private Button signUpButton;
        private Button backButton;
        private TextBox verifyBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox showPassPic;
        private PictureBox showVerifyPic;
    }
}