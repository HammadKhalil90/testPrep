using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n;
            //Console.Write("Enter the Number= ");
            //n = int.Parse(Console.ReadLine());
            //ArmStrongFunction(n);
            //string number = "456";
            //var stringToNumber = StringToNumber(number);
            //Console.WriteLine(stringToNumber);
            //A a = new B();
            //B b = new B();
            
            //int[] num = { 5, 34, 78, 2, 45, 1, 99, 23 };

            //printTwoMaxNumbers(num);
            int[] leftRotate = LeftRotate(5,4);
            Console.WriteLine("after rotate");
            for (int i = 0; i < leftRotate.Length; i++)
            {
                Console.WriteLine(leftRotate[i]);
            }
            Console.ReadLine();
        }

        public static int[] LeftRotate(int n , int shift)
        {
            int[] array = new int[n];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            int length = array.Length;
            while (shift != 0)
            {
                temp = array[0];
                for (int i = 0; i < length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[length - 1] = temp;
                shift --;
            }
            return array;
        }
        public static void ArmStrongFunction(int n)
        {
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                int r = n%10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");

            Console.ReadLine();
        }

        public static int StringToNumber(string num)
        {
            int zero = (int) '0';
            int sum = 0;
            foreach (char c in num)
            {
                int i = (int) c;
                sum = (sum*10) + (i - zero);
            }
            return sum;
        }
        public static void printTwoMaxNumbers(int[] nums)
        {
            int largest =nums[0];
            int second = nums[0];
            int smallest = nums[0];
            foreach (int i in nums)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
                if (smallest > i)
                {
                    smallest = i;
                }
               
            }
            Console.WriteLine("First Max Number: " + largest);
            Console.WriteLine("Second Max Number: " + second);
            Console.WriteLine("smallest Number: " + smallest);
        }
    }
    public class A
    {
        public A() //priavte
        {

        }
    }
    public class B : A
    {
       
    }
}
