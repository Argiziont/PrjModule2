using System;
using System.Collections.Generic;
using System.Text;

namespace MathSolverLibrary
{
    public interface IMathSolver
    {
        long Summarize(int[] array, int degree);
        long Summarize(long[] array, int degree);
        double Summarize(double[] array, int degree);
        double Summarize(float[] array, int degree);
        long Differentiate(int[] array, int degree);
        long Differentiate(long[] array, int degree);
        double Differentiate(double[] array, int degree);
        double Differentiate(float[] array, int degree);
        long Multiply(int[] array, int degree);
        long Multiply(long[] array, int degree);
        double Multiply(double[] array, int degree);
        double Multiply(float[] array, int degree);
        long Divide(int[] array, int degree);
        long Divide(long[] array, int degree);
        double Divide(double[] array, int degree);
        double Divide(float[] array, int degree);
        string[] ArbitrarySystemComparison(int[] array,int radix);
        string[] ArbitrarySystemComparison(long[] array, int radix);
        string[] ArbitrarySystemComparison(double[] array, int radix);
        string[] ArbitrarySystemComparison(float[] array, int radix);
    }
}
