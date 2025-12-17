using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppHello
{
    public partial class Wdc02 : Form
    {
        public Wdc02()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double weight = 0.0;

            double triangleArea = 0.0;
            if (double.TryParse(textBox1.Text, out height)
                && double.TryParse(textBox2.Text, out weight))
            {
                triangleArea = CalculateTriangleArea(height, weight);
                label6.Text = triangleArea.ToString("F2");
            }

        }

        private double CalculateTriangleArea(double height, double weight)
        {
            
            double area = 0.5 * height * weight;
            return area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = 0.0;
            double circleArea = 0.0;
            double circleference = 0.0;
            if (double.TryParse(textBox4.Text, out radius))
            {
                circleArea = CalculateCircleArea(radius);
                circleference = CalculateCircumference(radius);
                label7.Text = circleArea.ToString("F2");
                label13.Text = circleference.ToString("F2");


            }
        }
        private double CalculateCircleArea(double radius)
        {
            // สูตรพื้นที่วงกลม = pi * r^2
            double area = Math.PI * Math.Pow(radius, 2);
            return area; // ส่งค่ากลับ
        }

        // เพิ่มเติม: ฟังก์ชันหาเส้นรอบวง (ที่หายไป)
        private double CalculateCircumference(double radius)
        {
            // สูตรเส้นรอบวง = 2 * pi * r
            double circumference = 2 * Math.PI * radius;
            return circumference; // ส่งค่ากลับ
        }



        private void button3_Click(object sender, EventArgs e)
        {
            double sumary = 0.0;
            string[] inputs = textBox3.Lines;
            double[] numbers = new double[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (!double.TryParse(inputs[i], out numbers[i]))
                {
                    numbers[i] = 0.0;
                }
            }
            sumary = CalculateSumary(numbers);
            MessageBox.Show("ผลรวม = " + sumary.ToString("F2"));
        }

        private double CalculateSumary(double[] numbers)
        {
            return numbers.Sum();
        }
    }
}


