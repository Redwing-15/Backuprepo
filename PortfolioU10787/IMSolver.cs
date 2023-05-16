using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PortfolioU10787
{
    public partial class IMSolver : Form
    {
        public MathSolving maths = new MathSolving();
        public IMSolver()
        {
            InitializeComponent();
        }

        private void LCM_CalculateBTN_Click(object sender, EventArgs e)
        {
            string inputString = LCM_inputBox.Text;
            if (inputString.Contains(" "))
            {
                inputString = inputString.Replace(' ', ',');
            }
            string[] arr = inputString.Split(',');
            Regex r = new Regex(@"^[\d,]+$");
            if (!r.IsMatch(inputString))
            {
                LCM_outputBox.Text = "Invalid characters in input!";
                return;
            }
            foreach (string element in arr)
            {
                if (element.Length < 1)
                {
                    LCM_outputBox.Text = "Invalid input sequence";
                    return;
                }
                int count = arr.Count(item => item == element);
                if (count > 1)
                {
                    LCM_outputBox.Text = $"{element} appears more than once, please remove other instances";
                    return;
                }
            }
            LCM_outputBox.Text = maths.CalculateLCM(LCM_inputBox.Text).ToString();
        }

        private void GCD_CalculateBTN_Click(object sender, EventArgs e)
        {
            string inputString = GCD_inputBox.Text;
            if (inputString.Contains(" "))
            {
                inputString = inputString.Replace(' ', ',');
            }
            string[] arr = inputString.Split(',');
            Regex r = new Regex(@"^[\d,]+$");
            if (!r.IsMatch(inputString))
            {
                GCD_outputBox.Text = "Invalid characters in input!";
                return;
            }
            foreach (string element in arr)
            {
                if (element.Length < 1)
                {
                    GCD_outputBox.Text = "Invalid input sequence";
                    return;
                }
            }

            uint[] myInts = Array.ConvertAll(arr, uint.Parse);

            uint result = maths.CalculateGCD(myInts, GCD_primeCheckBtn.Checked);
            GCD_outputBox.Text = result.ToString();
        }

        private void QE_calculateButton_Click(object sender, EventArgs e)
        {
            string inputString = QE_entryBox.Text;
            if (inputString.Contains(" "))
            {
                inputString = inputString.Replace(' ', ',');
            }
            if (!Regex.IsMatch(inputString, @"^-?\d+x\^2[+-]\d+x[+-]\d+=0$", RegexOptions.Multiline))
            {
                QE_outputBox.Text = "Invalid input!";
                return;
            }
            string[] input = inputString.Split(new[] { "x^2" }, StringSplitOptions.None);
            double a = Convert.ToDouble(input[0]);
            input = input[1].Split('x');
            double b = Convert.ToDouble(input[0]);
            input = input[1].Split('=');
            double c = Convert.ToDouble(input[0]);

            double real;
            double imag;
            if (maths.CalculateQuadraticEquation(a, b, c, out real, out imag))
            {
                QE_imaginaryCheck.Checked = false;
            }
            else
            {
                QE_imaginaryCheck.Checked = true;
            }
            QE_outputBox.Text = $"{real:0.00}, {imag:0.00}";
        }
                
        private void DM_calculateBTN_Click(object sender, EventArgs e)
        {
            DM_outputLabel.Text = "";
            string inputString = DM_entryBox.Text;
            if (inputString.Contains(" "))
            {
                inputString = inputString.Replace(' ', ',');
            }
            string[] allLines = inputString.Split('\n');

            if ((allLines.Length != allLines[0].Split(',').Length) | (allLines.Length > 4 | allLines[0].Split(',').Length > 4))
            {
                DM_outputLabel.Text = "Invalid matrix size!";
                return;
            }
            double[,] matrix = new double[allLines.Length, allLines[0].Split(',').Length];

            for (int i = 0; i < allLines.Length; i++)
            {
                string[] row = allLines[i].Trim().Split(',');
                if (row.Length != allLines[0].Split(',').Length)
                {
                    DM_outputLabel.Text = "Invalid matrix size!";
                    return;
                }
                if (!Regex.IsMatch(allLines[i].Trim(), @"^[-?\d,]+$", RegexOptions.Multiline))
                {
                    DM_outputLabel.Text = "Invalid characters in input!";
                    return;
                }
                foreach (string element in row)
                {
                    if (element.Length < 1)
                    {
                        DM_outputLabel.Text = "Invalid input sequence";
                        return;
                    }
                }
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = double.Parse(row[j]);
                }
            }
            double result = maths.DeterminantOfMatrix(matrix);
            DM_outputLabel.Text = result.ToString();
        }

        private void LE_calculateBTN_Click(object sender, EventArgs e)
        {
            string inputString = LE_inputBox.Text;
            if (inputString.Contains(" "))
            {
                inputString = inputString.Replace(' ', ',');
            }
            LE_outputLabel.Text = "";
            string[] allLines = inputString.Split('\n');
            if (allLines.Length == 1)
            {
                Regex r = new Regex(@"^-?[\d]x[+-][\d]=0+$");
                if (!r.IsMatch(inputString))
                {
                    LE_outputLabel.Text = "Invalid input!";
                    return;
                }
                string line = allLines[0];
                allLines = line.Split('x');
                double result;
                double a = Convert.ToDouble(allLines[0]);
                double b = Convert.ToDouble(allLines[1].Substring(0, allLines[1].Length - 2));
                if (maths.SolveLinearEquation(a, b, out result))
                {
                    LE_outputLabel.Text = $"{result}";
                }
                else
                {
                    LE_outputLabel.Text = $"Equation has no solution";
                }
            }
            else if (allLines.Length == 2)
            {
                int rows = allLines.Length;
                int cols = allLines[0].Length;

                double[,] coefficients = new double[rows,cols];
                int n = 0;
                foreach (string line in allLines)
                {
                    
                    if (!Regex.IsMatch(line.Trim(), @"^-?\d*x[+-]\d*y=-?\d+$", RegexOptions.Multiline))
                    {
                        LE_outputLabel.Text = "Invalid input!";
                        return;
                    }
                    string[] String = line.Split('x');
                    coefficients[n, 0] = Convert.ToDouble(String[0]);

                    String = String[1].Split(new[] { "y=" }, StringSplitOptions.None); // string.split - by multiple character delimiter https://stackoverflow.com/a/1254596
                    coefficients[n, 1] = Convert.ToDouble(String[0]);
                    coefficients[n, 2] = Convert.ToDouble(String[1]);
                    n++;
                }
                double[] results;
                if (maths.SolveLinearSystem(coefficients, out results))
                {
                    LE_outputLabel.Text = $"X = {Math.Round(results[0], 2)}\nY = {Math.Round(results[1], 2)}";
                }
                else
                {
                    LE_outputLabel.Text = $"Equation has no solution";
                }
            }
            else
            {
                LE_outputLabel.Text = $"Too many equations!";
                return;
            }
        }
    }
}
