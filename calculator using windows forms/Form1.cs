namespace calculator_using_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string operation;
        int result;


        private void btn1_Click_1(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear() ;
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (operation.Equals("+"))
                result = num1 + num2;
            if (operation.Equals("-"))
                result = num1 - num2;
            if(operation.Equals("*"))
                result = num1 * num2;
            if( operation.Equals("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";
        }
    }
}


