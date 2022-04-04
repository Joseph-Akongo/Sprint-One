using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Joseph Akongo, Tango Inc, Sprint One
// Date: 21/03/2022
// Version: 1
// neutrino interactions
// neutrino interations are saved as an integer stored in an array ina forms based GUI applicaion.
// User input to search array, buttons to stort array, text bot to diplay array and any changes.


namespace neutrino_interactions
{
    public partial class TangoInc : Form
    {
        public TangoInc()
        {
            InitializeComponent();
        }
        static int maxArraySize = 24;
        int[] myNumbers = new int[maxArraySize];
        bool Sorted = true;
        int key;

        private void initiliseArray()
        {
            Random random = new Random();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                myNumbers[x] = random.Next(1, 100);
            }
        }

        private void displayArray()
        {
            Arraybox.Items.Clear();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                Arraybox.Items.Add(myNumbers[x]);
            }
        }

        private void Arraybox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            int minNum = 0;
            int maxNum = myNumbers.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == myNumbers[mid])
                {
                     ++mid;
                }
                else if (key < myNumbers[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            for (int x = 0; x < myNumbers.Length; x++)
            {
                if (myNumbers[x] == int.Parse(inputbox.Text))
                {
                    inputbox.Clear();
                    inputbox.Focus();
                    MessageBox.Show("Found!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else
                {
                    MessageBox.Show("Enter a valid Int ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }

            }
        }


        private void editbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputbox.Text))
            {
                for (int x = 0; x < myNumbers.Length; x++)
                {
                    if (myNumbers[x] == 0)
                    {
                        myNumbers[x] = int.Parse(inputbox.Text);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter an Integer into the Text box", "Input Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // input not empty
            // find element = 0
            // add item to that cell
            // display
        }

        private void initilise_Click(object sender, EventArgs e)
        {
            initiliseArray();
            displayArray();
        }
        public void TangoInc_Load(object sender, EventArgs e)
        {
            displayArray();
        }

        private void deletbutton_Click(object sender, EventArgs e)
        {
            if (Arraybox.SelectedIndex != -1)
            {
                string currentItem = Arraybox.SelectedItem.ToString();
                int itemIndex = Arraybox.FindString(currentItem);

                myNumbers[itemIndex] = 0;
                inputbox.Clear();
                inputbox.Focus();
                displayArray();
            }
            else
            {
                MessageBox.Show("Please select and Item from the list", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayArray();
        }

        private void inputbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                inputbox.Clear();
                inputbox.Focus();
            }
        }

        private void Arraybox_Click(object sender, EventArgs e)
        {
            if (Arraybox.SelectedIndex != -1)
            {
                string currentItem = Arraybox.SelectedItem.ToString();
                int itemIndex = Arraybox.FindString(currentItem);
                inputbox.Text = myNumbers[itemIndex].ToString();
            }
            else
            {
                MessageBox.Show("Please select and Item from the list", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bubblesort_Click(object sender, EventArgs e)
        {
            {
                for (int x = 0; x < myNumbers.Length - 1; x++)
                {
                    for (int y = 0; y < myNumbers.Length - 1; y++)
                    {
                        if (myNumbers[y] > myNumbers[y + 1])
                        {
                            int temp = myNumbers[y + 1];
                            myNumbers[y + 1] = myNumbers[y];
                            myNumbers[y] = temp;

                        }
                    }
                }
                displayArray();
            }
        }
    }
}
  
    
