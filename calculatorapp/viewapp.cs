namespace calculatorapp
{
    public partial class viewapp : Form
    {
        private float _firstValue = 0;
        private float _secondValue = 0;
        private float _result = 0;
        private string _operator = "+";


        public void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

                updateTxtBox(button.Text);
            
        }



        public void updateTxtBox(string buttonText)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = buttonText;
            }
            else
            {
                TextBox.Text += buttonText;
            }
        }

        public viewapp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void Operation_Update(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation_Click(button.Text);
        }


        public void Operation_Click(string opsButton)
        {
            float numb;
            string value = TextBox.Text;
            if (float.TryParse(value, out numb))
            {
                _firstValue = float.Parse(TextBox.Text);
                TextBox.Clear();
            }
            else
            {
                TextBox.Text = "Please provide a number";
            }
            
            _operator = opsButton;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

            TextBox.Clear();
            _firstValue = 0;
            _secondValue = 0;

        }

       

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            switch (_operator)
            {
                case "+":
                    _secondValue = float.Parse(TextBox.Text);
                    _result = _firstValue + _secondValue;
                    TextBox.Text = _result.ToString();
                    break;
                case "-":
                    _secondValue = float.Parse(TextBox.Text);
                    _result = _firstValue - _secondValue;
                    TextBox.Text = _result.ToString();
                    break;
                case "*":
                    _secondValue = float.Parse(TextBox.Text);
                    _result = _firstValue * _secondValue;
                    TextBox.Text = _result.ToString();
                    break;
                case "/":
                    _secondValue = float.Parse(TextBox.Text);
                    _result = _firstValue / _secondValue;
                    TextBox.Text = _result.ToString();
                    break;

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains(","))
            {
                TextBox.Text += ",";
            }
        }

        private void plusminusBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains("-"))
            {
                TextBox.Text = TextBox.Text.Trim('-');
            }
            else
            {
                TextBox.Text = "-" + TextBox.Text;
            }    
        }
    }
}