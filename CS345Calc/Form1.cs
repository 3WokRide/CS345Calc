using System.Data;

namespace CS345Calc
{
    public partial class Form1 : Form
    {

        const string syntaxErrorMessage = "Syntax Error";
        const string divByZeroMessage = "Cannot Divide by Zero";

        bool wasInvalid = false;

        public Form1()
        {
            InitializeComponent();
            inputBox.Text = "0";
        }

        private void OnNumButtonClick(object sender, EventArgs e)
        {
            var btnNum = (Button)sender;
            if (inputBox.Text == "0" || wasInvalid)
                inputBox.Text = btnNum.Text;
            else
                inputBox.Text += btnNum.Text;

            wasInvalid = false;
        }

        private void BtnClearClick(object sender, EventArgs e)
        {
            inputBox.Text = "0";
        }

        private void BtnBackspaceClick(object sender, EventArgs e) 
        {
            if (wasInvalid)
            {
                inputBox.Text = "0";
                wasInvalid = false;
                return;
            }

            if (inputBox.Text.Length > 1)
                inputBox.Text = inputBox.Text[..^1];
            else
                inputBox.Text = "0";
        }

        private void BtnOperationClick(object sender, EventArgs e)
        {
            var btnOperation = (Button)sender;
            if (wasInvalid)
            {
                inputBox.Text = "0" + btnOperation.Text;
                wasInvalid = false;
                return;
            }
            char[] operations = ['+', '-', '*', '/'];
            if (inputBox.Text.EndsWith('.'))
            {
                inputBox.Text += '0' + btnOperation.Text;
            }
            else if (operations.Any(inputBox.Text.EndsWith)) {
                inputBox.Text = inputBox.Text[..^1] + btnOperation.Text;
            }
            else
            {
                inputBox.Text += btnOperation.Text;
            }
        }

        private void BtnDecimalClick(object sender, EventArgs e)
        {
            if (inputBox.Text.EndsWith('.')) return;

            if (wasInvalid)
            {
                inputBox.Text = "0.";
                wasInvalid = false;
                return;
            }

            char[] operations = ['+', '-', '*', '/'];
            if (operations.Any(inputBox.Text.EndsWith))
            {
                inputBox.Text += "0.";
            }
            else
            {
                inputBox.Text += ".";
            }
        }

        private void BtnParenthesesClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (inputBox.Text == "0" || wasInvalid) inputBox.Text = "";
            inputBox.Text += btn.Text;
            wasInvalid = false;
        }

        private void BtnEqualClick(object sender, EventArgs e)
        {
            DataTable dt = new();
            try
            {
                double res = Convert.ToDouble(dt.Compute(inputBox.Text, ""));
                if (res == double.PositiveInfinity || double.IsNaN(res))
                {
                    inputBox.Text = divByZeroMessage;
                    wasInvalid = true;
                } else
                    inputBox.Text = res.ToString();
            } catch (SyntaxErrorException)
            {
                inputBox.Text = syntaxErrorMessage;
                wasInvalid = true;
            } catch (InvalidCastException)
            {
                inputBox.Text = syntaxErrorMessage;
                wasInvalid = true;
            }
        }
    }
}
