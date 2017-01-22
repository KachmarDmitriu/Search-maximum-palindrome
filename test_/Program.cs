using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, rezult, reverse_rezult, NumCellArr;

            int[] palindrom;
            palindrom = new int[10000];       

            NumCellArr = 0;

                for (a = 999; a >= 100; --a)
                {
                    for (b = 999; b >= 100; --b)
                    {
                        rezult = a * b;
                        reverse_rezult = ReversNum(rezult);

                        Console.WriteLine(rezult);
                        Console.WriteLine(reverse_rezult);

                        if (rezult == reverse_rezult)
                            {      
                                for (int i = NumCellArr; i < palindrom.Length;i++)  //запись в массив
                                {
                                    NumCellArr++;
                                    palindrom[i] = rezult;
                                    break;              
                                }
                            }
                      }
                }

            int MaxPalindrom = palindrom.Max<int>(); //поиск максимального элемента массива
            Console.WriteLine("Максимальное значение палиндрома");
            Console.WriteLine(MaxPalindrom);

            Console.ReadKey();
            }


            static int ReversNum(int inputData)
            {
                int rev = 0;
                int numb = inputData;

                while (numb > 0)
                {
                    int rem = numb % 10;
                    rev = (rev * 10) + rem;
                    numb = numb / 10;
                }
                return (rev);         
            }
        }
}