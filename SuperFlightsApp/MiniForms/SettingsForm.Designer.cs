namespace SuperFlightsApp
{
    partial class SettingsForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Close = new Label();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(444, 436);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(436, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(436, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(260, 13);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 3;
            label1.Text = "Settings";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.arrow_left_white;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Cursor = Cursors.Hand;
            Close.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Close.ForeColor = Color.White;
            Close.Location = new Point(38, 6);
            Close.Name = "Close";
            Close.Size = new Size(42, 20);
            Close.TabIndex = 5;
            Close.Text = "Back";
            Close.Click += pictureBox1_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(444, 466);
            Controls.Add(Close);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "Form1";
            MouseDown += SettingsForm_MouseDown;
            MouseMove += SettingsForm_MouseMove;
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label Close;
    }
}