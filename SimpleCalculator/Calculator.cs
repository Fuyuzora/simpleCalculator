using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Simple_calculator : Form
    {
        private List<MyNumber> numbers = new List<MyNumber>();
        List<Button> buttons = new List<Button>();
        private string lastClick;
        private string operation_of_numbers;
        private string oldNums = " ";
        private bool squared;
        private bool sqrted;

        public Simple_calculator()
        {
            InitializeComponent();
            result.Text = string.Empty;
            #region add buttons to list
            buttons.Add(btn0);
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(bracketL);
            buttons.Add(bracketR);
            buttons.Add(btnSq);
            buttons.Add(sqrt);
            buttons.Add(btnEq);
            buttons.Add(btnNegative);
            buttons.Add(btnP);
            buttons.Add(btnM);
            buttons.Add(btnS);
            buttons.Add(btnD);
            buttons.Add(btnDecimal);
            #endregion
        }

        #region Assign buttons

        private void Btn9_Click(object sender, EventArgs e)
        {
            result.Text += 9.ToString();
            lastClick = "0";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            result.Text += btn8.Text;
            lastClick = "0";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            result.Text += btn7.Text;
            lastClick = "0";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            result.Text += btn6.Text;
            lastClick = "0";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            result.Text += btn5.Text;
            lastClick = "0";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            result.Text += btn4.Text;
            lastClick = "0";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            result.Text += btn3.Text;
            lastClick = "0";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            result.Text += btn2.Text;
            lastClick = "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            result.Text += btn1.Text;
            lastClick = "0";
        }

        private void BracketL_Click(object sender, EventArgs e)
        {
            result.Text += bracketL.Text;
            lastClick = "0";
            HandleError();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            result.Text += btn0.Text;
            lastClick = "0";
        }

        private void BracketR_Click(object sender, EventArgs e)
        {
            result.Text += bracketR.Text;
            lastClick = "0";
        }

        private void BtnSq_Click(object sender, EventArgs e)
        {
            result.Text += "^2";
            squared = true;
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            result.Text += "-";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            result.Text = null;
            result.Clear();
            numbers.Clear();
            foreach (Button btn in buttons)
                btn.Enabled = true;
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            AddNumber("+");
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            AddNumber("-");
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            AddNumber("*");
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            AddNumber("/");
        }

        private void BtnEq_Click(object sender, EventArgs e)
        {
            AddNumber(string.Empty);
            NowCalculate(numbers);
            foreach (Button btn in buttons)
                btn.Enabled = false;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            result.Text += "sqrt";
            sqrted = true;
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (lastClick != btnDecimal.ToString() && result.Text.Length != 0)
            {
                lastClick = "F";
                result.Text += ".";
            }
        }

        #endregion

        #region methods

        private void NowCalculate(List<MyNumber> numbers)
        {
          // multiplication and division
          for(int i = 1; i < numbers.Count; i++)
            {
                switch (numbers[i].Operator)
                {
                    case "*":
                        numbers[i - 1].value *= numbers[i].value;
                        numbers.Remove(numbers[i]);
                        i--;
                        break;
                    case "/":
                        try
                        {
                            numbers[i - 1].value /= numbers[i].value;
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                        catch
                        {
                            HandleError();
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
            // addition and subtraction
          for (int i = 0; i < numbers.Count; i++)
            {
                switch (numbers[i].Operator)
                {
                    case "+":
                        numbers[i - 1].value += numbers[i].value;
                        numbers.Remove(numbers[i]);
                        i--;
                        break;
                    case "-":
                        numbers[i - 1].value -= numbers[i].value;
                        numbers.Remove(numbers[i]);
                        i--;
                        break;
                    default:
                        break;
                }
            }
          result.Text = numbers[0].value.ToString();
        }

        private void AddNumber(string operation)
        {
            if (lastClick != "F" && result.Text.Length != 0)
            {
                // in case there are only 2 numbers

                MyNumber number = new MyNumber();
                string newNum = result.Text;
                newNum = newNum.Replace(oldNums, " ");
                newNum = newNum.Replace("^2", " ");
                newNum = newNum.Replace("sqrt", " ");
                result.Text += operation;
                oldNums = result.Text;
                number.Operator = operation_of_numbers;
                number.value = Convert.ToDouble(newNum);
                // sign determination
                if (number.value < 0)
                {
                    number.sign = "-";
                }
                if (squared)
                {
                    number.value *= number.value;
                    squared = false;
                }
                if (sqrted)
                {
                    sqrted = false;
                    try
                    {
                        number.value = Math.Sqrt(number.value);
                    }
                    catch
                    {
                        HandleError();
                        return;
                    }
                }
                numbers.Add(number);
                lastClick = "F";
                operation_of_numbers = operation;
            }
        }

        private void HandleError()
        {
            result.Text = "Error occurred!";
            foreach (Button btn in buttons)
                btn.Enabled = false;
        }
        #endregion
    }
}
