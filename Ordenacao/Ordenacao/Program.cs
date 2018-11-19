using System;

namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[10] {95650, 1022, 85,  100000, 5520, 1, 80659,  56000, 78500, 38752  };
        }

        static void BubbleSort(int[] vetorA, int length)
        {
            int temp = 0;


            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorA.Length - 1; j++)
                {
                    if (vetorA[j] > vetorA[j + 1])
                    {
                        temp = vetorA[j];
                        vetorA[j] = vetorA[j + 1];
                        vetorA[j + 1] = temp;
                    }
                }
            }
        }//Fim Bubble sort

        static void SelectionSort(int[] vetorA, int length)
        {
            int temp;


            for (int i = 0; i < vetorA.Length; i++)
            {
                int x = i;
                for (int j = 0; j < vetorA.Length; j++)
                {
                    if (vetorA[j] > vetorA[x])
                    {
                        x = j;
                    }
                }

                temp = vetorA[i];
                vetorA[i] = vetorA[x];
                vetorA[x] = temp;
            }
        }//Fim Selection Sort

        static void InsertionSort(int[] vetorA)
        {
            for (int i = 1; i < vetorA.Length; i++)
            {
                int j = i;
                while (j > 0 && vetorA[j - 1] > vetorA[i])
                {
                    vetorA[j] = vetorA[j - 1];
                    j--;
                }
                vetorA[j] = vetorA[i];
            }
        }//Fim Insertion Sort   

        static void QuickSort(int[] vetorA, int first, int last)
        {
            int baixo, alto, mid, x, temp;
            baixo = first;
            alto = last;
            mid = (int)((baixo + alto) / 2);
            x = vetorA[mid];

            while (baixo <= alto)
            {
                while (vetorA[baixo] < x)
                    baixo++;
                while (vetorA[alto] > x)
                    alto--;
                if (baixo < alto)
                {
                    temp = vetorA[baixo];
                    vetorA[baixo++] = vetorA[alto];
                    vetorA[alto--] = temp;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }

            }
            if (alto > first)
                QuickSort(vetorA, first, alto);
            if (baixo < last)
                QuickSort(vetorA, baixo, last);
        }//Fim Quick Sort

        static void Merge(int[] vetorA, int left, int mid, int right)
        {
            int[] leftvet = new int[mid - left + 1];
            int[] rightvet = new int[right - mid];

            Array.Copy(vetorA, left, leftvet, 0, mid - left + 1);
            Array.Copy(vetorA, mid + 1, rightvet, 0, right - mid);

            int i = 0;
            int j = 0;
            for (int x = left; x < right + 1; x++)
            {
                if (i == leftvet.Length)
                {
                    vetorA[x] = rightvet[j];
                    j++;
                }
                else if (j == rightvet.Length)
                {
                    vetorA[x] = leftvet[i];
                    i++;
                }
                else if (leftvet[i] <= rightvet[j])
                {
                    vetorA[x] = leftvet[i];
                    i++;
                }
                else
                {
                    vetorA[x] = rightvet[j];
                    j++;
                }
            }
        }//Fim Merge

        static void MergeSort(int[] vetorA, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(vetorA, left, mid);
                MergeSort(vetorA, mid + 1, right);

                Merge(vetorA, left, mid, right);
            }
        }//Fim Merge Sort
    }//Fim Class Program

    class B
    {
        static void Main()
        {
            int[] vetorB = new int[10] { 95650, 1022, 85, 100000, 5520, 1, 80659, 56000, 78500, 38752 };
        }

        static void BubbleSort(int[] vetorB, int length)
        {
            int temp = 0;


            for (int i = 0; i < vetorB.Length; i++)
            {
                for (int j =vetorB.Length - 1;j > i ; j--)
                {
                    if (vetorB[j] > vetorB[j - 1])
                    {
                        temp = vetorB[j];
                        vetorB[j] = vetorB[j - 1];
                        vetorB[j - 1] = temp;
                    }
                }
            }
        }//Fim Bubble sort

        static void SelectionSort(int[] vetorB, int length)
        {
            int temp;


            for (int i = vetorB.Length - 1;i > 0; i--)
            {
                int x = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (vetorB[j] < vetorB[x])
                    {
                        x = j;
                    }
                }

                temp = vetorB[x];
                vetorB[x] = vetorB[i];
                vetorB[i] = temp;
            }
        }//Fim Selection Sort

        static void InsertionSort(int[] vetorB)
        {
            for (int i = 1; i < vetorB.Length; i++)
            {
                int j = i;
                while (j > 0 && vetorB[j - 1] < vetorB[i])
                {
                    vetorB[j] = vetorB[j - 1];
                    j--;
                }
                vetorB[j] = vetorB[i];
            }
        }//Fim Insertion Sort

        static void QuickSort(int[] vetorA, int first, int last)
        {
            int baixo, alto, mid, x, temp;
            baixo = first;
            alto = last;
            mid = (int)((baixo + alto) / 2);
            x = vetorA[mid];

            while (baixo <= alto)
            {
                while (vetorA[baixo] > x) baixo++;
                while (vetorA[alto] < x) alto--;
                if (baixo < alto)
                {
                    temp = vetorA[baixo];
                    vetorA[baixo++] = vetorA[alto];
                    vetorA[alto--] = temp;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }

            }
            if (alto > first)
                QuickSort(vetorA, first, alto);
            if (baixo < last)
                QuickSort(vetorA, baixo, last);
        }//Fim Quick Sort

       static void Merge(int[] vetorB, int left, int right)
        {
            int mid = (left + right) / 2;
            int leftvet = left;
            int rightvet = mid + 1;
            int temp = left;

            while (leftvet <= mid && rightvet <= right)
            {
                if (vetorB[leftvet] >= vetorB[rightvet])
                {
                    temp = vetorB[leftvet++];
                }
                else
                {
                    temp = vetorB[rightvet++];
                }
                temp++;
            }

            while (leftvet <= mid)
            {
                temp = vetorB[leftvet++];
                temp++;
            }

            while (rightvet <= right)
            {
                temp = vetorB[rightvet++];
                temp++;
            }
        }//Fim Merge

        static void MergeSort(int[] vetorB, int left, int right)
        {
            if (left == right) return;
            int mid = (left + right) / 2;

            MergeSort(vetorB, left, mid);
            MergeSort(vetorB, mid + 1, right);

            Merge(vetorB, left, right);
        }
    }//Fim class B

    class C
    {
        static void Vet()
        {           
            int[] vetorC = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < vetorC.Length; i++)
            {
                vetorC[i] = rnd.Next(1, 100000);
            }
            
        }//Fim Vet

        static void BubbleSort(int[] vetorC, int length)
        {
            int temp = 0;


            for (int i = 0; i < vetorC.Length; i++)
            {
                for (int j = 0; j < vetorC.Length - 1; j++)
                {
                    if (vetorC[j] > vetorC[j + 1])
                    {
                        temp = vetorC[j];
                        vetorC[j] = vetorC[j + 1];
                        vetorC[j + 1] = temp;
                    }
                }
            }
        }//Fim Bubble sort

        static void SelectionSort(int[] vetorC, int length)
        {
            int temp;


            for (int i = 0; i < vetorC.Length; i++)
            {
                int x = i;
                for (int j = 0; j < vetorC.Length; j++)
                {
                    if (vetorC[j] > vetorC[x])
                    {
                        x = j;
                    }
                }

                temp = vetorC[i];
                vetorC[i] = vetorC[x];
                vetorC[x] = temp;
            }
        }//Fim Selection Sort

        static void InsertionSort(int[] vetorC)
        {
            for (int i = 1; i < vetorC.Length; i++)
            {
                int j = i;
                while (j > 0 && vetorC[j - 1] > vetorC[i])
                {
                    vetorC[j] = vetorC[j - 1];
                    j--;
                }
                vetorC[j] = vetorC[i];
            }
        }//Fim Insertion Sort   

        static void QuickSort(int[] vetorC, int first, int last)
        {
            int baixo, alto, mid, x, temp;
            baixo = first;
            alto = last;
            mid = (int)((baixo + alto) / 2);
            x = vetorC[mid];

            while (baixo <= alto)
            {
                while (vetorC[baixo] < x)
                    baixo++;
                while (vetorC[alto] > x)
                    alto--;
                if (baixo < alto)
                {
                    temp = vetorC[baixo];
                    vetorC[baixo++] = vetorC[alto];
                    vetorC[alto--] = temp;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }

            }
            if (alto > first)
                QuickSort(vetorC, first, alto);
            if (baixo < last)
                QuickSort(vetorC, baixo, last);
        }//Fim Quick Sort

        static void Merge(int[] vetorC, int left, int mid, int right)
        {
            int[] leftvet = new int[mid - left + 1];
            int[] rightvet = new int[right - mid];

            Array.Copy(vetorC, left, leftvet, 0, mid - left + 1);
            Array.Copy(vetorC, mid + 1, rightvet, 0, right - mid);

            int i = 0;
            int j = 0;
            for (int x = left; x < right + 1; x++)
            {
                if (i == leftvet.Length)
                {
                    vetorC[x] = rightvet[j];
                    j++;
                }
                else if (j == rightvet.Length)
                {
                    vetorC[x] = leftvet[i];
                    i++;
                }
                else if (leftvet[i] <= rightvet[j])
                {
                    vetorC[x] = leftvet[i];
                    i++;
                }
                else
                {
                    vetorC[x] = rightvet[j];
                    j++;
                }
            }
        }//Fim Merge

        static void MergeSort(int[] vetorC, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(vetorC, left, mid);
                MergeSort(vetorC, mid + 1, right);

                Merge(vetorC, left, mid, right);
            }
        }//Fim Merge Sort
    }//Fim class C
}//Fim Namespace
