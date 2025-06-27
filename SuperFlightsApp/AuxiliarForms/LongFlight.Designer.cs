namespace SuperFlightsApp
{
    partial class LongFlight
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
            whitePanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            blackPanel = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            whitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            blackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // whitePanel
            // 
            whitePanel.BorderStyle = BorderStyle.FixedSingle;
            whitePanel.Controls.Add(label3);
            whitePanel.Controls.Add(label2);
            whitePanel.Controls.Add(label1);
            whitePanel.Controls.Add(pictureBox1);
            whitePanel.Location = new Point(0, 0);
            whitePanel.Name = "whitePanel";
            whitePanel.Size = new Size(526, 31);
            whitePanel.TabIndex = 0;
            whitePanel.Click += LongFlight_Click;
            whitePanel.MouseEnter += LongFlight_MouseEnter;
            whitePanel.MouseLeave += LongFlight_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(440, 4);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Seats";
            label3.Click += LongFlight_Click;
            label3.MouseEnter += LongFlight_MouseEnter;
            label3.MouseLeave += LongFlight_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(285, 5);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "To";
            label2.Click += LongFlight_Click;
            label2.MouseEnter += LongFlight_MouseEnter;
            label2.MouseLeave += LongFlight_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(113, 5);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "From";
            label1.Click += LongFlight_Click;
            label1.MouseEnter += LongFlight_MouseEnter;
            label1.MouseLeave += LongFlight_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_flight_dark;
            pictureBox1.Location = new Point(38, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += LongFlight_Click;
            pictureBox1.MouseEnter += LongFlight_MouseEnter;
            pictureBox1.MouseLeave += LongFlight_MouseLeave;
            // 
            // blackPanel
            // 
            blackPanel.BackColor = Color.Black;
            blackPanel.BorderStyle = BorderStyle.FixedSingle;
            blackPanel.Controls.Add(label4);
            blackPanel.Controls.Add(label5);
            blackPanel.Controls.Add(label6);
            blackPanel.Controls.Add(pictureBox2);
            blackPanel.Location = new Point(0, 0);
            blackPanel.Name = "blackPanel";
            blackPanel.Size = new Size(33, 31);
            blackPanel.TabIndex = 8;
            blackPanel.Click += LongFlight_Click;
            blackPanel.MouseEnter += LongFlight_MouseEnter;
            blackPanel.MouseLeave += LongFlight_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(440, 4);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 11;
            label4.Text = "Seats";
            label4.Click += LongFlight_Click;
            label4.MouseEnter += LongFlight_MouseEnter;
            label4.MouseLeave += LongFlight_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(285, 5);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 10;
            label5.Text = "To";
            label5.Click += LongFlight_Click;
            label5.MouseEnter += LongFlight_MouseEnter;
            label5.MouseLeave += LongFlight_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(113, 5);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 9;
            label6.Text = "From";
            label6.Click += LongFlight_Click;
            label6.MouseEnter += LongFlight_MouseEnter;
            label6.MouseLeave += LongFlight_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.flight_white_50;
            pictureBox2.Location = new Point(38, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += LongFlight_Click;
            pictureBox2.MouseEnter += LongFlight_MouseEnter;
            pictureBox2.MouseLeave += LongFlight_MouseLeave;
            // 
            // LongFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(526, 31);
            Controls.Add(blackPanel);
            Controls.Add(whitePanel);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LongFlight";
            Text = "Flight";
            whitePanel.ResumeLayout(false);
            whitePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            blackPanel.ResumeLayout(false);
            blackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel whitePanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel blackPanel;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
    }
}