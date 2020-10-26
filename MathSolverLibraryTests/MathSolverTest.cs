using System;
using Xunit;

namespace MathSolverLibrary.Tests
{
    public class MathSolverTest
    {
        #region snippet_Differentiate_ReturnsCorrectResult_IfInputIscorrect
        [Fact]
        public void Differentiate_ReturnsCorrectResult_IfInputIscorrect()
        {
            // Arrange
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            long[] nullLongArray = null;

            MathSolver solver = new MathSolver();

            // Act
            var resultOne = solver.Differentiate(doubleArray, 2);
            var resultTwo = solver.Differentiate(floatArray, 3);
            var resultThree = solver.Differentiate(intArray, 4);
            var resultFour = solver.Differentiate(longArray, 5);


            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;

            try
            {
                solver.Differentiate(doubleArray, 0);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }

            try
            {
                solver.Differentiate(nullLongArray, 2);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }


            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<long>(resultThree);
            _ = Assert.IsType<long>(resultFour);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);
        }
        #endregion
        #region snippet_Summarize_ReturnsCorrectResult_IfInputIscorrect
        [Fact]
        public void Summarize_ReturnsCorrectResult_IfInputIscorrect()
        {
            // Arrange
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            long[] nullLongArray = null;

            MathSolver solver = new MathSolver();

            // Act
            var resultOne = solver.Summarize(doubleArray, 2);
            var resultTwo = solver.Summarize(floatArray, 3);
            var resultThree = solver.Summarize(intArray, 4);
            var resultFour = solver.Summarize(longArray, 5);


            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;

            try
            {
                solver.Summarize(doubleArray, 0);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }

            try
            {
                solver.Summarize(nullLongArray, 2);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }


            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<long>(resultThree);
            _ = Assert.IsType<long>(resultFour);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);
        }
        #endregion
        #region snippet_Multiply_ReturnsCorrectResult_IfInputIscorrect
        [Fact]
        public void Multiply_ReturnsCorrectResult_IfInputIscorrect()
        {
            // Arrange
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            long[] nullLongArray = null;

            MathSolver solver = new MathSolver();

            // Act
            var resultOne = solver.Multiply(doubleArray, 2);
            var resultTwo = solver.Multiply(floatArray, 3);
            var resultThree = solver.Multiply(intArray, 4);
            var resultFour = solver.Multiply(longArray, 5);


            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;

            try
            {
                solver.Multiply(doubleArray, 0);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }

            try
            {
                solver.Multiply(nullLongArray, 2);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }


            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<long>(resultThree);
            _ = Assert.IsType<long>(resultFour);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);
        }
        #endregion
        #region snippet_Divide_ReturnsCorrectResult_IfInputIscorrect
        [Fact]
        public void Divide_ReturnsCorrectResult_IfInputIscorrect()
        {
            // Arrange
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            long[] nullLongArray = null;

            MathSolver solver = new MathSolver();

            // Act
            var resultOne = solver.Divide(doubleArray, 2);
            var resultTwo = solver.Divide(floatArray, 3);
            var resultThree = solver.Divide(intArray, 4);
            var resultFour = solver.Divide(longArray, 5);


            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;

            try
            {
                solver.Divide(doubleArray, 0);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }

            try
            {
                solver.Divide(nullLongArray, 2);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }


            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<long>(resultThree);
            _ = Assert.IsType<long>(resultFour);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);
        }
        #endregion
        #region snippet_ArbitrarySystemComparison_ReturnsCorrectResult_IfInputIscorrect
        [Fact]
        public void ArbitrarySystemComparison_ReturnsCorrectResult_IfInputIscorrect()
        {
            // Arrange
            double[] doubleArray = { 0.48, 0.18, 0.49, 0.8, 0.81234, 0.2566799, 0.489, 0.878, 0.0054 };
            float[] floatArray = { 0.48f, 0.18f, 0.49f, 0.8f, 0.81234f, 0.2566799f, 0.489f, 0.878f, 0.0054f };
            int[] intArray = { 100, 7012, 2802314, 12676, 12370, 1010, 7012, 2802314, 12676, 12370 };
            long[] longArray = { 11200, 70112, 2802414, 12676, 12370, 1010, 70534512, 2802314, 12676, 11232370 };

            long[] nullLongArray = null;

            MathSolver solver = new MathSolver();

            // Act
            var resultOne = solver.ArbitrarySystemComparison(doubleArray, 2);
            var resultTwo = solver.ArbitrarySystemComparison(floatArray, 3);
            var resultThree = solver.ArbitrarySystemComparison(intArray, 4);
            var resultFour = solver.ArbitrarySystemComparison(longArray, 5);


            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;

            try
            {
                solver.ArbitrarySystemComparison(doubleArray, 0);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }

            try
            {
                solver.ArbitrarySystemComparison(nullLongArray, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }


            // Assert
            _ = Assert.IsType<string[]>(resultOne);
            _ = Assert.IsType<string[]>(resultTwo);
            _ = Assert.IsType<string[]>(resultThree);
            _ = Assert.IsType<string[]>(resultFour);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);
        }
        #endregion
    }
}
