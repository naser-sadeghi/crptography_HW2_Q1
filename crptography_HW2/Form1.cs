using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crptography_HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<string> states = new LinkedList<string>();
        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            string initialState = textBoxInitialState.Text;
            string connectionPolynomial = textBoxConnectionPoly.Text;
            if (states.Find(initialState) != null)
            {
                states.Remove(initialState);
                listBoxLfsrStates.Items.Add(initialState);
            }
            int sum = 0;
            for (int i = connectionPolynomial.Length - 1; i >= 0; i--)
            {
                sum += Convert.ToInt32(connectionPolynomial[i].ToString()) * Convert.ToInt32(initialState[i].ToString());
            }

            sum %= 2;
            string tempResult = "";
            tempResult = sum.ToString();
            for (int i = 0; i < initialState.Length - 1; i++)
            {
                tempResult += initialState[i].ToString();
            }
            if (states.Find(tempResult) != null)
            {
                states.Remove(tempResult);
                listBoxLfsrStates.Items.Add(tempResult);
                textBoxInitialState.Text = tempResult;
            }
            else
            {
                MessageBox.Show("Back to initial state");
                listBoxLfsrStates.Items.Add("**********");
            }
        }

        private void ButtonInitialize_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Math.Pow(2, textBoxConnectionPoly.Text.Length) - 1; i++)
            {
                states.AddLast(Convert.ToString(i, 2));
            }

            for (int i = 0; i < states.Count; i++)
            {
                string temp = states.Last();
                if (textBoxConnectionPoly.Text.Length - temp.Length != 0)
                {
                    int difference = textBoxConnectionPoly.Text.Length - temp.Length;
                    string temp2 = "";
                    while (difference != 0)
                    {
                        temp2 += "0";
                        difference--;
                    }
                    temp2 += temp;
                    states.AddFirst(temp2);
                    states.RemoveLast();
                }
                else
                {
                    states.AddFirst(temp);
                    states.RemoveLast();
                }
            }
            MessageBox.Show("Success");
        }

        private void ButtonChangeState_Click(object sender, EventArgs e)
        {
            if(states.Count == 0)
            {
                MessageBox.Show("Finished.");
            }
            else
            {
                textBoxInitialState.Text = states.First();
            }
        }
    }
}
