using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Please enter x value");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter y value");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine(x / y);

                int[] arr = new int[4];
                for (int i = 0; i < arr.Length + 1; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            catch(FormatException ex1)
            {
                Console.WriteLine(" Please input only number. {0} ", ex1.Message);
            }
            catch(DivideByZeroException ex2)
            {
                Console.WriteLine("Please donot input y value as 0 {0}", ex2.Message);
            }
            catch(OverflowException ex3)
            {
                Console.WriteLine("Please enter x and y value in between {0} and {1} {2}", int.MinValue, int.MaxValue, ex3.Message);
            }
            
            catch(DivideByOddNumber ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("close connection");
            }
            Console.WriteLine("End of the Program ");
            
        }
    }
}
