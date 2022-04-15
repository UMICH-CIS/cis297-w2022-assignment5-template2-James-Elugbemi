using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        public decimal numeralOne = 0;
        public decimal numeralTwo = 0;
        public decimal numeralThree = 0;
        bool operandActive = false;
        char operand = '=';
        int quads = 0;

        //7 Button, passes numeric value to the math handler
        private void button1_Click(object sender, EventArgs e)
        {
            decimal numeric = 7;
            mathHandler(numeric);
        }

        //8 Button, passes numeric value to the math handler
        private void button2_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 8;
            mathHandler(numeric);
        }

        //9 Button, passes numeric value to the math handler
        private void button3_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 9;
            mathHandler(numeric);
        }

        //'/' Button, passes operation to the evaluation 
        private void button4_Click(object sender, EventArgs e)
        {
            if (numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }

            operand = '/';
            operandActive = true;
            textBox1.Text += '/';
        }
        
        //* Button, passes operation to the evaluation 
        private void button5_Click(object sender, EventArgs e)
        {
            if (numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }

            operand = '*';
            operandActive = true;
            textBox1.Text += '*';
        }

        //6 Button, passes numeric value to the math handler
        private void button6_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 6;
            mathHandler(numeric);
        }

        //5 Button, passes numeric value to the math handler
        private void button7_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 5;
            mathHandler(numeric);
        }

        //4 Button, passes numeric value to the math handler
        private void button8_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 4;
            mathHandler(numeric);
        }

        //+ Button, passes operation to the evaluation 
        private void button9_Click(object sender, EventArgs e)
        {
            if(numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }
                
            }

            operand = '+';
            operandActive = true;
            textBox1.Text += '+';
        }

        //3 Button, passes numeric value to the math handler
        private void button10_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 3;
            mathHandler(numeric);
        }

        //2 Button, passes numeric value to the math handler
        private void button11_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 2;
            mathHandler(numeric);
        }

        //1 Button, passes numeric value to the math handler
        private void button12_Click_1(object sender, EventArgs e)
        {
            decimal numeric = 1;
            mathHandler(numeric);
        }

        //+ Button, passes operation to the evaluation 
        private void button13_Click(object sender, EventArgs e)
        {
            if (numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }

            operand = '-';
            operandActive = true;
            textBox1.Text += '-';
        }
        
        //= button, performs a single operation based on which flag was triggered
        private void button14_Click(object sender, EventArgs e)
        {
            if (numeralTwo == 0 && textBox1.Text != "" && quads == 0)
            {
                try
                {
                    numeralTwo = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }

            string answer = "";
            switch (operand)
            {
                case '/':
                    answer = (numeralOne / numeralTwo).ToString();
                    break;
                case '*':
                    answer = (numeralOne * numeralTwo).ToString();
                    break;
                case '+':
                    answer = (numeralOne + numeralTwo).ToString();
                    break;
                case '-':
                    answer = (numeralOne - numeralTwo).ToString();
                    break;
                case '=':
                    break;
                case 'q':
                    answer = ((numeralOne / numeralTwo).ToString() + " " + (numeralOne % numeralTwo).ToString());
                    break;
                case 'm':
                    decimal max = Math.Max(numeralOne, numeralTwo);
                    decimal min = Math.Min(numeralOne, numeralTwo);
                    answer = "Max: " + max + " Min: " + min;
                    break;
                case 'l':
                    answer = Math.Log((double)numeralOne, (double)numeralTwo).ToString();
                    break;
                case '^':
                    answer = Math.Pow((double)numeralOne, (double)numeralTwo).ToString();
                    break;
                case 's':
                    answer = Math.Sqrt((double)numeralTwo).ToString();
                    break;
                case 'r':
                    double X1 = 0;
                    double X2 = 0;
                    double A = (double)numeralOne;
                    double B = (double)numeralTwo;
                    double C = (double)numeralThree;
                    double Discriminant = Math.Pow(B, 2) - 4 * A * C;
                    bool status = true;


                    if (Discriminant == 0)
                    {
                        X1 = -B / (2 * A);
                        X2 = X1;
                    }
                    else if (Discriminant > 0)
                    {
                        X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                        X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                    }
                    else
                    {
                        status = false;
                    }

                    if (status)
                    {
                        if (X1 == X2)
                        {
                            textBox1.Text = $"The equation has one root: {X1}";
                            quads = 0;
                            return;
                        }
                        else
                        {
                            textBox1.Text = ($"Root X1 = {X1}");
                            textBox1.Text += ($" Root X2 = {X2}");
                            quads = 0;
                            return;
                        }
                    }
                    else
                    {
                        textBox1.Text = "Equation has no real roots!";
                        quads = 0;
                        return;
                    }
                    
                    break;

            }
            operand = '=';
            numeralOne = 0;
            numeralTwo = 0;

            textBox1.Text = answer.ToString();
        } 
        

        private void button16_Click(object sender, EventArgs e)
        {
            decimal numeric = 0;
            mathHandler(numeric);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxHelper(decimal numeral)
        {
            textBox1.Text += numeral;
        }

        private void textBoxHelper()
        {
            //textBox1.Text +=;
        }

        private void mathHandler(decimal numeral)
        {
            if(operand == 'r')
            {
                switch (quads) 
                {
                    case 1:
                        numeralOne *= 10;
                        numeralOne += numeral;
                        textBox1.Text += numeral.ToString();
                        break;
                    case 2:
                        numeralTwo *= 10;
                        numeralTwo += numeral;
                        textBox1.Text += numeral.ToString();
                        break;
                    case 3:
                        numeralThree *= 10;
                        numeralThree += numeral;
                        textBox1.Text += numeral.ToString();
                        break;
                }
                return;
            }

            if(!operandActive)
            {
                numeralOne *= 10;
                numeralOne += numeral;
            }
            else
            {
                numeralTwo *= 10;
                numeralTwo += numeral;   
            }

            textBoxHelper(numeral);
        }

        //Decimal goes unused, despite using double and decimal vatiables
        //this calculator can only handle integers
        private void button15_Click(object sender, EventArgs e)
        {

        }




        //calculates the log of a number in any base
        private void button21_Click(object sender, EventArgs e)
        {
            if (numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }
            operand = 'l';
            operandActive = true;
            textBox1.Text += "logn";
        }

        //exit button closes the program
        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //removes the space from a string typed into the text box
        private void button17_Click(object sender, EventArgs e)
        {
            string toRem = textBox1.Text;
            toRem = toRem.Replace(" ", "");
            textBox1.Text = toRem;
        }

        //reverses a string typed into the text box
        private void button18_Click(object sender, EventArgs e)
        {
            char[] charArray = textBox1.Text.ToCharArray();
            Array.Reverse(charArray);
            textBox1.Text = String.Concat(charArray);
        }

        //sets the flag for the evaluator to output the quotient and remainder of two numbers
        private void button19_Click(object sender, EventArgs e)
        {
            if (numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }
            operand = 'q';
            operandActive = true;
            textBox1.Text += 'q';
        }

        //calculates the log of a number in base 10
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
            double ans = Math.Log10(int.Parse(textBox1.Text));
            textBox1.Text = ans.ToString();


            }
            catch
            {
                textBox1.Text = "Invalid use of function";
            }
        }

        //calculates the minimum and maximum of any two numbers
        private void button22_Click(object sender, EventArgs e)
        {
            if (numeralOne == 0 && textBox1.Text != "")
            {
                try
                {
                    numeralOne = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Invalid use of operation";
                    return;
                }

            }

            operand = 'm';
            operandActive = true;
            textBox1.Text += 'm';
        }

        //takes a number and raises it to the power of another
        private void button23_Click(object sender, EventArgs e)
        {
            operand = '^';
            operandActive = true;
            textBox1.Text += '^';
        }

        //sets the flag for three numbers to have the roots calculated
        private void button24_Click(object sender, EventArgs e)
        {
            operand = 'r';
            switch (quads)
            { 
                case 0:
                    textBox1.Text = "a: ";
                    //operandActive = true;
                    quads++;
                    break;
                case 1:
                    textBox1.Text = " b: ";
                    quads++;
                    break;
                case 2:
                    textBox1.Text = " c: ";
                    quads++;
                    break;

            }
        }

        //sets the flag for the square root of a number to be calculated
        private void button25_Click(object sender, EventArgs e)
        {
            operand = 's';
            operandActive = true;
            textBox1.Text += "sqrt(";
        }

    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/