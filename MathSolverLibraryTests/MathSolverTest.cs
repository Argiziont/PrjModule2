using Xunit;

namespace MathSolverLibrary.Tests
{
    public class MathSolverTest
    {
        public MathSolverTest()
        {
            //Dot in console
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //
        }

        #region snippet_Differentiate_ReturnsDouble_InputIsArrayOfDouble
        [Fact]
        public void Differentiate_ReturnsDouble_InputIsArrayOfDouble()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            var result = solver.Differentiate(doubleArray, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Differentiate_ReturnsDouble_InputIsArrayOfFloat
        [Fact]
        public void Differentiate_ReturnsDouble_InputIsArrayOfFloat()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };

            // Act
            var result = solver.Differentiate(floatArray, 3);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Differentiate_ReturnsLong_InputIsArrayOfLong
        [Fact]
        public void Differentiate_ReturnsLong_InputIsArrayOfLong()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            // Act
            var result = solver.Differentiate(longArray, 4);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Differentiate_ReturnsLong_InputIsArrayOfInt
        [Fact]
        public void Differentiate_ReturnsLong_InputIsArrayOfInt()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };

            // Act
            var result = solver.Differentiate(intArray, 5);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Differentiate_ThrowsExeption_InputIsNullArray
        [Fact]
        public void Differentiate_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] nullLongArray = null;

            // Act
            void result() => solver.Differentiate(nullLongArray, 7);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_Differentiate_ThrowsExeption_InputDegreeIsIncorrect
        [Fact]
        public void Differentiate_ThrowsExeption_InputDegreeIsIncorrect()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            void result() => solver.Differentiate(doubleArray, 0);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_Summarize_ReturnsDouble_InputIsArrayOfDouble
        [Fact]
        public void Summarize_ReturnsDouble_InputIsArrayOfDouble()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            var result = solver.Summarize(doubleArray, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Summarize_ReturnsDouble_InputIsArrayOfFloat
        [Fact]
        public void Summarize_ReturnsDouble_InputIsArrayOfFloat()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };

            // Act
            var result = solver.Summarize(floatArray, 3);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Summarize_ReturnsLong_InputIsArrayOfLong
        [Fact]
        public void Summarize_ReturnsLong_InputIsArrayOfLong()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            // Act
            var result = solver.Summarize(longArray, 4);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Summarize_ReturnsLong_InputIsArrayOfInt
        [Fact]
        public void Summarize_ReturnsLong_InputIsArrayOfInt()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };

            // Act
            var result = solver.Summarize(intArray, 5);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Summarize_ThrowsExeption_InputIsNullArray
        [Fact]
        public void Summarize_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] nullLongArray = null;

            // Act
            void result() => solver.Summarize(nullLongArray, 7);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_Summarize_ThrowsExeption_InputDegreeIsIncorrect
        [Fact]
        public void Summarize_ThrowsExeption_InputDegreeIsIncorrect()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            void result() => solver.Summarize(doubleArray, 0);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_Multiply_ReturnsDouble_InputIsArrayOfDouble
        [Fact]
        public void Multiply_ReturnsDouble_InputIsArrayOfDouble()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            var result = solver.Multiply(doubleArray, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Multiply_ReturnsDouble_InputIsArrayOfFloat
        [Fact]
        public void Multiply_ReturnsDouble_InputIsArrayOfFloat()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };

            // Act
            var result = solver.Multiply(floatArray, 3);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Multiply_ReturnsLong_InputIsArrayOfLong
        [Fact]
        public void Multiply_ReturnsLong_InputIsArrayOfLong()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            // Act
            var result = solver.Multiply(longArray, 4);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Multiply_ReturnsLong_InputIsArrayOfInt
        [Fact]
        public void Multiply_ReturnsLong_InputIsArrayOfInt()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };

            // Act
            var result = solver.Multiply(intArray, 5);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Multiply_ThrowsExeption_InputIsNullArray
        [Fact]
        public void Multiply_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] nullLongArray = null;

            // Act
            void result() => solver.Multiply(nullLongArray, 7);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_Multiply_ThrowsExeption_InputDegreeIsIncorrect
        [Fact]
        public void Multiply_ThrowsExeption_InputDegreeIsIncorrect()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            void result() => solver.Multiply(doubleArray, 0);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_Divide_ReturnsDouble_InputIsArrayOfDouble
        [Fact]
        public void Divide_ReturnsDouble_InputIsArrayOfDouble()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            var result = solver.Divide(doubleArray, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Divide_ReturnsDouble_InputIsArrayOfFloat
        [Fact]
        public void Divide_ReturnsDouble_InputIsArrayOfFloat()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };

            // Act
            var result = solver.Divide(floatArray, 3);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_Divide_ReturnsLong_InputIsArrayOfLong
        [Fact]
        public void Divide_ReturnsLong_InputIsArrayOfLong()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            // Act
            var result = solver.Divide(longArray, 4);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Divide_ReturnsLong_InputIsArrayOfInt
        [Fact]
        public void Divide_ReturnsLong_InputIsArrayOfInt()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };

            // Act
            var result = solver.Divide(intArray, 5);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_Divide_ThrowsExeption_InputIsNullArray
        [Fact]
        public void Divide_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] nullLongArray = null;

            // Act
            void result() => solver.Divide(nullLongArray, 7);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_Divide_ThrowsExeption_InputDegreeIsIncorrect
        [Fact]
        public void Divide_ThrowsExeption_InputDegreeIsIncorrect()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            void result() => solver.Divide(doubleArray, 0);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_ArbitrarySystemComparison_ReturnsDouble_InputIsArrayOfDouble
        [Fact]
        public void ArbitrarySystemComparison_ReturnsDouble_InputIsArrayOfDouble()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            var result = solver.ArbitrarySystemComparison(doubleArray, 2);

            // Assert
            Assert.IsType<string[]>(result);
        }
        #endregion
        #region snippet_ArbitrarySystemComparison_ReturnsDouble_InputIsArrayOfFloat
        [Fact]
        public void ArbitrarySystemComparison_ReturnsDouble_InputIsArrayOfFloat()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };

            // Act
            var result = solver.ArbitrarySystemComparison(floatArray, 3);

            // Assert
            Assert.IsType<string[]>(result);
        }
        #endregion
        #region snippet_ArbitrarySystemComparison_ReturnsLong_InputIsArrayOfLong
        [Fact]
        public void ArbitrarySystemComparison_ReturnsLong_InputIsArrayOfLong()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            // Act
            var result = solver.ArbitrarySystemComparison(longArray, 4);

            // Assert
            Assert.IsType<string[]>(result);
        }
        #endregion
        #region snippet_ArbitrarySystemComparison_ReturnsLong_InputIsArrayOfInt
        [Fact]
        public void ArbitrarySystemComparison_ReturnsLong_InputIsArrayOfInt()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };

            // Act
            var result = solver.ArbitrarySystemComparison(intArray, 5);

            // Assert
            Assert.IsType<string[]>(result);
        }
        #endregion
        #region snippet_ArbitrarySystemComparison_ThrowsExeption_InputIsNullArray
        [Fact]
        public void ArbitrarySystemComparison_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            long[] nullLongArray = null;

            // Act
            void result() => solver.ArbitrarySystemComparison(nullLongArray, 7);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_ArbitrarySystemComparison_ThrowsExeption_InputDegreeIsIncorrect
        [Fact]
        public void ArbitrarySystemComparison_ThrowsExeption_InputDegreeIsIncorrect()
        {
            // Arrange
            MathSolver solver = new MathSolver();
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };

            // Act
            void result() => solver.ArbitrarySystemComparison(doubleArray, 0);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_StringLineToDouble_InvokesMethod_IfInputIscorrect
        [Fact]
        public void StringLineToDouble_ReturnsDoubleArrray_IfInputIscorrect()
        {
            // Arrange
            string stringWithDoubles = "0.48 -0.8 -0.99";

            // Act
            var result = MathSolver.StringLineToDouble(stringWithDoubles);

            // Assert
            Assert.IsType<double[]>(result);
        }
        #endregion
        #region snippet_StringLineToDouble_ThrowsExeption_IfNameOfMethodIsIncorrect
        [Fact]
        public void StringLineToDouble_ThrowsExeption_IfStringIsIncorrect()
        {
            // Arrange
            string stringWithDoubles = "0.4234dsxfd8 -0.8 -0.99";

            // Act
            void result() => MathSolver.StringLineToDouble(stringWithDoubles);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_StringLineToDouble_ThrowsExeption_IfArrayIsNull
        [Fact]
        public void StringLineToDouble_ThrowsExeption_IfArrayIsNull()
        {
            // Arrange
            string stringWithDoubles = null;

            // Act
            void result() => MathSolver.StringLineToDouble(stringWithDoubles);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_StringLineToFloat_InvokesMethod_IfInputIscorrect
        [Fact]
        public void StringLineToFloat_ReturnsFloatArrray_IfInputIscorrect()
        {
            // Arrange
            string stringWithFloats = "0.48 -0.8 -0.99";

            // Act
            var result = MathSolver.StringLineToFloat(stringWithFloats);

            // Assert
            Assert.IsType<float[]>(result);
        }
        #endregion
        #region snippet_StringLineToFloat_ThrowsExeption_IfNameOfMethodIsIncorrect
        [Fact]
        public void StringLineToFloat_ThrowsExeption_IfStringIsIncorrect()
        {
            // Arrange
            string stringWithFloats = "0.4234dsxfd8 -0.8 -0.99";

            // Act
            void result() => MathSolver.StringLineToFloat(stringWithFloats);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_StringLineToFloat_ThrowsExeption_IfArrayIsNull
        [Fact]
        public void StringLineToFloat_ThrowsExeption_IfArrayIsNull()
        {
            // Arrange
            string stringWithFloats = null;

            // Act
            void result() => MathSolver.StringLineToFloat(stringWithFloats);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_StringLineToInt_InvokesMethod_IfInputIscorrect
        [Fact]
        public void StringLineToInt_ReturnsIntArrray_IfInputIscorrect()
        {
            // Arrange
            string stringWithInts = "48 8 99";

            // Act
            var result = MathSolver.StringLineToInt(stringWithInts);

            // Assert
            Assert.IsType<int[]>(result);
        }
        #endregion
        #region snippet_StringLineToInt_ThrowsExeption_IfNameOfMethodIsIncorrect
        [Fact]
        public void StringLineToInt_ThrowsExeption_IfStringIsIncorrect()
        {
            // Arrange
            string stringWithInts = "0.4234dsxfd8 8 -0.99";

            // Act
            void result() => MathSolver.StringLineToInt(stringWithInts);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_StringLineToInt_ThrowsExeption_IfArrayIsNull
        [Fact]
        public void StringLineToInt_ThrowsExeption_IfArrayIsNull()
        {
            // Arrange
            string stringWithInts = null;

            // Act
            void result() => MathSolver.StringLineToInt(stringWithInts);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_StringLineToLong_InvokesMethod_IfInputIscorrect
        [Fact]
        public void StringLineToLong_ReturnsLongArrray_IfInputIscorrect()
        {
            // Arrange
            string stringWithLongs = "48 8 99";

            // Act
            var result = MathSolver.StringLineToLong(stringWithLongs);

            // Assert
            Assert.IsType<long[]>(result);
        }
        #endregion
        #region snippet_StringLineToLong_ThrowsExeption_IfNameOfMethodIsIncorrect
        [Fact]
        public void StringLineToLong_ThrowsExeption_IfStringIsIncorrect()
        {
            // Arrange
            string stringWithLongs = "0.4234dsxfd8 8 -0.99";

            // Act
            void result() => MathSolver.StringLineToLong(stringWithLongs);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_StringLineToLong_ThrowsExeption_IfArrayIsNull
        [Fact]
        public void StringLineToLong_ThrowsExeption_IfArrayIsNull()
        {
            // Arrange
            string stringWithLongs = null;

            // Act
            void result() => MathSolver.StringLineToLong(stringWithLongs);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
    }
}
