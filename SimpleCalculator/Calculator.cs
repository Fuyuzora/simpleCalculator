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
    public partial class simple_calculator : Form
    {
        private string calculating = null;
        public simple_calculator()
        {
            InitializeComponent();
            result.Text = string.Empty;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            result.Text += 9.ToString();
            calculating += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            result.Text += btn8.Text;
            calculating += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            result.Text += btn7.Text;
            calculating += "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            result.Text += btn6.Text;
            calculating += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            result.Text += btn5.Text;
            calculating += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            result.Text += btn4.Text;
            calculating += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            result.Text += btn3.Text;
            calculating += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            result.Text += btn2.Text;
            calculating += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            result.Text += btn1.Text;
            calculating += "1";
        }

        private void bracketL_Click(object sender, EventArgs e)
        {
            result.Text += bracketL.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            result.Text += btn0.Text;
        }

        private void bracketR_Click(object sender, EventArgs e)
        {
            result.Text += bracketR.Text;
        }

        private void btnSq_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            result.Text = null;
            result.Clear();
            calculating = string.Empty;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            /*if(result.Text == "")
            {
                return;
            }
            else if(result.Text.Contains("+") || result.Text.Contains("-") || result.Text.Contains("*") || result.Text.Contains("/"))
            {
                string temp = result.Text;
                com2 = temp.Replace(com1, "");
            }
            else
            {
                com1 = result.Text;
                answer = Convert.ToDouble(com1);
            }
            result.Text += "+";
            answer += Convert.ToDouble(com2);
            com2 = null;
            com1 = result.Text;*/
            result.Text += "+";
            calculating += "@+@";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            result.Text += "-";
            calculating += "@-@";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            result.Text += "*";
            calculating += "@*@";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            result.Text += "/";
            calculating += "@/@";
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            string[] seperator = new string[1] { "@" };
            string[] parser = calculating.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            string[] x = multiDivision(parser);
            string a = null;
            foreach (string s in parser)
            {
                a += s;
            }
            Console.WriteLine(a);
            a = null;
            foreach (string s in x)
            {
                a += s;
            }
            Console.WriteLine(a);
            string[] y = addSubtraction(x);
            foreach (string s in y)
            {
                result.Clear();
                result.Text += s;
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            result.Text += btnDecimal.Text;
        }

        private string[] multiDivision(string[] values)
        {
            // case 0: none of them exist
            if (!values.Contains("*") && !values.Contains("/"))
            {
                return values;
            }
            else
            {
                string[] afterall = new string[values.Length - 2];
                // case 1 : both multiplication and division exist
                if (values.Contains("*") && values.Contains("/"))
                {
                    int i = Array.IndexOf(values, "*");
                    int j = Array.IndexOf(values, "/");
                    if (i < j)
                    {
                        string answer = (Convert.ToDouble(values[i - 1]) * Convert.ToDouble(values[i + 1])).ToString();
                        for (int a = 0; a < i - 2; a++)
                        {
                            afterall[a] = values[a];
                        }
                        afterall[i] = answer;
                        for (int a = i - 1; a < afterall.Length; a++)
                        {
                            afterall[a] = values[a + 2];
                        }
                    }
                    else
                    {
                        string answer = (Convert.ToDouble(values[j - 1]) / Convert.ToDouble(values[j + 1])).ToString();
                        for (int a = 0; a < i - 1; a++)
                        {
                            afterall[a] = values[a];
                        }
                        afterall[j] = answer;
                        for (int a = j + 1; a < afterall.Length; a++)
                        {
                            afterall[a] = values[a + 2];
                        }
                    }
                }
                // case 2: only multiplication exists
                else if (values.Contains("*"))
                {
                    int i = Array.IndexOf(values, "*");
                    string answer = (Convert.ToDouble(values[i - 1]) * Convert.ToDouble(values[i + 1])).ToString();
                    for (int a = 0; a < i - 2; a++)
                    {
                        afterall[a] = values[a];
                    }
                    afterall[i - 1] = answer;
                    for (int a = i; a < afterall.Length; a++)
                    {
                        afterall[a] = values[a + 2];
                    }

                }
                // case 3: only division exists
                else if (values.Contains("/"))
                {
                    int i = Array.IndexOf(values, "/");
                    string answer = (Convert.ToDouble(values[i - 1]) / Convert.ToDouble(values[i + 1])).ToString();
                    for (int a = 0; a < i - 2; a++)
                    {
                        afterall[a] = values[a];
                    }
                    afterall[i - 1] = answer;
                    for (int a = i; a < afterall.Length; a++)
                    {
                        afterall[a] = values[a + 2];
                    }
                }
                return multiDivision(afterall);
            }
        }

        private string[] addSubtraction(string[] values)
        {
            // case 0: none of them exist
            if (!values.Contains("+") && !values.Contains("-"))
            {
                return values;
            }
            else
            {
                string[] afterall = new string[values.Length - 2];
                // case 1 : both multiplication and division exist
                if (values.Contains("+") && values.Contains("-"))
                {
                    int i = Array.IndexOf(values, "+");
                    int j = Array.IndexOf(values, "-");
                    if (i < j)
                    {
                        string answer = (Convert.ToDouble(values[i - 1]) + Convert.ToDouble(values[i + 1])).ToString();
                        for (int a = 0; a < i - 2; a++)
                        {
                            afterall[a] = values[a];
                        }
                        afterall[i] = answer;
                        for (int a = i - 1; a < afterall.Length; a++)
                        {
                            afterall[a] = values[a + 2];
                        }
                    }
                    else
                    {
                        string answer = (Convert.ToDouble(values[j - 1]) - Convert.ToDouble(values[j + 1])).ToString();
                        for (int a = 0; a < i - 1; a++)
                        {
                            afterall[a] = values[a];
                        }
                        afterall[j] = answer;
                        for (int a = j + 1; a < afterall.Length; a++)
                        {
                            afterall[a] = values[a + 2];
                        }
                    }
                }
                // case 2: only multiplication exists
                else if (values.Contains("+"))
                {
                    int i = Array.IndexOf(values, "+");
                    string answer = (Convert.ToDouble(values[i - 1]) + Convert.ToDouble(values[i + 1])).ToString();
                    for (int a = 0; a < i - 2; a++)
                    {
                        afterall[a] = values[a];
                    }
                    afterall[i - 1] = answer;
                    for (int a = i; a < afterall.Length; a++)
                    {
                        afterall[a] = values[a + 2];
                    }

                }
                // case 3: only division exists
                else if (values.Contains("-"))
                {
                    int i = Array.IndexOf(values, "-");
                    string answer = (Convert.ToDouble(values[i - 1]) - Convert.ToDouble(values[i + 1])).ToString();
                    for (int a = 0; a < i - 2; a++)
                    {
                        afterall[a] = values[a];
                    }
                    afterall[i - 1] = answer;
                    for (int a = i; a < afterall.Length; a++)
                    {
                        afterall[a] = values[a + 2];
                    }
                }
                return addSubtraction(afterall);
            }
        }
    }
}
