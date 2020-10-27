using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLib
{
    public class MyArray
    {
        public static double SumOfNegative(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    sum = sum + arr[i];
            }
            return sum;
        }
        public static double MaxElement(double[] arr)
        {
            double max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }
        public static int IndexOfMax(double[] arr)
        {
            double max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            int indexMax = Array.IndexOf(arr, max);
            return indexMax;
        }
        public static double MaxModElement(double[] arr)
        {
            double maxmod = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > maxmod)
                {
                    maxmod = Math.Abs(arr[i]);
                }

            }
            return maxmod;
        }
        public static int SumIndexOfPozitiveEl(double[] arr)
        {
            int sumindexofpozitiveEl = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sumindexofpozitiveEl += i;
                }

            }
            return sumindexofpozitiveEl;
        }
        public static int Numberofwhole(double[] arr)
        {
            int numberofwhole = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - Math.Truncate(arr[i]) == 0)
                {
                    numberofwhole++;
                }
            }
            return numberofwhole;
        }
        public static int GetpozitiveNumber(double[] arr)
        {
            int cout = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    cout++;
            }
            return cout;
        }
        public static double[] GetPozitiveElements(double[] arr)
        {
            double[] positivearray = new double[GetpozitiveNumber(arr)];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positivearray[j] = arr[i];
                    j++;
                }
            }
            return positivearray;
        }
        public static double[] SortArray(double[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }

    }
}