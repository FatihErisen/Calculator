namespace Calculator
{
    public partial class Form1 : Form
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Operator { get; set; }
        double sonuc { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScreen.Text ="0";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
            {
                lblScreen.Text = "1";
                sonuc = 0;
            }
            else
                lblScreen.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
            {
                lblScreen.Text = "2";
                sonuc = 0;
            }
            else
                lblScreen.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
                {
                lblScreen.Text = "3";
                sonuc = 0;
            }
            else
                lblScreen.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
                {
                lblScreen.Text = "4";
                sonuc = 0;
            }
            else
                lblScreen.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
                {
                lblScreen.Text = "5";
                sonuc = 0;
            }
            else
                lblScreen.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
                {
                lblScreen.Text = "6";
                sonuc = 0;
            }
            else
                lblScreen.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
                {
                lblScreen.Text = "7";
                sonuc = 0;
            }
            else
                lblScreen.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
                {
                lblScreen.Text = "8";
                sonuc = 0;
            }
            else
                lblScreen.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == "0")
            {
                lblScreen.Text = "9";
                sonuc = 0;
            }
            else
                lblScreen.Text += "9";
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text != "0")
            { 
                lblScreen.Text = "0";
                Operator = "";
                FirstNumber = 0;
                SecondNumber= 0;

            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text != "0" || sonuc != 0)
                lblScreen.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!lblScreen.Text.Contains("."))
                lblScreen.Text += ".";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblScreen.Text);
            Operator = "*";
            lblScreen.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(lblScreen.Text);
            Operator = "/";
            lblScreen.Text = "0";

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
                FirstNumber = Convert.ToDouble(lblScreen.Text);
                Operator = "+";
                lblScreen.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
                FirstNumber = Convert.ToDouble(lblScreen.Text);
                Operator = "-";
                lblScreen.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(lblScreen.Text);
            if (Operator== "-") { 
                sonuc= FirstNumber - SecondNumber;
                FirstNumber = sonuc;
                lblScreen.Text = Convert.ToString(sonuc);
            }
            else if (Operator== "+") { 
                sonuc= SecondNumber + FirstNumber;
                //FirstNumber = sonuc;
                lblScreen.Text = Convert.ToString(sonuc);
            }
            else if (Operator== "*") { 
                sonuc = SecondNumber * FirstNumber;
                FirstNumber = sonuc;
                lblScreen.Text = Convert.ToString(sonuc);
            }
            else if (Operator== "/")
            {
                if (SecondNumber==0) { lblScreen.Text = "EROR"; }
                else {
                    sonuc = FirstNumber / SecondNumber;
                    FirstNumber = sonuc;
                    lblScreen.Text = Convert.ToString(sonuc);
                }

            }
           
        }
    }
}