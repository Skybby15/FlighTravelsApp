using SuperFlightsApp.Overrides;

namespace SuperFlightsApp
{
    partial class HomeForm
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
            welcomeLabel = new RoundedLabel();
            popularLabel = new Label();
            pastLabel = new Label();
            nextLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.CornerRadius = 22;
            welcomeLabel.FlatStyle = FlatStyle.Flat;
            welcomeLabel.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.Black;
            welcomeLabel.Location = new Point(28, 46);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(301, 41);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome , <Name>";
            // 
            // popularLabel
            // 
            popularLabel.AutoSize = true;
            popularLabel.BackColor = Color.Transparent;
            popularLabel.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            popularLabel.ForeColor = Color.Black;
            popularLabel.Location = new Point(191, 174);
            popularLabel.Name = "popularLabel";
            popularLabel.Size = new Size(267, 21);
            popularLabel.TabIndex = 1;
            popularLabel.Text = "Today's most popular destinations";
            // 
            // pastLabel
            // 
            pastLabel.AutoSize = true;
            pastLabel.BackColor = Color.Transparent;
            pastLabel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pastLabel.ForeColor = Color.Black;
            pastLabel.Location = new Point(785, 244);
            pastLabel.Name = "pastLabel";
            pastLabel.Size = new Size(116, 18);
            pastLabel.TabIndex = 2;
            pastLabel.Text = "Your past flights";
            // 
            // nextLabel
            // 
            nextLabel.AutoSize = true;
            nextLabel.BackColor = Color.Transparent;
            nextLabel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextLabel.ForeColor = Color.Black;
            nextLabel.Location = new Point(785, 34);
            nextLabel.Name = "nextLabel";
            nextLabel.Size = new Size(116, 18);
            nextLabel.TabIndex = 3;
            nextLabel.Text = "Your next flights";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(127, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 295);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(708, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 169);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(708, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 248);
            panel3.TabIndex = 6;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1049, 543);
            Controls.Add(pastLabel);
            Controls.Add(nextLabel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(popularLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label popularLabel;
        private Label pastLabel;
        private Label nextLabel;
        private RoundedLabel welcomeLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}