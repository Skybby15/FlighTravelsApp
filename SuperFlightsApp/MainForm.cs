using Timer = System.Windows.Forms.Timer;

namespace SuperFlightsApp
{
    public partial class MainForm : Form
    {
        public Point mouseLocation;
        private Timer sidePanelSlideTimer;

        private Form currentFlowPanel;

        public MainForm()
        {
            InitializeComponent();

            sidePanelSlideTimer = new Timer();
            sidePanelSlideTimer.Interval = 12;
            sidePanelSlideTimer.Tick += sidePanelExtend;

            currentFlowPanel = new HomeForm();
            currentFlowPanel.Dock = DockStyle.Fill;
            currentFlowPanel.TopLevel = false;
            flowPanel.Controls.Add(currentFlowPanel);
            flowPanel.Tag = currentFlowPanel;
            currentFlowPanel.Show();

        }

        public void MainForm_Load(EventHandler eh)
        {
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void dragMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menuPanel_Click(sender, e);
        }

        #region Effects

        private void minimizeBox_MouseEnter(object sender, EventArgs e)
        {
            minimizeBox.BackColor = SystemColors.Control;
        }

        private void minimizeBox_MouseLeave(object sender, EventArgs e)
        {
            minimizeBox.BackColor = Color.Transparent;
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBox_MouseEnter(object sender, EventArgs e)
        {
            closeBox.BackColor = SystemColors.Control;
        }

        private void closeBox_MouseHover(object sender, EventArgs e)
        {
            closeBox.BackColor = SystemColors.Control;
        }

        private void closeBox_MouseLeave(object sender, EventArgs e)
        {
            closeBox.BackColor = Color.Transparent;
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeBox_MouseEnter(object sender, EventArgs e)
        {
            maximizeBox.BackColor = SystemColors.Control;
        }

        private void maximizeBox_MouseHover(object sender, EventArgs e)
        {
            maximizeBox.BackColor = SystemColors.Control;
        }

        private void maximizeBox_MouseLeave(object sender, EventArgs e)
        {
            maximizeBox.BackColor = Color.Transparent;
        }

        private void minimizeBox_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeBox.BackColor = Color.Silver;
        }

        private void maximizeBox_MouseDown(object sender, MouseEventArgs e)
        {
            maximizeBox.BackColor = Color.Silver;
        }

        private void closeBox_MouseDown(object sender, MouseEventArgs e)
        {
            closeBox.BackColor = Color.Silver;
        }

        private void maximizeBox_MouseUp(object sender, MouseEventArgs e)
        {
            maximizeBox.BackColor = SystemColors.Control;
        }

        private void minimizeBox_MouseUp(object sender, MouseEventArgs e)
        {
            minimizeBox.BackColor = SystemColors.Control;
        }

        private void closeBox_MouseUp(object sender, MouseEventArgs e)
        {
            closeBox.BackColor = SystemColors.Control;
        }

        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menuPanel_Click(object sender, EventArgs e)
        {
            sidePanelSlideTimer.Start();
        }


        private void sidePanelExtend(object? sender, EventArgs e)
        {
            if (sidePanel.Width >= 200)
            {
                sidePanel.Width = 200;
                sidePanelSlideTimer.Stop();
                sidePanelSlideTimer.Tick -= sidePanelExtend;
                sidePanelSlideTimer.Tick += sidePanelShrink;
            }
            else
            {
                sidePanel.Width = sidePanel.Width + Math.Abs(sidePanel.Width - 200) / 14 + 1;
            }
        }

        private void sidePanelShrink(object? sender, EventArgs e)
        {
            if (sidePanel.Width <= 58)
            {
                sidePanel.Width = 58;
                sidePanelSlideTimer.Stop();
                sidePanelSlideTimer.Tick += sidePanelExtend;
                sidePanelSlideTimer.Tick -= sidePanelShrink;
            }
            else
            {
                sidePanel.Width = sidePanel.Width - Math.Abs(sidePanel.Width - 58) / 14 - 1;
            }
        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            if (flowPanel.Controls[0] is HomeForm)
                return;

            flowPanel.Controls.Remove(currentFlowPanel);
            currentFlowPanel = new HomeForm();
            currentFlowPanel.Dock = DockStyle.Fill;
            currentFlowPanel.TopLevel = false;
            flowPanel.Controls.Add(currentFlowPanel);
            flowPanel.Tag = currentFlowPanel;
            currentFlowPanel.Show();

        }

        private void flightsPanel_Click(object sender, EventArgs e)
        {
            if (flowPanel.Controls[0] is FlightsForm)
                return;
            flowPanel.Controls.Remove(currentFlowPanel);
            currentFlowPanel = new FlightsForm();
            currentFlowPanel.Dock = DockStyle.Fill;
            currentFlowPanel.TopLevel = false;
            flowPanel.Controls.Add(currentFlowPanel);
            flowPanel.Tag = currentFlowPanel;
            currentFlowPanel.Show();

        }

        private void ticketsPanel_Click(object sender, EventArgs e)
        {
            if (flowPanel.Controls[0] is TicketsForm)
                return;
            flowPanel.Controls.Remove(currentFlowPanel);
            currentFlowPanel = new TicketsForm();
            currentFlowPanel.Dock = DockStyle.Fill;
            currentFlowPanel.TopLevel = false;
            flowPanel.Controls.Add(currentFlowPanel);
            flowPanel.Tag = currentFlowPanel;
            currentFlowPanel.Show();

        }

        private void faqPanel_Click(object sender, EventArgs e)
        {
            if (flowPanel.Controls[0] is FAQForm)
                return;
            flowPanel.Controls.Remove(currentFlowPanel);
            currentFlowPanel = new FAQForm();
            currentFlowPanel.Dock = DockStyle.Fill;
            currentFlowPanel.TopLevel = false;
            flowPanel.Controls.Add(currentFlowPanel);
            flowPanel.Tag = currentFlowPanel;
            currentFlowPanel.Show();

        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {

        }

        private void homePanel_MouseEnter(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.Silver;
        }

        private void homePanel_MouseLeave(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.Gray;
        }
    }

}
