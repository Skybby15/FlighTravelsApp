namespace SuperFlightsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dragPanel = new Panel();
            label2 = new Label();
            topMenuPanel = new Panel();
            minimizeBox = new PictureBox();
            maximizeBox = new PictureBox();
            closeBox = new PictureBox();
            sidePanel = new Panel();
            faqPanel = new Panel();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            settingsPanel = new Panel();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            ticketsPanel = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            flightsPanel = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            homePanel = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            menuPanel = new Panel();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            flowPanel = new Panel();
            dragPanel.SuspendLayout();
            topMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            sidePanel.SuspendLayout();
            faqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ticketsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flightsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // dragPanel
            // 
            dragPanel.BackColor = Color.White;
            dragPanel.Controls.Add(label2);
            dragPanel.Location = new Point(0, 0);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(939, 50);
            dragPanel.TabIndex = 7;
            dragPanel.MouseDown += dragPanel_MouseDown;
            dragPanel.MouseMove += dragMenu_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            // 
            // topMenuPanel
            // 
            topMenuPanel.BackColor = Color.White;
            topMenuPanel.Controls.Add(minimizeBox);
            topMenuPanel.Controls.Add(maximizeBox);
            topMenuPanel.Controls.Add(closeBox);
            topMenuPanel.Location = new Point(938, 0);
            topMenuPanel.Name = "topMenuPanel";
            topMenuPanel.Size = new Size(171, 50);
            topMenuPanel.TabIndex = 0;
            // 
            // minimizeBox
            // 
            minimizeBox.BorderStyle = BorderStyle.FixedSingle;
            minimizeBox.Image = (Image)resources.GetObject("minimizeBox.Image");
            minimizeBox.Location = new Point(14, 5);
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
            maximizeBox.Location = new Point(64, 5);
            maximizeBox.Name = "maximizeBox";
            maximizeBox.Size = new Size(44, 39);
            maximizeBox.SizeMode = PictureBoxSizeMode.Zoom;
            maximizeBox.TabIndex = 1;
            maximizeBox.TabStop = false;
            maximizeBox.MouseDown += maximizeBox_MouseDown;
            maximizeBox.MouseEnter += maximizeBox_MouseEnter;
            maximizeBox.MouseLeave += maximizeBox_MouseLeave;
            maximizeBox.MouseUp += maximizeBox_MouseUp;
            // 
            // closeBox
            // 
            closeBox.BorderStyle = BorderStyle.FixedSingle;
            closeBox.Image = Properties.Resources.close;
            closeBox.Location = new Point(114, 5);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(44, 39);
            closeBox.SizeMode = PictureBoxSizeMode.Zoom;
            closeBox.TabIndex = 0;
            closeBox.TabStop = false;
            closeBox.Click += closeBox_Click;
            closeBox.MouseDown += closeBox_MouseDown;
            closeBox.MouseEnter += closeBox_MouseEnter;
            closeBox.MouseLeave += closeBox_MouseLeave;
            closeBox.MouseUp += closeBox_MouseUp;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(23, 24, 29);
            sidePanel.Controls.Add(faqPanel);
            sidePanel.Controls.Add(settingsPanel);
            sidePanel.Controls.Add(ticketsPanel);
            sidePanel.Controls.Add(flightsPanel);
            sidePanel.Controls.Add(homePanel);
            sidePanel.Controls.Add(menuPanel);
            sidePanel.Location = new Point(0, 50);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(58, 544);
            sidePanel.TabIndex = 9;
            // 
            // faqPanel
            // 
            faqPanel.BackColor = Color.Gray;
            faqPanel.BorderStyle = BorderStyle.Fixed3D;
            faqPanel.Controls.Add(label6);
            faqPanel.Controls.Add(pictureBox5);
            faqPanel.Cursor = Cursors.Hand;
            faqPanel.Location = new Point(0, 186);
            faqPanel.Name = "faqPanel";
            faqPanel.Size = new Size(206, 45);
            faqPanel.TabIndex = 11;
            faqPanel.Click += faqPanel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 9);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 1;
            label6.Text = "FAQ";
            label6.Click += faqPanel_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.FAQ;
            pictureBox5.Location = new Point(7, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += faqPanel_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.BackColor = Color.Gray;
            settingsPanel.BorderStyle = BorderStyle.Fixed3D;
            settingsPanel.Controls.Add(label7);
            settingsPanel.Controls.Add(pictureBox3);
            settingsPanel.Cursor = Cursors.Hand;
            settingsPanel.Location = new Point(0, 499);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(206, 45);
            settingsPanel.TabIndex = 15;
            settingsPanel.Click += settingsPanel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 11);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 14;
            label7.Text = "SETTINGS";
            label7.Click += settingsPanel_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.settings;
            pictureBox3.Location = new Point(10, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += settingsPanel_Click;
            // 
            // ticketsPanel
            // 
            ticketsPanel.BackColor = Color.Gray;
            ticketsPanel.BorderStyle = BorderStyle.Fixed3D;
            ticketsPanel.Controls.Add(label5);
            ticketsPanel.Controls.Add(pictureBox2);
            ticketsPanel.Cursor = Cursors.Hand;
            ticketsPanel.Location = new Point(0, 143);
            ticketsPanel.Name = "ticketsPanel";
            ticketsPanel.Size = new Size(206, 45);
            ticketsPanel.TabIndex = 14;
            ticketsPanel.Click += ticketsPanel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 10);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "YOUR TICKETS";
            label5.Click += ticketsPanel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.flightTicket;
            pictureBox2.Location = new Point(7, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += ticketsPanel_Click;
            // 
            // flightsPanel
            // 
            flightsPanel.BackColor = Color.Gray;
            flightsPanel.BorderStyle = BorderStyle.Fixed3D;
            flightsPanel.Controls.Add(label4);
            flightsPanel.Controls.Add(pictureBox4);
            flightsPanel.Cursor = Cursors.Hand;
            flightsPanel.Location = new Point(0, 100);
            flightsPanel.Name = "flightsPanel";
            flightsPanel.Size = new Size(206, 45);
            flightsPanel.TabIndex = 11;
            flightsPanel.Click += flightsPanel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 11);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 15;
            label4.Text = "FLIGHTS";
            label4.Click += flightsPanel_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.plane;
            pictureBox4.Location = new Point(7, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += flightsPanel_Click;
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.Gray;
            homePanel.BorderStyle = BorderStyle.Fixed3D;
            homePanel.Controls.Add(label3);
            homePanel.Controls.Add(pictureBox1);
            homePanel.Cursor = Cursors.Hand;
            homePanel.Location = new Point(0, 57);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(206, 45);
            homePanel.TabIndex = 11;
            homePanel.Click += homePanel_Click;
            homePanel.MouseEnter += homePanel_MouseEnter;
            homePanel.MouseLeave += homePanel_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 11);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "HOME";
            label3.Click += homePanel_Click;
            label3.MouseEnter += homePanel_MouseEnter;
            label3.MouseLeave += homePanel_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += homePanel_Click;
            pictureBox1.MouseEnter += homePanel_MouseEnter;
            pictureBox1.MouseLeave += homePanel_MouseLeave;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(23, 24, 29);
            menuPanel.BorderStyle = BorderStyle.Fixed3D;
            menuPanel.Controls.Add(pictureBox6);
            menuPanel.Controls.Add(label1);
            menuPanel.Cursor = Cursors.Hand;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(206, 57);
            menuPanel.TabIndex = 10;
            menuPanel.Click += menuPanel_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.menu_white_50;
            pictureBox6.Location = new Point(11, 11);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += menuPanel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(94, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.Click += label1_Click;
            // 
            // flowPanel
            // 
            flowPanel.BackColor = SystemColors.Control;
            flowPanel.Location = new Point(59, 50);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1049, 543);
            flowPanel.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 593);
            Controls.Add(topMenuPanel);
            Controls.Add(sidePanel);
            Controls.Add(dragPanel);
            Controls.Add(flowPanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Main Form";
            dragPanel.ResumeLayout(false);
            dragPanel.PerformLayout();
            topMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minimizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            sidePanel.ResumeLayout(false);
            faqPanel.ResumeLayout(false);
            faqPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ticketsPanel.ResumeLayout(false);
            ticketsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flightsPanel.ResumeLayout(false);
            flightsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel dragPanel;
        private Panel topMenuPanel;
        private Panel sidePanel;
        private Panel menuPanel;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox closeBox;
        private PictureBox minimizeBox;
        private PictureBox maximizeBox;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel homePanel;
        private Panel flightsPanel;
        private Panel ticketsPanel;
        private Panel settingsPanel;
        private Panel faqPanel;
        private PictureBox pictureBox5;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Panel flowPanel;
        private Label label3;
        private PictureBox pictureBox6;
    }
}
