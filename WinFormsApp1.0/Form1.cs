namespace WinFormsApp1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iReusult = iNum1 + iNum2;

            result.Text = iReusult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iReusult = iNum1 *iNum2;

            result.Text = iReusult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iReusult = iNum1 - iNum2;

            result.Text = iReusult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iReusult = iNum1 /iNum2;

            result.Text = iReusult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
