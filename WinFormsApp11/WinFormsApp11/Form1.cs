namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }





        private void rb1_Click(object sender, EventArgs e)
        {

            In_Body in_Body = new In_Body();
            this.Hide();
            in_Body.ShowDialog();
            this.Close();
        }

        private void rb2_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfect_weight perfect_Weight = new perfect_weight();
            perfect_Weight.ShowDialog();
            this.Close();
        }

        private void rb3_Click(object sender, EventArgs e)
        {
            this.Hide();
            calorise_in_food clf = new calorise_in_food();
            clf.ShowDialog();
            this.Close();

        }
    }
}