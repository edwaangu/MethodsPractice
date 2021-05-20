﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            /// TODO - Place method calls here

            PrintSignature();
            RectangleArea();
            addNumbersTogether();
            circleRadius();
            numberMax();

        }

        /// 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        /// 2. Create a method to calculate the area of a rectangle with
        /// dimensions 5x7, and then use the variables to display:
        /// 
        /// The area of a 5 x 7 rectangle is 35 units squared
        public void RectangleArea()
        {
            int rectangleWidth = 5;
            int rectangleLength = 7;
            int rectangleArea = rectangleLength * rectangleWidth;
            q2Output.Text = $"The area of a {rectangleWidth} x {rectangleLength} rectangle is {rectangleArea} units squared";
        }


        /// 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        /// add them together, and then display output as follows:
        /// 
        /// 5 + 4 = 9 
        public void addNumbersTogether()
        {
            int num1 = Convert.ToInt32(q3Num1Input.Text);
            int num2 = Convert.ToInt32(q3Num2Input.Text);
            int numsTogether = num1 + num2;
            q3Output.Text = $"{num1} + {num2} = {numsTogether}";
        }


        /// 4. Create a method to calculate the area of a circle based on  
        /// the radius entered in radiusInput, then display output as follows:
        /// 
        /// The area of a circle with radius of 4 is 50.24 units squared
        public void circleRadius()
        {
            double radius = Convert.ToDouble(radiusInput.Text);
            double areaOfCircle = 3.14 * Math.Pow(radius, 2);
            q4Output.Text = $"The area of a circle with a radius of {radius} is {areaOfCircle.ToString("0.00")} units squared";
        }


        /// 5. 3U Only - Create a method that will determine and display
        /// the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        /// and q5Num3Input. Sample input and output is shown below:
        /// 
        /// Inputs: 5, 7, 2
        /// The largest value is 7

        public void numberMax()
        {
            int num1 = Convert.ToInt32(q5Num1Input.Text);
            int num2 = Convert.ToInt32(q5Num2Input.Text);
            int num3 = Convert.ToInt32(q5Num3Input.Text);

            if(num3 >= num2 && num3 >= num1)
            {
                q5Output.Text = $"The largest number is {num3}";
            }
            else if (num2 >= num3 && num2 >= num1)
            {
                q5Output.Text = $"The largest number is {num2}";
            }
            else if (num1 >= num3 && num1 >= num2)
            {
                q5Output.Text = $"The largest number is {num1}";
            }
        }

    }
}
