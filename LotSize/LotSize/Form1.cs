namespace LotSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Z = (((int.Parse(n_equity.Text)*int.Parse(ICS_FLOATRISK.Value.ToString())) / 100)*ICS_FIXRISK.Value / int.Parse(Pipamount.Text));
            label6.Text = Z.ToString("N2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
