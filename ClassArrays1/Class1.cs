using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArrays1
{
    public class Class1
    {
        public static double SumNegetivesArray(double[] arr)
        {
            double SumNegetiveArray = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    SumNegetiveArray += arr[i];
                }
            }
            return SumNegetiveArray;
        }//сума негативних елементів масиву
        public static double MaxElement(double[] arr)
        {
            double MaxElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (MaxElement < arr[i])
                {
                    MaxElement = arr[i];
                }
            }
            return MaxElement;
        }//максимальний елемент масиву
        public static int IndexMaxElement(double[] arr)
        {
            int IndexMaxElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[IndexMaxElement] < arr[i])
                {
                    IndexMaxElement = i;
                }
            }
            return IndexMaxElement;
        }//індекс максимального елементу масива
        public static double MaxAbsElement(double[] arr)
        {
            double MaxAbsElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(MaxAbsElement) < Math.Abs(arr[i]))
                {
                    MaxAbsElement = arr[i];
                }
            }
            return MaxAbsElement;
        }//максимальний елемент масиву за модулем
        public static double SumIndexesPositiveElements(double[] arr)
        {
            double SumIndexesPositiveElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    SumIndexesPositiveElements += i;
                }
            }
            return SumIndexesPositiveElements;
        }//сума індексів додатніх елементів
        public static int CountWholeElements(double[] arr)
        {
            int CountWholeElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Convert.ToInt32(arr[i]) == arr[i])
                {
                    CountWholeElements++;
                }
            }
            return CountWholeElements;
        }//кількість цілих елементів
        public static double[] SortArray(double[] arr)
        {
            double[] sortarr = new double[arr.Length];
            double[] indexarr = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                indexarr[i] = 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (indexarr[j] == 1)
                    {
                        sortarr[i] = arr[j];
                        indexarr[j] = 0;
                        break;
                    }
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (sortarr[i] < arr[j] && indexarr[j] == 1)
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {
                            if (sortarr[i] == arr[k])
                            {
                                indexarr[k] = 1;
                                break;
                            }
                        }

                        sortarr[i] = arr[j];
                        indexarr[j] = 0;
                    }

                }
            }
            return sortarr;
        }//сортування масиву за спаданням
        public static double[] DeleterNegetiveElements(double[] arr)
        {
            int kNegetiveElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    kNegetiveElements++;
                }
            }
            double[] ArrayWithoutNegetiveEloements = new double[arr.Length - kNegetiveElements];
            for (int i = 0; i < arr.Length - kNegetiveElements;)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] >= 0)
                    {
                        ArrayWithoutNegetiveEloements[i] = arr[j];
                        i++;
                    }
                }
            }
            return ArrayWithoutNegetiveEloements;
        }//видалення негативних елементів
    }
}
