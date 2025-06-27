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
            popularFlightsPanel = new FlowLayoutPanel();
            nextFlightsPanel = new FlowLayoutPanel();
            pastFlightsPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
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
            welcomeLabel.Location = new Point(52, 46);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(327, 41);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome , Traveler !";
            // 
            // popularLabel
            // 
            popularLabel.AutoSize = true;
            popularLabel.BackColor = Color.Transparent;
            popularLabel.BorderStyle = BorderStyle.FixedSingle;
            popularLabel.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            popularLabel.ForeColor = Color.Black;
            popularLabel.Location = new Point(191, 174);
            popularLabel.Name = "popularLabel";
            popularLabel.Size = new Size(269, 23);
            popularLabel.TabIndex = 1;
            popularLabel.Text = "Today's most popular destinations";
            // 
            // pastLabel
            // 
            pastLabel.AutoSize = true;
            pastLabel.BackColor = Color.Transparent;
            pastLabel.BorderStyle = BorderStyle.FixedSingle;
            pastLabel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pastLabel.ForeColor = Color.Black;
            pastLabel.Location = new Point(785, 244);
            pastLabel.Name = "pastLabel";
            pastLabel.Size = new Size(118, 20);
            pastLabel.TabIndex = 2;
            pastLabel.Text = "Your past flights";
            // 
            // nextLabel
            // 
            nextLabel.AutoSize = true;
            nextLabel.BackColor = Color.Transparent;
            nextLabel.BorderStyle = BorderStyle.FixedSingle;
            nextLabel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextLabel.ForeColor = Color.Black;
            nextLabel.Location = new Point(788, 35);
            nextLabel.Name = "nextLabel";
            nextLabel.Size = new Size(110, 20);
            nextLabel.TabIndex = 3;
            nextLabel.Text = "Your next flight";
            // 
            // popularFlightsPanel
            // 
            popularFlightsPanel.BorderStyle = BorderStyle.FixedSingle;
            popularFlightsPanel.FlowDirection = FlowDirection.TopDown;
            popularFlightsPanel.Location = new Point(127, 187);
            popularFlightsPanel.Name = "popularFlightsPanel";
            popularFlightsPanel.Size = new Size(387, 295);
            popularFlightsPanel.TabIndex = 4;
            // 
            // nextFlightsPanel
            // 
            nextFlightsPanel.BorderStyle = BorderStyle.FixedSingle;
            nextFlightsPanel.FlowDirection = FlowDirection.TopDown;
            nextFlightsPanel.Location = new Point(683, 46);
            nextFlightsPanel.Name = "nextFlightsPanel";
            nextFlightsPanel.Size = new Size(308, 169);
            nextFlightsPanel.TabIndex = 5;
            // 
            // pastFlightsPanel
            // 
            pastFlightsPanel.BorderStyle = BorderStyle.FixedSingle;
            pastFlightsPanel.FlowDirection = FlowDirection.TopDown;
            pastFlightsPanel.Location = new Point(683, 257);
            pastFlightsPanel.Name = "pastFlightsPanel";
            pastFlightsPanel.Size = new Size(308, 248);
            pastFlightsPanel.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(730, 100);
            label1.MaximumSize = new Size(220, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 40);
            label1.TabIndex = 0;
            label1.Text = "You need to be logged in to be able to see your next flight";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(730, 348);
            label2.MaximumSize = new Size(220, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 40);
            label2.TabIndex = 7;
            label2.Text = "You need to be logged in to be able to see your past flights";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(782, 166);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 8;
            button1.Text = "Buy a Flight!";
            button1.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1049, 543);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pastLabel);
            Controls.Add(nextLabel);
            Controls.Add(pastFlightsPanel);
            Controls.Add(nextFlightsPanel);
            Controls.Add(popularLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(popularFlightsPanel);
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
        private FlowLayoutPanel popularFlightsPanel;
        private FlowLayoutPanel nextFlightsPanel;
        private FlowLayoutPanel pastFlightsPanel;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}