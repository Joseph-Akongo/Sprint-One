using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Joseph Akongo, Rhys Withey,/ Tango Inc, Sprint One
// Date: 04/04/2022
// Version: 1
// neutrino interactions
// neutrino interations are saved as an integer stored in an array ina forms based GUI applicaion.
// User input to search array, buttons to stort array, text bot to diplay array and any changes.
// Features: Display, Sort, find, add, delete 


namespace neutrino_interactions
{
    public partial class TangoInc : Form
    {
        //set the array including size, set sorted boolean

        public TangoInc()
        {
            InitializeComponent();
        }
        static int maxArraySize = 24;
        int[] myNumbers = new int[maxArraySize];
        bool Sorted = false;

        // Set the array values randomly (10-99) Random(); feature
        private void initiliseArray()
        {
            Random random = new Random();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                myNumbers[x] = random.Next(10, 100);
            }
        }
        //Send the array calues to the listbox (Arraybox)
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
        // Use binary search to find users input. Display found or a error message
        private void findbutton_Click(object sender, EventArgs e)
        {
            int minNum = 0;
            int maxNum = myNumbers.Length;
            int key = int.Parse(inputbox.Text);
            // user sorts find chops list and seaches until found
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == myNumbers[mid])
                {
                    inputbox.Clear();
                    inputbox.Focus();
                    MessageBox.Show("Found!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
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
            //Check if not found and display message
            for (int x = 0; x < myNumbers.Length; x++)
            {
                int mid = (minNum + maxNum) / 2;

                if (key != myNumbers[mid])
                {
                    MessageBox.Show("Not Found ", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                }


            }
        }


        private void editbox_TextChanged(object sender, EventArgs e)
        {

        }
        // User delete's array item then can replace that iteam with input
        private void editbutton_Click(object sender, EventArgs e)
        {
            // if the item is deleted (0) user can input new value
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
                MessageBox.Show("Delete then enter a integer", "Input Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            displayArray();
            // input not empty
            // find element = 0
            // add item to that cell
            // display
        }
        // initilise the array and display it tot he Arraybox (listbox)
        private void initilise_Click(object sender, EventArgs e)
        {
            initiliseArray();
            displayArray();
        }
        public void TangoInc_Load(object sender, EventArgs e)
        {
            displayArray();
        }
        // user selects one array item then presses delete button to set it to 0 where they can add their own number or keep it at 0
        private void deletbutton_Click(object sender, EventArgs e)
        {
            // selected item set value '0'
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
        // input box is the interactive box to find and add numbers with.
        private void inputbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        // key down / clears / delete fearture
        private void inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                inputbox.Clear();
                inputbox.Focus();
            }
        }
        // Select items in the list box (Arraybox)
        private void Arraybox_Click(object sender, EventArgs e)
        {
            // Select number from array and assign that a value
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
        // bubble sort items check if next number is bigger < and if so psuh it down the list until all are sorted.
        private void bubblesort_Click(object sender, EventArgs e)
        {
            {
                // push larger numbers down list
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

        private void Arraybox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}