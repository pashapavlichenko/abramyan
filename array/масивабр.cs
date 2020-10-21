using System;
using System.Linq;
using System.Security.Cryptography;

namespace Series
{
    public class Tasks
    {
        public int Series16(int k, int[] arr)
        {
            int arrayLength = arr.Length;
            Array.Sort(arr, 0, arrayLength - 2);
            return (arr[arrayLength - 2] > k ? arrayLength - 1 : 0);
        }

        static void Series18(int n, int[] arr)
        {
            int a = 0;
            for (int i = a; i < n; i++)
            {
                int curElement = arr[i];
                Console.WriteLine(curElement);
                for (int j = i; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        return;
                    }
                    if (arr[j] != curElement)
                    {
                        i = j - 1;
                        break;
                    }
                }
            }
        }

        static void Series20(int n, int[] arr)
        {
            int c = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(arr[i] < arr[i + 1] ? arr[i] : (int?)null);
                amountOfNums++;
            }
            Console.WriteLine(c);
        }

        public int Series22(int n, double[] arr)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                    return i + 1;
            }
            return 0;
        }

        public int Series24(int n, int[] arr)
        {
            int sum = 0;
            int zeroCounter = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (zeroCounter == 2)
                    return sum;
                if (arr[i] == 0)
                    zeroCounter++;
                else
                    sum += arr[i];
            }
            return 0;
        }

        static void Series16(int k, int n, double[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], k));
            }
        }

        static void Series28(int n, double[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], n - i));
            }
        }

        static void Series30(int n, int k, int[][] arr)
        {
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr[i].Sum());
            }
        }

        static void Series32(int n, int k, int[][] arr)
        {
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(Array.IndexOf(arr, 2) + 1);
            }
        }

        static void Series34(int n, int k, int[][] arr)
        {
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(Array.IndexOf(arr[i], 2) == -1 ? 0 : arr[i].Sum());
            }
        }

        static bool isSorted(int[] arr)
        {
            int[] arrOrig = arr;
            int[] arrSorted = { };
            Array.Sort(arrSorted, 0, arrSorted.Length - 2);
            return (arrOrig == arrSorted);
        }

        static bool isReversed(int[] arr)
        {
            int[] arrOrig = arr;
            int[] arrReversed = { };
            Array.Sort(arrReversed, 0, arrReversed.Length - 2);
            Array.Reverse(arrReversed, 0, arrReversed.Length - 2);
            return (arrOrig == arrReversed);
        }

        static void Series36(int k, int[][] arr)
        {
            int numOfSortedArrays = 0;
            for (int i = 0; i < k; i++)
            {
                if (isSorted(arr[i]))
                    numOfSortedArrays++;
            }
            Console.WriteLine(numOfSortedArrays);
        }

      
        }
    }
