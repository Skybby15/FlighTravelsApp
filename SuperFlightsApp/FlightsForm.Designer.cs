namespace SuperFlightsApp
{
    partial class FlightsForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            flightsFlowPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(248, 41);
            label1.TabIndex = 0;
            label1.Text = "Search a Flight";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(526, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(421, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(719, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(729, 61);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 6;
            label2.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 187);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 7;
            label3.Text = "Departure date";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(755, 142);
            numericUpDown1.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 27);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 99, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(682, 145);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 9;
            label4.Text = "Seats :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 145);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 10;
            label5.Text = "To :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 145);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "From :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(228, 270);
            label7.Name = "label7";
            label7.Size = new Size(54, 22);
            label7.TabIndex = 13;
            label7.Text = "Flights";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flightsFlowPanel);
            panel1.Location = new Point(186, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 261);
            panel1.TabIndex = 14;
            // 
            // flightsFlowPanel
            // 
            flightsFlowPanel.BackColor = Color.White;
            flightsFlowPanel.Location = new Point(78, -1);
            flightsFlowPanel.Name = "flightsFlowPanel";
            flightsFlowPanel.Size = new Size(530, 261);
            flightsFlowPanel.TabIndex = 0;
            // 
            // FlightsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 543);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightsForm";
            Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private FlowLayoutPanel flightsFlowPanel;
    }
}