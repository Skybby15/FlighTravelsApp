namespace SuperFlightsApp
{
    partial class FAQForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 0;
            label1.Text = "FAQ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 102);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Question 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 142);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Answer 1 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 237);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Answer 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 197);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 3;
            label5.Text = "Question 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 336);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 6;
            label6.Text = "Answer 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 296);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 5;
            label7.Text = "Question 3";
            // 
            // FAQForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 543);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FAQForm";
            Text = "FAQForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}