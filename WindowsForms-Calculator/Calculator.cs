namespace WindowsForms_Calculator
{
    public partial class Calculator : Form
    {
        private Double StoredValue1 = 0;
        private Double StoredValue2 = 0;
        private String StoredOperation = "";
        private bool isOperationStored = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(textBox_MainDisplay.Text == "0" || isOperationStored == true )
            {
                textBox_MainDisplay.Clear();
            }

            if(textBox_MainDisplay.Text.Contains("."))
            {
                btnDecimal.Enabled = false;
            }

            if (Label_StoredDisplay.Text.Contains("="))
            {
                Label_StoredDisplay.Text = "";
                textBox_MainDisplay.Clear();
            }

            Button inputButton = (Button)sender;
            textBox_MainDisplay.Text = textBox_MainDisplay.Text + inputButton.Text;
            isOperationStored = false;
            btnEquals.Focus();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if(Control.ModifierKeys == Keys.None)
            {
                if (e.KeyCode == Keys.D0)
                    btnNum0.PerformClick();

                if (e.KeyCode == Keys.D1)
                    btnNum1.PerformClick();

                if (e.KeyCode == Keys.D2)
                    btnNum2.PerformClick();

                if (e.KeyCode == Keys.D3)
                    btnNum3.PerformClick();

                if (e.KeyCode == Keys.D4)
                    btnNum4.PerformClick();

                if (e.KeyCode == Keys.D5)
                    btnNum5.PerformClick();

                if (e.KeyCode == Keys.D6)
                    btnNum6.PerformClick();

                if (e.KeyCode == Keys.D7)
                    btnNum7.PerformClick();

                if (e.KeyCode == Keys.D8)
                    btnNum8.PerformClick();

                if (e.KeyCode == Keys.D9)
                    btnNum9.PerformClick();

                if (e.KeyCode == Keys.OemPeriod)
                    btnDecimal.PerformClick();

                if (e.KeyCode == Keys.Oemplus)
                    btnAdd.PerformClick();

                if (e.KeyCode == Keys.OemMinus)
                    btnSubtract.PerformClick();

                if (e.KeyCode == Keys.Return)
                    btnEquals.PerformClick();

                if (e.KeyCode == Keys.C)
                    btnClearAll.PerformClick();

                if (e.KeyCode == Keys.Back)
                    btnClearCurrent.PerformClick();

                btnEquals.Focus();
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '*')
                btnMultiply.PerformClick();

            if (e.KeyChar == '/')
                btnDivide.PerformClick();

            btnEquals.Focus();
        }

        private void btnClearCurrent_Click(object sender, EventArgs e)
        {
            textBox_MainDisplay.Text = "0";
            btnDecimal.Enabled = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBox_MainDisplay.Text = "0";
            StoredValue1 = 0;
            StoredValue2 = 0;
            Label_StoredDisplay.Text = "";
            btnDecimal.Enabled = true;
            //isOperationPerformed = false;
            StoredOperation = "";
        }

        private void btnOperatorInput_Click(object sender, EventArgs e)
        {
            Button inputOperator = (Button)sender;

            if (StoredOperation == "")
            {
                StoredOperation = inputOperator.Text;
                StoredValue1 = Convert.ToDouble(textBox_MainDisplay.Text);
                Label_StoredDisplay.Text = StoredValue1 + " " + StoredOperation;
                textBox_MainDisplay.Text = "";
                isOperationStored = true;
                btnDecimal.Enabled = true;
                btnEquals.Focus();
            }

            if (StoredOperation != "" && textBox_MainDisplay.Text == "")
            {
                StoredOperation = inputOperator.Text;
                Label_StoredDisplay.Text = StoredValue1 + " " + StoredOperation;
                isOperationStored = true;
                btnEquals.Focus();
            }

            else if (StoredOperation != "" && textBox_MainDisplay.Text != "")
            {
                btnEquals.PerformClick();
                StoredOperation = inputOperator.Text;
                Label_StoredDisplay.Text = StoredValue1 + " " + StoredOperation;
                isOperationStored = true;
            }            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (textBox_MainDisplay.Text == "")
            {
                textBox_MainDisplay.Text = textBox_MainDisplay.Text + "0";
            }

            if (StoredOperation == "")
            {
                StoredValue1 = Convert.ToDouble(textBox_MainDisplay.Text);
                Label_StoredDisplay.Text = StoredValue1 + " " + "=";
                StoredOperation = "";
                isOperationStored = false;
                btnDecimal.Enabled = true;
                btnEquals.Focus();
            }

            if (StoredOperation != "")
            {
                switch (StoredOperation)
                {
                    case "+":
                        if (StoredOperation != "")
                        {
                            StoredValue2 = Convert.ToDouble(textBox_MainDisplay.Text);
                            textBox_MainDisplay.Text = (StoredValue1 + StoredValue2).ToString();
                        }
                        break;

                    case "-":
                        if (StoredOperation != "")
                        {
                            StoredValue2 = Convert.ToDouble(textBox_MainDisplay.Text);
                            textBox_MainDisplay.Text = (StoredValue1 - StoredValue2).ToString();
                        }
                        break;

                    case "x":
                        if (StoredOperation != "")
                        {
                            StoredValue2 = Convert.ToDouble(textBox_MainDisplay.Text);
                            textBox_MainDisplay.Text = (StoredValue1 * StoredValue2).ToString();
                        }
                        break;

                    case "÷":
                        if (StoredOperation != "")
                        {
                            StoredValue2 = Convert.ToDouble(textBox_MainDisplay.Text);
                            textBox_MainDisplay.Text = (StoredValue1 / StoredValue2).ToString();
                        }
                        break;

                    default:
                        break;
                }
                Label_StoredDisplay.Text = StoredValue1 + " " + StoredOperation + " " + StoredValue2 + " " + "=";
                StoredValue1 = Convert.ToDouble(textBox_MainDisplay.Text);
                StoredOperation = "";
                isOperationStored = false;
                btnDecimal.Enabled = true;
                btnEquals.Focus();
            }

            //else
            //{
            //    textBox_MainDisplay.Text = "Error";
            //}
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            try
            {
                int SwapNum = Convert.ToInt32(textBox_MainDisplay.Text);
                string BIN = Convert.ToString(SwapNum, 2);
                textBox_MainDisplay.Text = BIN;
            }
            catch
            {
                textBox_MainDisplay.Text = "ERROR";
            }
        }

        private void btnDEC_Click(object sender, EventArgs e)
        {
            try
            {
                int SwapNum = Convert.ToInt32(textBox_MainDisplay.Text, 2);
                string DEC = SwapNum.ToString();
                textBox_MainDisplay.Text = DEC;
            }
            catch
            {
                textBox_MainDisplay.Text = "ERROR";
            }
        }

        private void btnSwapSign_Click(object sender, EventArgs e)
        {
            if(textBox_MainDisplay.Text.Contains("-"))
            {
                var SwapNum = Math.Abs(Convert.ToDouble(textBox_MainDisplay.Text));
                textBox_MainDisplay.Text = SwapNum.ToString();

            }
            else
            {
                textBox_MainDisplay.Text = "-" + textBox_MainDisplay.Text;
            }
        }
    }
}
