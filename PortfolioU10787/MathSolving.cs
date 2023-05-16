using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;


namespace PortfolioU10787
{
    public class MathSolving
    {
        #region Private Methods

        /// <summary>
        /// Checks if an array has any element that is zero
        /// </summary>
        /// <param name="pintegers"></param>
        /// <returns>True if no zero was found, False if at least one element is zero </returns>
        private bool ArrayHasNoZeros(uint[] pintegers)
        {
            for (int i = 0; i < pintegers.Length; i++)
            {
                if (pintegers[i] == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Use the Euclidean Algorithm to calculate the GCD of two positive integers.
        /// </summary>
        /// <param name="a">First Positive Number</param>
        /// <param name="b">Second Positive Number</param>
        /// <returns>Recursivly finding the evenly divides between the inputs</returns>
        private uint EuclidianGCDCalculation(uint a, uint b)
        {
            if (a == 0 || b == 0) // Base cases.
                return a + b;
            else if (a == b)
                return a;
            else if (a > b) // Euclid's Algorithm.
                return EuclidianGCDCalculation(a - b, b);
            return EuclidianGCDCalculation(a, b - a);
        }

        /// <summary>
        /// Find the common factors of two positive integers to find the GCD.
        /// </summary>
        /// <param name="a">First Positive Number</param>
        /// <param name="b">Second Positive Number</param>
        /// <returns>The product of the common factors as the GCD</returns>
        private uint PrimeFactorisationGCDCalculation(uint a, uint b)
        {
            // GCD(a, 0) = GCD(0, a) = a.
            if (a == 0 || b == 0) return a + b;

            // Calling the getFactors() function to store the factors of a and b.
            List<uint> afac = getFactors(a);
            List<uint> bfac = getFactors(b);

            // Initializing the GCD variable to store GCD.
            uint GCD = 1;
            int i = 1, j = 1;

            // Multiplying the GCD with the common factors of a and b.
            while (i < afac.Count() && j < bfac.Count())
            {
                // increment i or j by 1 depending on which is larger
                if (afac[i] < bfac[j])
                    i++;
                else if (afac[i] > bfac[j])
                    j++;
                else
                {
                    // if afac[i] == bfac[j], i.e., Common factors
                    GCD *= afac[i];
                    i++;
                    j++;
                }
            }

            return GCD;
            ;
        }


        /// <summary>
        /// Find all prime factors of an integer number.
        /// </summary>
        /// <param name="a">The integers numbers to factorise</param>
        /// <returns>A list of all prime factors</returns>
        List<uint> getFactors(uint a)
        {
            List<uint> factors = new List<uint>();

            // All numbers have 1 as the first factor although it is not a prime number
            factors.Add(1);

            //Finding the prime factors of the integer number.
            uint i = 2;
            while (a != 1)
            {
                while (a % i == 0)
                {
                    factors.Add(i);
                    a /= i;
                }
                i++;
            }

            return factors;
        }
        #endregion

        #region Public Methods
        // Function to find gcd of array of 
        // numbers 
        /// <summary>
        /// Find the GCD of multiple positive numbers with two different methods
        /// </summary>
        /// <param name="pintegers">The array of all integers for which to calculate the GCD.</param>
        /// <param name="PrimeFactorisation">True if using prime factorisation method, False if using Euclidean algorith,</param>
        /// <returns>GCD of all all poisitve integers. Zero if at least one element of the integer array is zero</returns>
        public uint CalculateGCD(uint[] pintegers, bool PrimeFactorisation)
        {
            uint result = 0;
            if (ArrayHasNoZeros(pintegers))
            {
                result = pintegers[0];
                for (int i = 1; i < pintegers.Length; i++)
                {
                    result = PrimeFactorisation ? PrimeFactorisationGCDCalculation(result, pintegers[i]) : EuclidianGCDCalculation(result, pintegers[i]);
                    if (result == 1)
                    {
                        return 1;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Calculates the Least Common Multiple of multiple positive integers
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>LCM of all all poisitve integers. Zero if at least one element of the integer array is zero</returns>
        static uint Count(List<uint> list, uint item)
        {
            uint count = 0;
            foreach (uint Item in list)
            {
                if (Item == item)
                {
                    count++;
                }
            }
            return count;
        }

        public uint CalculateLCM(string inputString)
        {
            string[] numbers = inputString.Split(',');
            Dictionary<uint, Dictionary<uint, uint>> Numbers = new Dictionary<uint, Dictionary<uint, uint>>();
            foreach (string var in numbers)
            {
                List<uint> factors = getFactors(Convert.ToUInt32(var));
                Dictionary<uint, uint> num = new Dictionary<uint, uint>();
                foreach (uint item in factors)
                {
                    if (num.ContainsKey(item) == false)
                    {
                        uint count = Count(factors, item);
                        num.Add(item, count);
                    }

                }
                Numbers.Add(Convert.ToUInt32(var), num);
            }
            foreach (var item in Numbers)
            {
                string Str = "";
                foreach (var Item in item.Value)
                {
                    Str = Str.Insert(Str.Length, Item.ToString() + ",");
                }
            }
            Dictionary<uint, uint> LCMDict = new Dictionary<uint, uint>();
            foreach (var item in Numbers.Values)
            {
                foreach (var Key in item.Keys)
                {
                    if (LCMDict.ContainsKey(Key) == false)
                    {
                        LCMDict.Add(Key, item[Key]);
                    }
                    else if (LCMDict[Key] < item[Key])
                    {
                        LCMDict[Key] = item[Key];
                    }
                }
            }
            uint LCM = 1;
            foreach (var item in LCMDict)
            {
                LCM = Convert.ToUInt32(LCM * Math.Pow(item.Key, item.Value));
            }
            return LCM;
        }

        /// <summary>
        /// Solves a simple linear equation.
        /// </summary>
        /// <param name="a">The coefficient of the x term</param>
        /// <param name="b">The constant term</param>
        /// <returns>True if there is a valid solution. False if there is no solution</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SolveLinearEquation(double a, double b, out double result)
        {
            if (a == 0 && b != 0)
            {
                result = 0;
                return false;
            }
            else
            {
                result = -b / a;
                return true;
            }
        }

        /// <summary>
        /// Solves the quadratic equation. It returns real and imaginary roots.
        /// </summary>
        /// <param name="a">The coefficient of the x squared term</param>
        /// <param name="b">The coefficient of the x term</param>
        /// <param name="c">The constant term</param>
        /// <param name="root1_Real">If the quadratic has real root then it returns the first root.
        ///                     If the quadratic has imaginary roots it returns the real part of the roots.</param>
        /// <param name="root2_Imag">If the quadratic has real root then it returns the second root.
        ///                     If the quadratic has imaginary roots it returns the absolute value of the imaginary part of the roots.</param>
        /// <returns> True if equation has real solutions, False if it has imaginary roots</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool CalculateQuadraticEquation(double a, double b, double c, out double root1_Real, out double root2_Imag)
        {
            /// -b +- sqrt(b^2 - 4*a*c) / 2*a
            bool result = true;
            double discriminant = b*b - 4*a*c;

            if (discriminant >= 0)
            {
                root1_Real = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2_Imag = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else
            {
                result = false;
                root1_Real = -b / (2 * a);
                root2_Imag = Math.Sqrt(-discriminant) / (2 * a);
            }
            return result;
        }        

        /// <summary>
        /// Calculates the determinant of a matrix. The matrix size can only be 2x2, 3x3 and 4x4.
        /// </summary>
        /// <param name="matrix">The table of numbers. Only integers</param>
        /// <returns>The Determinant of the matrix</returns>
        /// <exception cref="NotImplementedException"></exception>
        public double DeterminantOfMatrix(double[,] matrix)
        {
            double determinant = 0;

            if (matrix.GetLength(0) == 2 || matrix.GetLength(1) == 2)
            {
                determinant = (matrix[0, 0] * matrix[0, 1]) - (matrix[1, 0] * matrix[1, 1]);
            }
            else if (matrix.GetLength(0) == 3 || matrix.GetLength(1) == 3)
            {
                determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                            - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                            + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            }
            else if (matrix.GetLength(0) == 4 || matrix.GetLength(1) == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    double[,] subMatrix = new double[3, 3];

                    for (int row = 1; row < 4; row++)
                    {
                        for (int col = 0, subCol = 0; col < 4; col++)
                        {
                            if (col != i)
                            {
                                subMatrix[row - 1, subCol++] = matrix[row, col];
                            }
                        }
                    }
                    double subMatrixAns = subMatrix[0, 0] * (subMatrix[1, 1] * subMatrix[2, 2] - subMatrix[1, 2] * subMatrix[2, 1])
                                        - subMatrix[0, 1] * (subMatrix[1, 0] * subMatrix[2, 2] - subMatrix[1, 2] * subMatrix[2, 0])
                                        + subMatrix[0, 2] * (subMatrix[1, 0] * subMatrix[2, 1] - subMatrix[1, 1] * subMatrix[2, 0]);
                    double cofactor = matrix[0, i] * subMatrixAns;
                    determinant += (i % 2 == 0) ? cofactor : -cofactor;
                }
            }
            return determinant;
        }

        /// <summary>
        /// Calculates the solution of the system of linear equations using 
        /// Cramer's Rule.
        /// </summary>
        /// <param name="coefficients">The array of the cooefficients for example:
        /// For the foillowing equations:
        /// 2x+3y=0
        /// 23x-4y=3
        /// the array should be:
        /// {2,3,0}
        /// {23,-4,3}
        /// </param>
        /// <param name="solutions">An array of doubles equal to the values of each solution. The length of array depends on the linear system size. </param>
        /// <returns>If the system has a solution it returns to true. If the system has no solution it returns false</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SolveLinearSystem(double[,] coefficients, out double[] solutions)
        {
            double determinant = (coefficients[0, 0] * coefficients[1, 1]) - (coefficients[1, 0] * coefficients[0, 1]);

            if (determinant == 0)
            {
                solutions = null;
                return false;
            }

            double determinantX = (coefficients[1, 2] * coefficients[0, 1]) - (coefficients[1, 1] * coefficients[0, 2]);

            double determinantY = (coefficients[0, 0] * coefficients[1, 2]) - (coefficients[1, 0] * coefficients[0, 2]);

            solutions = new double[2];
            solutions[0] = determinantX / determinant;
            solutions[1] = determinantY / determinant;

            return true;
        }
        #endregion
    }
}
