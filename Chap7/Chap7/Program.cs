using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chap7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-----------------------------------------------------------------
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }

            //2-----------------------------------------------------------------

            bool arrayEqual = true;

            Console.WriteLine("Enter first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrayA = new int[length];
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write("Enter element : {0}", i);
                arrayA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter second array: ");
            if (length != Int32.Parse(Console.ReadLine()))
            {
                Console.WriteLine("\n Arrays are different ");
            }
            else
            {

                int[] arrayB = new int[length];

                for (int i = 0; i < arrayB.Length; i++)
                {
                    Console.WriteLine("Enter element: {0}", i);
                    arrayB[i] = Int32.Parse(Console.ReadLine());

                }

                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (arrayA[i] != arrayB[i])
                    {
                        Console.WriteLine("Arrays are different");

                        arrayEqual = false;
                        break;

                    }
                }
                if (arrayEqual)
                {
                    Console.WriteLine("Arrays are equal");


                }


            }

            //3----------------------------------------------------------------------------------


            bool arraysEqual = true;
            char[] arrA = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arrB = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arrA.Length > arrB.Length)
            {
                Console.WriteLine("Second array is lexicographicaly first.");
            }
            else if (arrA.Length < arrB.Length)
            {
                Console.WriteLine("First array is lexicographicaly first.");
            }
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] < arrB[i])
                    {
                        Console.WriteLine("First array is lexicograp. first.");
                        arraysEqual = false;
                        break;
                    }
                    if (arrA[i] > arrB[i])
                    {
                        Console.WriteLine("Second array is lexicograph. first.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("Arrays are lexicograph. equal.");

            }


            //4--------------------------------------------------------------------


            int count = 1, tempCount = 1, number = 0;

            Console.Write("Enter array: ");
            int length1 = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length1];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element:{0} ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}, ", number);
            }


            //5----------------------------------------------------------------------------------

            Console.Write("Enter array length: ");
            int length2 = Int32.Parse(Console.ReadLine());

            int[] arr1 = new int[length2];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i] + 1 == arr1[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++) Console.Write("{0}, ", arr1[i]);


            //6-----------------------------------------------------------------------------------------



            int counter = 0, tempIndex, tempCounter;

            Console.Write("Enter array length: ");
            int length3 = Int32.Parse(Console.ReadLine());

            int[] arr2 = new int[length3];
            int[] result = new int[length3];

            for (int i = 0; i < length3; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr2[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length3; i++)
            {
                int[] tempResult = new int[length3];
                tempIndex = tempCounter = 1;
                tempResult[0] = arr2[i];

                for (int j = i + 1; j < length3; j++)
                {
                    if (arr2[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr2[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr2[j] > tempResult[tempIndex - 2] && arr2[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = arr2[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);


            //7-----------------------------------------------------------------------------------------------





            int sum = 0;

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K (K < N): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr3[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr3, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr3[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);



            //8-----------------------------------------------------------------------------------------------


            int k1, m, iMin, temp;

            Console.Write("Enter array : ");
            int length4 = Int32.Parse(Console.ReadLine());

            int[] arr4 = new int[length4];

            for (k1 = 0; k1 < length4; k1++)
            {
                Console.Write("Enter {0} element: ", k1);
                arr4[k1] = Int32.Parse(Console.ReadLine());
            }

            for (m = 0; m < length4 - 1; m++)
            {
                iMin = m;

                for (k1 = m + 1; k1 < length4; k1++) if (arr4[k1] < arr4[iMin]) iMin = k1;

                if (iMin != m)
                {
                    temp = arr4[m];
                    arr4[m] = arr4[iMin];
                    arr4[iMin] = temp;
                }
            }

            for (k1 = 0; k1 < length4; k1++)
            {
                Console.Write("{0} ", arr4[k1]);
            }


            //9------------------------------------------------------------------------------






            int sum1 = 0, tempSum;

            Console.Write("Enter array length: ");
            int length5 = Int32.Parse(Console.ReadLine());

            int[] arr5 = new int[length5];

            for (int i = 0; i < length5; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr5[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length5 - 1; i++)
            {
                tempSum = arr5[i];

                for (int j = i + 1; j < length5; j++)
                {
                    tempSum += arr5[j];
                    if (tempSum > sum1) sum1 = tempSum;
                }
            }

            Console.WriteLine("Result is {0}. ", sum1);



            //10---------------------------------------------------------------------------------




            int counter1 = 0, tempCounter1 = 1, foundNumber = 0;

            Console.Write("Enter array length: ");
            int length6 = Int32.Parse(Console.ReadLine());

            int[] arr6 = new int[length6];

            for (int i = 0; i < length6; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr6[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr6);

            for (int i = 0; i < length6 - 1; i++)
            {
                if (arr6[i] == arr6[i + 1]) tempCounter1++;
                else tempCounter1 = 1;
                if (tempCounter1 > counter1)
                {
                    counter1 = tempCounter1;
                    foundNumber = arr6[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", foundNumber, counter1);


            //11--------------------------------------------------------------------------------------
            int sum2 = 0, start = 0, end = 0;
            bool sumFound = false;

            Console.Write("Enter S: ");
            int s = Int32.Parse(Console.ReadLine());

            Console.Write("Enter array length: ");
            int length7 = Int32.Parse(Console.ReadLine());

            int[] arr7 = new int[length7];

            for (int i = 0; i < length7; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length7 - 1; i++)
            {
                sum = arr[i];

                for (int j = i + 1; j < length7; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound) break;
            }

            if (sumFound)
            {
                for (int i = start; i <= end; i++) Console.Write("{0},", arr[i]);
            }
            else
            {
                Console.WriteLine("No sum found.");
            }


            //12a-------------------------------------------------------------------------------------------

            Console.Write("Enter height: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            int x = Int32.Parse(Console.ReadLine());

            int a1 = 0;

            for (int i = 1; i <= y; i++)
            {
                Console.Write("{0} ", i);

                a1 += i;

                for (int j = 1; j < x; j++)
                {
                    a1 += y;
                    Console.Write("{0} ", a1);
                }

                a1 = 0;
                Console.WriteLine();
            }

            //12b----------------------------------------------------------------------------------------

            Console.WriteLine("Enter matrix : ");
            int n1 = Int32.Parse(Console.ReadLine());

            int[,] arr8 = new int[n1, n1];
            arr8[0, 0] = 1;

            for (int i2 = 1; i2 < arr8.GetLength(0); i2++)
                if (i2 % 2 == 1) arr8[0, i2] = arr8[0, i2 - 1] + n * 2 - 1;
                else arr8[0, i2] = arr8[0, i2 - 1] + 1;

            for (int i2 = 1; i2 < arr8.GetLength(0); i2++)
                for (int j = 0; j < arr8.GetLength(1); j++)
                    if (j % 2 == 1) arr8[i2, j] = arr8[i2 - 1, j] - 1;
                    else arr8[i2, j] = arr8[i2 - 1, j] + 1;

            for (int i2 = 0; i2 < arr8.GetLength(0); i2++)
            {
                for (int j = 0; j < arr8.GetLength(1); j++) Console.Write("{0, 4}", arr8[i2, j]);
                Console.WriteLine();
            }

            //12c----------------------------------------------------------------------------------

            Console.Write("Enter arr : ");
            int length8 = Int32.Parse(Console.ReadLine());

            int[,] arr9 = new int[length8, length8];
            arr9[length8 - 1, 0] = 1;
            int counter2 = 1;
            for (int row = length8 - 2; row >= 0; row--)
            {
                arr9[row, 0] = arr9[row + 1, 0] + counter2;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter2; diagonal++)
                {
                    arr9[newRow + 1, diagonal] = arr9[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter2++;
            }

            arr9[0, length8 - 1] = length8 * length8;
            int diagonalLength = 2;
            int posX = 1;
            int posY = length8 - 1;
            int prevX = 0;
            int prevY = length8 - 1;

            for (int i = 1; i < counter2 - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    arr9[posX, posY] = arr9[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = i + 1;
                posY = length8 - 1;
            }

            for (int i = 0; i < arr9.GetLength(0); i++)
            {
                for (int j = 0; j < arr9.GetLength(1); j++) Console.Write("{0, 4}", arr9[i, j]);
                Console.WriteLine();
            }

            //12d--------------------------------------------------------------------------------------


            Console.Write("Enter arr : ");
            int length9 = Int32.Parse(Console.ReadLine());

            int[,] arr10 = new int[length9, length9];
            int numConcentricSquares = (int)Math.Ceiling((length9) / 2.0);
            int sideLen = length9;
            int currNum = 0;

            for (int i = 0; i < numConcentricSquares; i++)
            {

                for (int j = 0; j < sideLen; j++) arr10[i + j, i] = ++currNum;

                for (int j = 1; j < sideLen - 1; j++) arr10[length9 - 1 - i, i + j] = ++currNum;

                for (int j = sideLen - 1; j > 0; j--) arr10[i + j, length9 - 1 - i] = ++currNum;

                for (int j = sideLen - 1; j > 0; j--) arr10[i, i + j] = ++currNum;

                sideLen -= 2;
            }


            for (int i = 0; i < arr10.GetLength(0); i++)
            {
                for (int j = 0; j < arr10.GetLength(1); j++) Console.Write("{0, 4}", arr10[i, j]);
                Console.WriteLine();
            }

            //13------------------------------------------------------------------------------------------


            int row1 = 0, col = 0, sum3 = -1000;

            Console.Write("Enter N: ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m1 = Int32.Parse(Console.ReadLine());

            int[,] arr11 = new int[n2, m1];

            for (int i = 0; i < n2; i++)
                for (int j = 0; j < m1; j++)
                {
                    Console.Write("Arr [{0}][{1}] = ", i, j);
                    arr11[i, j] = Int32.Parse(Console.ReadLine());
                }

            for (int tempRow = 0; tempRow < arr11.Length - 2; tempRow++)
                for (int tempCol = 0; tempCol < arr11.GetLength(0) - 2; tempCol++)
                {
                    int tempSum2 = arr11[row1, col] + arr11[row1, col + 1] + arr11[row1, col + 2] +
                        arr11[row1 + 1, col] + arr11[row1 + 1, col + 1] + arr11[row1 + 1, col + 2] +
                        arr11[row1 + 2, col] + arr11[row1 + 2, col + 1] + arr11[row1 + 2, col + 2];

                    if (tempSum2 > sum3)
                    {
                        row1 = tempRow;
                        col = tempCol;
                        sum3 = tempSum2;
                    }
                }

            Console.WriteLine("Result");
            Console.WriteLine("{0} {1} {2}", arr11[row1, col], arr11[row1, col + 1], arr11[row1, col + 2]);
            Console.WriteLine("{0} {1} {2}", arr11[row1 + 1, col], arr11[row1 + 1, col + 1], arr11[row1 + 1, col + 2]);
            Console.WriteLine("{0} {1} {2}", arr11[row1 + 2, col], arr11[row1 + 2, col + 2], arr11[row1 + 2, col + 2]);
            Console.WriteLine("The maximum sum is {0}.", sum3);

            //14----------------------------------------------------------------------------------------------

            int tempSeq = 1, seq = 1;
            string element = "e";

            Console.Write("Enter N: ");
            int n3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m2 = Int32.Parse(Console.ReadLine());

            string[,] arr12 = new string[n3, m2];

            for (int i = 0; i < n3; i++)
                for (int j = 0; j < m2; j++)
                {
                    Console.Write("Arr [{0}][{1}] = ", i, j);
                    arr12[i, j] = Console.ReadLine();
                }


            for (int rows = 0; rows < arr12.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr12.GetLength(1) - 1; cols++)
                {
                    if (arr12[rows, cols] == arr12[rows, cols + 1]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr12[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int cols = 0; cols < arr12.GetLength(1); cols++)
            {
                for (int rows = 0; rows < arr12.GetLength(0) - 1; rows++)
                {
                    if (arr12[rows, cols] == arr12[rows + 1, cols]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr12[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int i = 0; i < arr12.GetLength(0) - 1; i++)
                for (int j = 0; j < arr12.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < arr12.GetLength(0) - 1 && cols < arr12.GetLength(1) - 1; rows++, cols++)
                    {
                        if (arr12[rows, cols] == arr12[rows + 1, cols + 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr12[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i = 0; i < arr12.GetLength(0) - 1; i++)
                for (int j = 1; j < arr12.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < arr12.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (arr12[rows, cols] == arr12[rows + 1, cols - 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr12[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i = 0; i < seq; i++)
            {
                Console.Write("{0}, ", element);
            }


            //15-------------------------------------------------------------------------------




            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter a word: ");
            char[] word = (Console.ReadLine()).ToCharArray();

            for (int i = 0; i < word.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (word[i] == alphabet[j])
                    {
                        Console.Write("{0} ", j);
                    }


            //16---------------------------------------------------------------------------------------------

            Console.Write("Enter array : ");
            int length10 = Int32.Parse(Console.ReadLine());

            int[] arr13 = new int[length10];

            for (int i = 0; i < length10; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr13[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter searched number: ");
            int number1 = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr13, number1);

            if (index >= 0) Console.Write("Number is on {0} index.", index);
            else Console.Write("Number wasn't found.");

            //17-------------------------------------------------------------------------------------

            Console.Write("Enter array : ");
            int length11 = Int32.Parse(Console.ReadLine());

            int[] arr14 = new int[length11];

            for (int i = 0; i < length11; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr14[i] = Int32.Parse(Console.ReadLine());
            }

            MergeSort_Recursive(arr14, 0, arr14.Length - 1);

            for (int i = 0; i < arr14.Length; i++) Console.WriteLine(arr14[i]);

            //18---------------------------------------------------------------------------------------


            //19--------------------------------------------------------------------------------------
            List<int> nums = new List<int>();
            // 1 is not a prime number
            for (int i = 2; i <= 10000000; ++i) nums.Add(i);

            int p = 2;
            int indexAt = 0;
            bool limitReached = false;

            while (!limitReached)
            {
                for (int i = 0; i < nums.Count; ++i)
                {
                    int v = nums[i];
                    if (v % p == 0 && v != p) nums[i] = 0;
                }
                do
                {
                    p = nums[++indexAt];
                    if (indexAt >= nums.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (p == 0);
            }

            PrintList(nums, false);

            //20-------------------------------------------------------------------------------


            Console.Write("Enter array : ");
            int length12 = int.Parse(Console.ReadLine());

            int[] arr15 = new int[length12];

            for (int i = 0; i < length12; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr15[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter S: ");
            wantedSum = int.Parse(Console.ReadLine());

            int[] subset = new int[length12];

            for (int i = 1; i <= length12; i++) GenerateSubset(arr15, subset, 0, 0, i);

            if (!solution)
            {
                Console.WriteLine("No subset with sum {0} found.", wantedSum);
            }

            //21------------------------------------------------------------------------------------

            Console.Write("Enter N = ");
            int n5 = int.Parse(Console.ReadLine());

            Console.Write("Enter K = ");
            int size = int.Parse(Console.ReadLine());

            int[] arr16 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                arr16[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Sum of elements, s = ");
            int s1 = int.Parse(Console.ReadLine());

            int[] solution1 = findSolution(arr16, new bool[arr16.Length], 0, s, size);

            Console.WriteLine("Your solution:");
            for (int i = 0; i < solution1.Length; i++) Console.Write(solution1[i] + "; ");
            Console.ReadLine();

            //22----------------------------------------------------------------------------------------------


            int subset1 = 0, longestLength = 0;

            Console.Write("Enter arr : ");
            int length14 = Int32.Parse(Console.ReadLine());

            int[] arr17 = new int[length14];

            for (int i = 0; i < length14; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int m3 = (1 << length14);
            int[,] subsets = new int[m, length14];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < length14; j++) subsets[i, j] = i / (m / 2 / (1 << j)) % 2;

            for (int i = 0; i < m; i++)
            {
                int max = -1000, count1 = 0;

                for (int j = 0; j < length14; j++)
                {
                    if (subsets[i, j] > 0)
                    {
                        if (arr[j] >= max)
                        {
                            count1++;
                            max = arr[j];
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count)
                {
                    longestLength = count;
                    subset1 = i;
                }
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < length; i++) if (subsets[subset1, i] > 0) Console.Write(arr[i] + "; ");

            //23---------------------------------------------------------------------------------------------------

            Console.Write("Enter N: ");
            n3 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k2 = Int32.Parse(Console.ReadLine());

            int[] arr18 = new int[k];

            recSolution(arr18, 0);
       
        }
        

        //17------------------------------------------------------------------------

        static public void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid]) temp[tmp_pos++] = numbers[left++];
                else temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end) temp[tmp_pos++] = numbers[left++];

            while (mid <= right) temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                Merge(numbers, left, (mid + 1), right);
            }
        }
        //18--------------------------------------------------------------------


        public void PrintQuickSortStatus(int[] x,
  int startIndex, int a, int pivotIndex, int c, int endIndex)
        {
            string prefix, suffix;
            for (int i = 0; i < x.Length; i++)
            {
                prefix = string.Empty;
                suffix = string.Empty;
                if (i == startIndex)
                {
                    prefix = "(";
                }
                if (i == endIndex)
                {
                    suffix = ")";
                }
                if (i == a || i == pivotIndex || i == c)
                {
                    suffix += "*";
                }

                Console.Write("{0,1}{1,2}{2,-2}", prefix, x[i], suffix);
            }
            Console.WriteLine();
        }

        public void SwapValuesAroundPivot(int[] x,
                                                  int startIndex,
                                                  int endIndex)
        {
            if (startIndex < endIndex)
            {
                int pivotIndex = startIndex + (endIndex - startIndex) / 2;

                int a = startIndex, b = pivotIndex, c = endIndex;
                while (a < c)
                {
                    while (a < b && x[a] <= x[b])
                    {
                        a++;
                        PrintQuickSortStatus(
                           x, startIndex, a, pivotIndex, c, endIndex);
                    }
                    while (b < c && x[b] <= x[c])
                    {
                        c--;
                        PrintQuickSortStatus(
                           x, startIndex, a, pivotIndex, c, endIndex);
                    }
                    if (a < c)
                    {
                        int swap = x[a];
                        x[a] = x[c];
                        x[c] = swap;

                        if (a == b)
                        {
                            a = startIndex;
                        }
                        if (b == c)
                        {
                            c = endIndex;
                        }

                        Console.WriteLine("swap");
                        PrintQuickSortStatus(
                           x, startIndex, a, pivotIndex, c, endIndex);
                    }
                }

                SwapValuesAroundPivot(x, startIndex, pivotIndex - 1);
                SwapValuesAroundPivot(x, pivotIndex + 1, endIndex);
            }
        }

        public void PrintIntegersQuickSort()
        {
            int n = 15, max = 90;
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next() % max;
            }
            PrintQuickSortStatus(
               a, -1, -1, -1, -1, -1);

            SwapValuesAroundPivot(a, 0, n - 1);

            PrintQuickSortStatus(
               a, -1, -1, -1, -1, -1);
        }

        //19------------------------------------------------------------------

        static void PrintList(List<int> nums, bool printZero = true)
        {
            foreach (int n in nums)
            {
                if (!printZero && n == 0) continue;
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }

        //20--------------------------------------------------------------------

        static int wantedSum;
        static bool solution = false;

        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)
            {
                CheckSubsets(subset, elementsInSubset);
                return;
            }

            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            int sum = 0;

            for (int i = 0; i < elementsInSubset; i++) sum += subset[i];

            if (sum == wantedSum)
            {
                for (int i = 0; i < elementsInSubset; i++) Console.Write("{0} ", subset[i]);

                Console.WriteLine();
                solution = true;
            }
        }

        //21---------------------------------------------------------------------------


        public static int[] findSolution(int[] a, bool[] filter, int index, int s, int size)
        {
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = findSolution(a, filter, index + 1, s, size);

                if (x.Length > 0) return x;
                else
                {
                    filter[index] = false;
                    return findSolution(a, filter, index + 1, s, size);
                }
            }
            else
            {
                int sum = 0, count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += a[i];
                        count++;
                    }
                }

                int[] solution = new int[0];

                if (sum == s && count == size)
                {
                    solution = new int[count];
                    count = 0;

                    for (int i = 0; i < a.Length; i++) if (filter[i]) solution[count++] = a[i];
                }
                return solution;
            }
        }

            //23-----------------------------------------------------------------
            public static int n;
        static void recSolution(int[] array, int index)
            {
                if (index != array.Length)
                    for (int i = 1; i <= n; i++)
                    {
                        array[index] = i;
                        recSolution(array, index + 1);
                    }
                else
                {
                    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                    Console.WriteLine();
                }

            }


        //24----------------------------------------------------------------------

        public void PrintVariations()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 <= k && k <= n)
            {
                int variations = 1;
                for (int i = n; i > n - k; i--)
                {
                    variations *= i;
                }
                Console.WriteLine("Variations = " + variations);

                for (int i = 0; i < variations; i++)
                {
                  
                    bool[] isNotAvailable = new bool[n];

                    int numberOfAvailElems = n;
                    int variationsOfAvailElems = variations;

                    for (int j = 0; j < k; j++)
                    {
                        numberOfAvailElems--;

                       
                        if (numberOfAvailElems + 1 > 0)
                        {
                            variationsOfAvailElems /= (numberOfAvailElems + 1);
                        }
                        else
                        {
                            variationsOfAvailElems = 1;
                        }

                        
                        int lotId = i / variationsOfAvailElems;

                        int indexInListOfAvailElems =
                           lotId % (numberOfAvailElems + 1);

                        int x = 0;
                        int counterOfAvailElems =
                           indexInListOfAvailElems + 1;
                        while (x < n && counterOfAvailElems > 0)
                        {
                            if (!isNotAvailable[x])
                            {
                                counterOfAvailElems--;
                            }
                            x++;
                        }
                        isNotAvailable[x - 1] = true;

                        Console.Write("{0,3}", x);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine(
                   "Invalid data! Let 1 <= k <= n.");
            }
        }

        //25-----------------------------------------------------------------------

        public void PrintCombinations(int[] selected,
                                        int[] available,
                                        int k)
        {
            if (k == 0)
            {
                for (int j = 0; j < selected.Length; j++)
                {
                    Console.Write("{0,3}", selected[j]);
                }
                Console.WriteLine();
            }
            else if (available.Length == k)
            {
                for (int j = 0; j < selected.Length; j++)
                {
                    Console.Write("{0,3}", selected[j]);
                }
                for (int j = 0; j < available.Length; j++)
                {
                    Console.Write("{0,3}", available[j]);
                }
                Console.WriteLine();
            }
            else if (available.Length > k)
            {
                int[] newSelected = new int[selected.Length + 1];
                int[] newAvailable = new int[available.Length - 1];
                for (int j = 0; j < selected.Length; j++)
                {
                    newSelected[j] = selected[j];
                }
                newSelected[selected.Length] = available[0];
                for (int j = 1; j < available.Length; j++)
                {
                    newAvailable[j - 1] = available[j];
                }
                PrintCombinations(newSelected, newAvailable, k - 1);

                PrintCombinations(selected, newAvailable, k);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void PrintCombinationss()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 <= k && k <= n)
            {
                int variations = 1;
                for (int i = n; i > n - k; i--)
                {
                    variations *= i;
                }
                Console.WriteLine("Variations = " + variations);
                int combinations = variations;
                for (int i = k; i > 0; i--)
                {
                    combinations /= i;
                }
                Console.WriteLine("Combinations = " + combinations);

                int[] availableElements = new int[n];
                for (int i = 0; i < n; i++)
                {
                    availableElements[i] = i + 1;
                }

                PrintCombinations(new int[0], availableElements, k);
            }
            else
            {
                Console.WriteLine(
                   "Invalid data! Let 1 <= k <= n.");
            }
        }


        //26------------------------------------------------------------------------------------------------

        public void PrintMatricesOfDiagonallyAlignedNumbers()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Using formulas...");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int d = i + j, val = 0, count = 0;
                    if (d < n)
                    {
                        for (int k = 1; k <= d; k++)
                        {
                            count += k;
                        }
                        val = n * n - (count + d - j);
                    }
                    else
                    {
                        for (int k = 1; k <= 2 * n - d - 2; k++)
                        {
                            count += k;
                        }
                        val = count + j - d + n;
                    }
                    Console.Write("{0,4}", val);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int d = i - j, val = 0, count = 0;
                    if (d < 0)
                    {
                        for (int k = 1; k <= n; k++)
                        {
                            count += k;
                        }
                        for (int k = -1; k >= d + 1; k--)
                        {
                            count += (n + k);
                        }
                        val = i + 1 + count;
                    }
                    else
                    {
                        for (int k = 1; k <= n - d - 1; k++)
                        {
                            count += k;
                        }
                        val = count + j + 1;
                    }
                    Console.Write("{0,4}", val);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("2. Using a n-by-n matrix...");

            int[,] solution = new int[n, n];

            int row = n - 1, col = n - 1;
            solution[row, col] = 1;

            for (int k = 1; k < n * n; k++)
            {
                row--; col++;

                if (row < 0 || col > n - 1)
                {
                    col = row + col - n;
                    row = n - 1;
                    if (col < 0)
                    {
                        row += col;
                        col -= col;
                    }
                }
                solution[row, col] = k + 1;
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", solution[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            row = n - 1;
            col = 0;
            solution[row, col] = 1;

            for (int k = 1; k < n * n; k++)
            {
                row++; col++;

                if (row > n - 1 || col > n - 1)
                {
                    row -= (col + 1);
                    col -= col;
                    if (row < 0)
                    {
                        col -= row;
                        row -= row;
                    }
                }
                solution[row, col] = k + 1;
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", solution[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("3. Using a jagged array...");

            int[][] jag = new int[2 * n - 1][];

            for (int i = 0; i < n; i++)
            {
                jag[i] = new int[i + 1];
                jag[2 * n - 2 - i] = new int[i + 1];
            }
            int diagonal = 0, element = 0;
            for (int i = 0; i < n * n; i++)
            {
                jag[diagonal][element++] = i + 1;
                if (element > jag[diagonal].Length - 1)
                {
                    element = 0;
                    diagonal++;
                }
            }

            for (int i = 0; i < jag.Length; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    Console.Write("{0,4}", jag[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                diagonal = 2 * n - 2 - i;
                element = 0;
                for (int j = 0; j < n; j++)
                {
                    solution[i, j] = jag[diagonal][element];
                    diagonal--;
                    if (diagonal >= n - 1)
                    {
                        element++;
                    }
                }
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", solution[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                diagonal = n - 1 - i;
                element = 0;
                for (int j = 0; j < n; j++)
                {
                    solution[i, j] = jag[diagonal][element];
                    diagonal++;
                    if (diagonal <= n - 1)
                    {
                        element++;
                    }
                }
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", solution[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //27--------------------------------------------------------------------------------------

        public static int GetSizeOfArea(int[,] a, int i, int j,
                                    bool[,] visited)
        {
            int up, down, left, right;
            up = down = left = right = 0;

            visited[i, j] = true;

            if (i > 0
                && !visited[i - 1, j] && a[i, j] == a[i - 1, j])
            {
                up = GetSizeOfArea(a, i - 1, j, visited);
            }
            if (i + 1 < a.GetLength(0)
                && !visited[i + 1, j] && a[i, j] == a[i + 1, j])
            {
                down = GetSizeOfArea(a, i + 1, j, visited);
            }
            if (j > 0
                && !visited[i, j - 1] && a[i, j] == a[i, j - 1])
            {
                left = GetSizeOfArea(a, i, j - 1, visited);
            }
            if (j + 1 < a.GetLength(1)
                && !visited[i, j + 1] && a[i, j] == a[i, j + 1])
            {
                right = GetSizeOfArea(a, i, j + 1, visited);
            }

            return 1 + up + down + left + right;
        }

        public void PrintLargestAreaOfEqualNumbers()
        {
            Console.Write("Number of rows, m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Number of columns, n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your matrix is as follows:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            bool[,] visited = new bool[m, n];
            int maxSize = 1, val = a[0, 0], size = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!visited[i, j])
                    {
                        size = GetSizeOfArea(a, i, j, visited);
                        if (size > maxSize)
                        {
                            maxSize = size;
                            val = a[i, j];
                        }
                    }
                }
            }

            Console.WriteLine("Value: {0}, size: {1}.", val, maxSize);
        }
    }




}
    
