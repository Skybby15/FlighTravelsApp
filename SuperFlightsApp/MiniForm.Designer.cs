namespace SuperFlightsApp
{
    partial class MiniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniForm));
            dubaiPanel = new Panel();
            dubaiLabel = new Label();
            dubaiPic = new PictureBox();
            dubaiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dubaiPic).BeginInit();
            SuspendLayout();
            // 
            // dubaiPanel
            // 
            dubaiPanel.BackColor = Color.Transparent;
            dubaiPanel.Controls.Add(dubaiLabel);
            dubaiPanel.Controls.Add(dubaiPic);
            dubaiPanel.Location = new Point(122, 64);
            dubaiPanel.Name = "dubaiPanel";
            dubaiPanel.Size = new Size(800, 95);
            dubaiPanel.TabIndex = 0;
            dubaiPanel.MouseEnter += dubaiPanel_MouseEnter;
            dubaiPanel.MouseLeave += dubaiPanel_MouseLeave;
            dubaiPanel.MouseHover += dubaiPanel_MouseHover;
            // 
            // dubaiLabel
            // 
            dubaiLabel.AutoSize = true;
            dubaiLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dubaiLabel.ForeColor = Color.FromArgb(40, 86, 182);
            dubaiLabel.Location = new Point(47, 32);
            dubaiLabel.Name = "dubaiLabel";
            dubaiLabel.Size = new Size(78, 31);
            dubaiLabel.TabIndex = 1;
            dubaiLabel.Text = "Dubai";
            dubaiLabel.MouseEnter += dubaiPanel_MouseEnter;
            dubaiLabel.MouseLeave += dubaiPanel_MouseLeave;
            dubaiLabel.MouseHover += dubaiPanel_MouseHover;
            // 
            // dubaiPic
            // 
            dubaiPic.Dock = DockStyle.Right;
            dubaiPic.Image = (Image)resources.GetObject("dubaiPic.Image");
            dubaiPic.Location = new Point(400, 0);
            dubaiPic.Name = "dubaiPic";
            dubaiPic.Size = new Size(400, 95);
            dubaiPic.SizeMode = PictureBoxSizeMode.CenterImage;
            dubaiPic.TabIndex = 0;
            dubaiPic.TabStop = false;
            dubaiPic.MouseEnter += dubaiPanel_MouseEnter;
            dubaiPic.MouseLeave += dubaiPanel_MouseLeave;
            dubaiPic.MouseHover += dubaiPanel_MouseHover;
            // 
            // MiniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 543);
            Controls.Add(dubaiPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniForm";
            Text = "s";
            dubaiPanel.ResumeLayout(false);
            dubaiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dubaiPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dubaiPanel;
        private PictureBox dubaiPic;
        private Label dubaiLabel;
    }
}