using System.Diagnostics.Eventing.Reader;

namespace tekmiciftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(textBox1.Text);
            if (x % 2 == 0)
            {
                MessageBox.Show("ÇÝFT");

            }
            else
                MessageBox.Show("TEK");

        }
    }
}
