namespace SuperFlightsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(EventHandler eh)        
        { 
        }

        
        public void mdi_Click(object s, EventArgs args)
        {
            MiniForm miniForm = new MiniForm();

            miniForm.TopLevel = false;
            miniForm.Dock = DockStyle.Fill;

            panel3.Controls.Add(miniForm);
            panel3.Tag = "childForm";
            miniForm.BringToFront();


            miniForm.Show();

        }
    }

}
