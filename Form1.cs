namespace Stanibogat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game f2 = new Game();
            f2.ShowDialog();
            f2 = null;
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}