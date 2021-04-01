using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CSharpCalculator
{
    public partial class Form1 : Form
    {
        const string dllFile = "C:\\Users\\teguh\\Documents\\Pemrograman\\Cpp\\math_lib\\math_lib.dll";

        [DllImport(dllFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double add(double a, double b);

        [DllImport(dllFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double subtract(double a, double b);

        [DllImport(dllFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double multiply(double a, double b);

        [DllImport(dllFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double divide(double a, double b);

        [DllImport(dllFile, CallingConvention = CallingConvention.Cdecl)]
        public static extern double power(double a, double b);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double c = add(a, b);
            string formatted = String.Format("{0:F6}", c);

            textBox3.Text = formatted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double c = subtract(a, b);
            string formatted = String.Format("{0:F6}", c);

            textBox3.Text = formatted;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double c = multiply(a, b);
            string formatted = String.Format("{0:F6}", c);

            textBox3.Text = formatted;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double c = divide(a, b);
            string formatted = String.Format("{0:F6}", c);

            textBox3.Text = formatted;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double c = power(a, b);
            string formatted = String.Format("{0:F6}", c);

            textBox3.Text = formatted;
        }
    }
}
