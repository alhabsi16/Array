using System.Linq;

namespace array
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 3, 5, 7, 9, 11 , 2, 20 , 3, 15,6};
            float sum =0;
            int i = 0;
            int Even =0;
            int Odd =0;
            int first = a[0];
            int second = a[0];

            for (; i < a.Length; i++)
            {
                sum = sum + a[i];
                {
                    if (i % 2 == 0)

                        Even = Even + 1;
                    else
                        Odd = Odd + 1;
                }

                {
                    if (a[i] > first)
                    {
                        second = first;
                        first = a[i];
                    }
                    else if (a[i] > second && a[i] > first)
                    {
                        second = a[i];
                    }
                        
                }

            }
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Size = {0}" , i);
            Console.WriteLine("Average = {0}", sum = sum / i);
            Console.WriteLine("");
            Console.WriteLine("Min Number = {0}", a.Min()  );
            Console.WriteLine("Max Number = {0}", a.Max()  );
            Console.WriteLine("");
            Console.WriteLine("Even Number = {0}", Even);
            Console.WriteLine("Odd Number = {0}", Odd);
            Console.WriteLine("");
            Console.WriteLine("second largest Number = {0}", first );


        }
    }
}