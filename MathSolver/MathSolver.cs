using System;
using System.Collections.Generic;

namespace MathSolverLibrary
{
    public class MathSolver : IMathSolver
    {
        /// <summary>
        /// Compares array of number in Arbitary system [2;32]
        /// </summary>
        /// <param name="array">Array of numbers</param>
        /// <param name="radix">Arbitary numeral system</param>
        /// <returns>Array of sorted string after comparison in your numeral system</returns>
        public string[] ArbitrarySystemComparison(int[] array, int radix)
        {
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            Array.Sort(array);

            List<string> comparisonResult = new List<string>();
            foreach (int number in array)
            {

                const int BitsInLong = 64;
                const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (radix < 2 || radix > Digits.Length)
                    throw new MathSolverExeption("The radix must be >= 2 and <= " + Digits.Length.ToString());

                if (number == 0)
                {
                    comparisonResult.Add("0");
                    continue;
                }

                int index = BitsInLong - 1;
                long currentNumber = Math.Abs(number);
                char[] charArray = new char[BitsInLong];

                while (currentNumber != 0)
                {
                    int remainder = (int)(currentNumber % radix);
                    charArray[index--] = Digits[remainder];
                    currentNumber = currentNumber / radix;
                }

                string result = new String(charArray, index + 1, BitsInLong - index - 1);
                if (number < 0)
                {
                    result = "-" + result;
                }

                comparisonResult.Add(result);
            }
            return comparisonResult.ToArray();
        }
        /// <summary>
        /// Compares array of number in Arbitary system [2;32]
        /// </summary>
        /// <param name="array">Array of numbers</param>
        /// <param name="radix">Arbitary numeral system</param>
        /// <returns>Array of sorted string after comparison in your numeral system</returns>
        public string[] ArbitrarySystemComparison(long[] array, int radix)
        {
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            Array.Sort(array);

            List<string> comparisonResult = new List<string>();
            foreach (long number in array)
            {

                const int BitsInLong = 64;
                const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (radix < 2 || radix > Digits.Length)
                    throw new MathSolverExeption("The radix must be >= 2 and <= " + Digits.Length.ToString());

                if (number == 0)
                {
                    comparisonResult.Add("0");
                    continue;
                }

                int index = BitsInLong - 1;
                long currentNumber = Math.Abs(number);
                char[] charArray = new char[BitsInLong];

                while (currentNumber != 0)
                {
                    int remainder = (int)(currentNumber % radix);
                    charArray[index--] = Digits[remainder];
                    currentNumber = currentNumber / radix;
                }

                string result = new String(charArray, index + 1, BitsInLong - index - 1);
                if (number < 0)
                {
                    result = "-" + result;
                }

                comparisonResult.Add(result);
            }
            return comparisonResult.ToArray();
        }
        /// <summary>
        /// Compares array of number in Arbitary system [2;32]
        /// </summary>
        /// <param name="array">Array of numbers</param>
        /// <param name="radix">Arbitary numeral system</param>
        /// <returns>Array of sorted string after comparison in your numeral system</returns>
        public string[] ArbitrarySystemComparison(double[] array, int radix)
        {
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            Array.Sort(array);

            List<string> comparisonResult = new List<string>();
            foreach (double number in array)
            {
                long decimalNumber = Convert.ToInt64(Math.Truncate(number));
                double truncatedDecimal = number - decimalNumber;
                string decimalPart = "";

                const int BitsInLong = 64;
                const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (radix < 2 || radix > Digits.Length)
                    throw new MathSolverExeption("The radix must be >= 2 and <= " + Digits.Length.ToString());

                if (decimalNumber == 0)
                {
                    comparisonResult.Add("0");
                    continue;
                }

                int index = BitsInLong - 1;
                long currentNumber = Math.Abs(decimalNumber);
                char[] charArray = new char[BitsInLong];

                while (currentNumber != 0)
                {
                    int remainder = (int)(currentNumber % radix);
                    charArray[index--] = Digits[remainder];
                    currentNumber = currentNumber / radix;
                }

                string result = new String(charArray, index + 1, BitsInLong - index - 1);
                if (decimalNumber < 0)
                {
                    result = "-" + result;
                }
                for (int i = 0; i <= 10; i++)
                {
                    truncatedDecimal *= radix;
                    int truncatedPart = Convert.ToInt32(Math.Truncate(truncatedDecimal));
                    decimalPart += Digits[truncatedPart];
                    truncatedDecimal -= truncatedPart;

                    if (truncatedDecimal - truncatedPart == 0)
                        break;
                }

                comparisonResult.Add(result + "." + decimalPart);
                continue;
            }
            return comparisonResult.ToArray();
        }
        /// <summary>
        /// Compares array of number in Arbitary system [2;32]
        /// </summary>
        /// <param name="array">Array of numbers</param>
        /// <param name="radix">Arbitary numeral system</param>
        /// <returns>Array of sorted string after comparison in your numeral system</returns>
        public string[] ArbitrarySystemComparison(float[] array, int radix)
        {
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            Array.Sort(array);

            List<string> comparisonResult = new List<string>();
            foreach (float number in array)
            {
                long decimalNumber = Convert.ToInt64(Math.Truncate(number));
                double truncatedDecimal = number - decimalNumber;
                string decimalPart = "";

                const int BitsInLong = 64;
                const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (radix < 2 || radix > Digits.Length)
                    throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

                if (decimalNumber == 0)
                {
                    comparisonResult.Add("0");
                    continue;
                }

                int index = BitsInLong - 1;
                long currentNumber = Math.Abs(decimalNumber);
                char[] charArray = new char[BitsInLong];

                while (currentNumber != 0)
                {
                    int remainder = (int)(currentNumber % radix);
                    charArray[index--] = Digits[remainder];
                    currentNumber = currentNumber / radix;
                }

                string result = new String(charArray, index + 1, BitsInLong - index - 1);
                if (decimalNumber < 0)
                {
                    result = "-" + result;
                }
                for (int i = 0; i <= 10; i++)
                {
                    truncatedDecimal *= radix;
                    int truncatedPart = Convert.ToInt32(Math.Truncate(truncatedDecimal));
                    decimalPart += Digits[truncatedPart];
                    truncatedDecimal -= truncatedPart;

                    if (truncatedDecimal - truncatedPart == 0)
                        break;
                }

                comparisonResult.Add(result + "." + decimalPart);
                continue;
            }
            return comparisonResult.ToArray();
        }
        /// <summary>
        /// Differentiate array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Differentiate(int[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double diff = 0;

            foreach (int number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    diff -= number;
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return (long)Math.Pow(Math.Abs(diff), 1f / degree);
        }
        /// <summary>
        /// Differentiate array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Differentiate(long[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double diff = 0;

            foreach (long number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    diff -= number;
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return (long)Math.Pow(Math.Abs(diff), 1f / degree);
        }
        /// <summary>
        /// Differentiate array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Differentiate(double[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double diff = 0;

            foreach (double number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    diff -= number;
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return Math.Pow(Math.Abs(diff), 1f / degree);
        }
        /// <summary>
        /// Differentiate array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Differentiate(float[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double diff = 0;

            foreach (float number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    diff -= number;
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return Math.Pow(Math.Abs(diff), 1f / degree);
        }
        /// <summary>
        /// Divide array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Divide(int[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double division = 1;

            foreach (int number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    division /= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return (long)division;
        }
        /// <summary>
        /// Divide array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Divide(long[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double division = 1;

            foreach (long number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    division /= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return (long)division;
        }
        /// <summary>
        /// Divide array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Divide(double[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double division = 1;

            foreach (double number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    division /= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return division;
        }
        /// <summary>
        /// Divide array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Divide(float[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double division = 1;

            foreach (float number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    division /= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return division;
        }
        /// <summary>
        /// Multiply array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Multiply(int[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double product = 1;

            foreach (int number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    product *= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return (int)product;
        }
        /// <summary>
        /// Multiply array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Multiply(long[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double product = 1;

            foreach (long number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    product *= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return (long)product;
        }
        /// <summary>
        /// Multiply array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Multiply(double[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double product = 1;

            foreach (double number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    product *= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return product;
        }
        /// <summary>
        /// Multiply array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Multiply(float[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double product = 1;

            foreach (float number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    product *= Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            return product;
        }
        /// <summary>
        /// Summarize array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Summarize(int[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double sum = 0;

            foreach (int number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");

                try
                {
                    sum += Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            sum *= array.Length;
            return (long)sum;
        }
        /// <summary>
        /// Summarize array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public long Summarize(long[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double sum = 0;

            foreach (long number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    sum += Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            sum *= array.Length;
            return (long)sum;
        }
        /// <summary>
        /// Summarize array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Summarize(double[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double sum = 0;

            foreach (double number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    sum += Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            sum *= array.Length;
            return sum;
        }
        /// <summary>
        /// Summarize array of constant power
        /// </summary>
        /// <param name="array">Array of values</param>
        /// <param name="degree">Any degree, will be used for bringing all values to one</param>
        /// <returns>Sum of all values</returns>
        public double Summarize(float[] array, int degree)
        {
            if (degree == 0)
                throw new MathSolverExeption("Couldn't power number in 0 degree");
            if (array == null)
                throw new MathSolverExeption("Array of values cannot be empty");
            double sum = 0;

            foreach (float number in array)
            {
                if (number < 0)
                    throw new MathSolverExeption("Number can't be less than 0");
                try
                {
                    sum += Math.Pow(number, 1f / degree);
                }
                catch
                {
                    throw new MathSolverExeption("Couldn't process this", new double[] { number, degree });
                }
            }
            sum *= array.Length;
            return sum;
        }
        /// <summary>
        /// Converts string line to double array if it's possible
        /// </summary>
        /// <param name="stringLine">Your string with numbers sepatated with " " </param>
        /// <returns>Array of double numbers</returns>
        public static double[] StringLineToDouble(string stringLine)
        {
            string[] stringArray = stringLine.Split(" ");
            List<double> doubleList = new List<double>();

            foreach (string item in stringArray)
            {
                try
                {
                    doubleList.Add(Convert.ToDouble(item));
                }
                catch (MathSolverExeption)
                {
                    throw new MathSolverExeption("Incorrect string input");
                }
            }
            return doubleList.ToArray();
        }
        /// <summary>
        /// Converts string line to float array if it's possible
        /// </summary>
        /// <param name="stringLine">Your string with numbers sepatated with " " </param>
        /// <returns>Array of float numbers</returns>
        public static float[] StringLineToFloat(string stringLine)
        {
            string[] stringArray = stringLine.Split(" ");
            List<float> floatList = new List<float>();

            foreach (string item in stringArray)
            {
                try
                {
                    floatList.Add((float)Convert.ToDouble(item));
                }
                catch (MathSolverExeption)
                {
                    throw new MathSolverExeption("Incorrect string input");
                }
            }
            return floatList.ToArray();
        }
        /// <summary>
        /// Converts string line to int array if it's possible
        /// </summary>
        /// <param name="stringLine">Your string with numbers sepatated with " " </param>
        /// <returns>Array of int numbers</returns>
        public static int[] StringLineToInt(string stringLine)
        {
            string[] stringArray = stringLine.Split(" ");
            List<int> intList = new List<int>();

            foreach (string item in stringArray)
            {
                try
                {
                    intList.Add(Convert.ToInt32(item));
                }
                catch (MathSolverExeption)
                {
                    throw new MathSolverExeption("Incorrect string input");
                }
            }
            return intList.ToArray();
        }
        /// <summary>
        /// Converts string line to long array if it's possible
        /// </summary>
        /// <param name="stringLine">Your string with numbers sepatated with " " </param>
        /// <returns>Array of long numbers</returns>
        public static long[] StringLineToLong(string stringLine)
        {
            string[] stringArray = stringLine.Split(" ");
            List<long> longList = new List<long>();

            foreach (string item in stringArray)
            {
                try
                {
                    longList.Add(Convert.ToInt64(item));
                }
                catch (MathSolverExeption)
                {
                    throw new MathSolverExeption("Incorrect string input");
                }
            }
            return longList.ToArray();
        }
    }
}