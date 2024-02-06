using Business;

namespace UI
{
    public partial class Form1 : Form
    {
        private Repair repair;
        public Form1()
        {
            InitializeComponent();
            repair = new Repair();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                int n = int.Parse(textBox1.Text);
                double w = double.Parse(textBox2.Text);
                double l = double.Parse(textBox3.Text);
                double m = double.Parse(textBox4.Text);
                double o = double.Parse(textBox5.Text);

                repair = new Repair(n, w, l, m, o);

                string result = repair.CalculateResponse();

                textBox6.Text = result;
            }
            catch (ArgumentOutOfRangeException ae)
            {
                MessageBox.Show(ae.Message, "Грешка");
            }
        }
    }
}