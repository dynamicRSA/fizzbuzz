using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzFormsApplication
{
    public partial class Form1 : Form
    {
        //int fizzValue =0;
        //int buzzValue =0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //fizz buzz logic 
                for (int i = 1; i <= 100; i++)
                {
                    if ((i % (Convert.ToInt32(fizzValue.Text)) == 0) && (i % (Convert.ToInt32(buzzValue.Text)) == 0))
                    {
                        //out fizzbuzz
                        Console.WriteLine("FizzBuzz");
                        listBox1.Items.Add("FizzBuzz");
                    }
                    else if (i % (Convert.ToInt32(fizzValue.Text)) == 0)
                    {
                        //out fizz
                        Console.WriteLine("Fizz");
                        listBox1.Items.Add("Fizz");
                    }
                    else if (i % (Convert.ToInt32(buzzValue.Text)) == 0)
                    {
                        //out buzz
                        Console.WriteLine("Buzz");
                        listBox1.Items.Add("Buzz");
                    }
                    else {
                        Console.WriteLine(i);
                        listBox1.Items.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to run logic " + ex);
            }
        }
    }
}
