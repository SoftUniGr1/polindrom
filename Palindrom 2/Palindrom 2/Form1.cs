using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrom_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = this.richTextBox1.Text;
            char[] letters = word.ToCharArray();
            int lettersLength = word.Length;
            bool compare = true;
            for (int i = lettersLength - 1; i >= lettersLength / 2; i--)
            {
                if (letters[i] == letters[lettersLength - i - 1])
                {
                    compare = true;
                }
                else
                {
                    compare = false;
                    break;
                }
            }
            if(compare == true)
            {
                MessageBox.Show("Your word is a palindrom");
            }
            else
            {
                MessageBox.Show("Your word is not a palindrom");
            }

        }

    }
}
