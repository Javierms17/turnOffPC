namespace turnOffPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numericUpDownValue = (int)numericUpDown1.Value;
            trurnOffController turnOffController = new trurnOffController();
            turnOffController.turnOffPC(numericUpDownValue);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            trurnOffController turnOffController = new trurnOffController();
            turnOffController.cancelTurnOffPC();
        }
    }
}