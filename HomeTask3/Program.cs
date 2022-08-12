using System;

namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=================================TASK3==3 EDEDIN MUQAYISESI========
            //===================================================================
            Console.WriteLine("------------------TASK3---------------");
            Console.Write("Input the 1st number: ");
            string first=Console.ReadLine();
            int _first =int.Parse(first);
            Console.Write("Input the 2nd number: ");
            string second=Console.ReadLine();   
            int _second =int.Parse(second);
            Console.Write("Input the 3rd number: ");
            string third=Console.ReadLine();
            int _third=int.Parse(third);
            if (_first>_second&&_first>_third)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (_second>_first&&_second>_third)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
            //====================================================================
            //================================TASK4===============================
            Console.WriteLine("------------------TASK4---------------");
            Console.WriteLine("Enter the number of week: ");
            string day= Console.ReadLine();
           int days= int.Parse(day);
           switch (days)
           {
               case 1:
                   Console.WriteLine("Monday");
                   break;
               case 2:
                   Console.WriteLine("Tuesday");
                   break;
               case 3:
                   Console.WriteLine("Wednesday");
                   break;
               case 4:
                   Console.WriteLine("Thursday");
                   break;
               case 5:
                   Console.WriteLine("Friday");
                   break;
               case 6:
                   Console.WriteLine("Saturday");
                   break;
               case 7:
                   Console.WriteLine("Sunday");
                   break;

           }

            //=================================================
            //===================================================TASK 5
            Console.WriteLine("------------------TASK5---------------");
            Console.Write("Enter the first interger: ");
           string str_a= Console.ReadLine();
           int a=int.Parse(str_a);
           Console.Write("Enter the second interger: ");
           string str_b= Console.ReadLine();
           int b=int.Parse(str_b);
           Console.WriteLine("Here are the options:");
           Console.WriteLine("1-Addition.");
           Console.WriteLine("2-Substraction.");
           Console.WriteLine("3-Multiplication.");
           Console.WriteLine("4-Division.");
           Console.WriteLine("5-Exit");
           Console.Write("Input your choise: ");
           string choise= Console.ReadLine();
           int i_ch=int.Parse(choise);
           if (i_ch==1)
           {
               Console.Write("The addition of "+a+" and "+b+" is: ");
               Console.Write(a+b);
           }
           else if (i_ch==2)
           {
               Console.Write("The substraction of "+a+" and "+b+" is: ");
               Console.Write(a - b);
           }
           else if (i_ch == 3)
           {
               Console.Write("The multiplication of "+a+" and "+b+" is: ");
               Console.Write(a * b);
           }
           else if (i_ch == 4)
           {
               Console.Write("The division of " + a + " and " + b + " is: ");
               Console.Write(a/b);
           }
           else if(i_ch == 5)
           {
               Console.WriteLine("Exited the menu.");
           }
            Console.WriteLine(" ");
            //==============================================================
            //===============================================================TASK7
            Console.WriteLine("------------------TASK7---------------");
            Console.Write("Enter the number: ");
            string str_numb = Console.ReadLine();
            int numb = int.Parse(str_numb);
            int sum = 0;
            while (numb!=0)
            {
                sum = sum + numb % 10;
                numb = numb / 10;
                
            }
            Console.WriteLine(sum);
            //===================================================
            //==================================================TASK1
            Console.WriteLine("------------------TASK1---------------");
            DateTime dt = new DateTime(2001,2,8) ;
            Console.WriteLine(dt.DayOfWeek);
            //===================================================
            //===========================================TASK2
            Console.WriteLine("------------------TASK2---------------");
            DateTime now = DateTime.Now;
            DateTime bDay = new DateTime(2001, 2, 8);
            Console.WriteLine(now-bDay);
            //========================================
            //=============================================TASK6
            Console.WriteLine("------------------TASK6---------------");
            int n = 0;
            int r=0;
            int summ=0;
            int cha;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            cha = n;
            while (n > 0)
            {
                r = n % 10;
                summ = (summ * 10) + r;
                n = n / 10;
            }
            if (cha == summ)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");


        }

    }
}
