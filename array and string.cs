using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampletest
{
    class sample
    {
        private const int V = 1;

        public void method()
        {
          /* string input;
            Console.WriteLine("1");
            input = Console.ReadLine();
            Console.WriteLine("the string you entered is : "+input);
            Console.WriteLine("2");
            input = Console.ReadLine();
            Console.WriteLine("the length of the string "+input.Length);
            Console.WriteLine("3");
            for(int i=0;i<input.Length;i++)
            {

                Console.Write("{0}\t",input[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("4");

            for (int i = input.Length-1; i>=0; i--)
            {

                Console.Write("{0}\t", input[i]);
            }
            Console.WriteLine("5 enter new string");
            string input1 = Console.ReadLine();

            int count = 1;
            for (int i = 0; i < input1.Length; i++)
            { 
                if(input1[i]== ' ')
                {
                    count = count + 1;
                }
                
            }
            Console.Write("the count is" + count);

            Console.WriteLine("\n");
            Console.WriteLine("6 enter new string");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            
            if (str1.Length == str2.Length)
            {

                if (str1 == str2)
                {
                    
                    Console.WriteLine("both strings length are equal and both strings are equal");
                    
                }
                else
                {
                    Console.WriteLine("not equal");
                }
                

            }
            Console.WriteLine("\n");
            Console.WriteLine("7 enter new string");
            string str3 = Console.ReadLine();
            int alpha = 0,num=0,spl=0;
            for (int i=0;i<str3.Length;i++)
            {
                if(str3[i]>='a' && str3[i]<='z')
                {
                    
                    alpha = alpha +1;
                }
                else if(str3[i]>='0' && str3[i]<='9')
                {
                    
                    num = num + 1;

                }
                else
                {
                    
                        spl = spl + 1;
                }
            }
            Console.WriteLine(alpha);
            Console.WriteLine(num);
            Console.WriteLine(spl);

            Console.WriteLine("\n");
            Console.WriteLine("8 enter new string");
            string str4 = Console.ReadLine();
            string str5;


            str5 =string.Copy(str4);
            Console.WriteLine("after copy");
            Console.WriteLine(str5);
            Console.WriteLine(str5.Length);
            Console.WriteLine("9 enter new string");
            string str6= Console.ReadLine();
            int vow=0,cons=0;
            for(int i=0;i<str6.Length;i++)
            {
                if(str6[i]=='a'|| str6[i] == 'e' || str6[i] == 'i' || str6[i] == 'o' || str6[i] == 'u')
                {
                    vow = vow + 1;
                    
                }
                else
                {
                    cons = cons + 1;
                }
            }
            Console.WriteLine("the vowel count is"+vow);
            Console.WriteLine("the consonant count is"+cons);*/
            Console.WriteLine("10 enter new string");
            string str7;
            str7 = Console.ReadLine();
            int[] fre = new int[255];
            for(int i=0;i<fre.Length;i++)
            {
                fre[i] = 0;
            }
            for(int j=0;j<str7.Length;j++)
            {
                int val = (int)str7[j];
                fre[val] = fre[val] + 1;

            }
            int repeat = 0;
            for(int j=0;j<fre.Length;j++)
            {
              if(fre[j] > fre[repeat])
                {
                    repeat = j;
                }

            }
            Char CH = (char)repeat;
            Console.WriteLine("max value and repeated tiems" + CH + fre[repeat]);
            Console.WriteLine("11 enter new string");
            string str8=Console.ReadLine();

            int[] ar=new int[str8.Length];
            for (int i = 0; i < str8.Length; i++)
            {
                int ch = (int)str8[i];

                ar[i] = ch;
                
            }
            Array.Sort(ar);
           for (int i = 0; i < str8.Length; i++)
            {
                char ch = (char)ar[i];

                Console.WriteLine(ch);

            }
           Console.WriteLine("12 enter new string");
            
            string arr; 
            arr=Console.ReadLine();
            int[] num1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                int ch = (int)arr[i];
                Console.WriteLine(ch);
                num1[i] = ch;

            }
           
            int temp;
           
                for (int i = 0; i < num1.Length - 1; i++)
                {
                    if (num1[i] > num1[i + 1])
                    {
                        temp = num1[i + 1];
                        num1[i + 1] = num1[i];
                        num1[i] = temp;
                    }
                
            }
            Console.WriteLine("\n");
            for (int i=0;i<num1.Length;i++)
            {
                Console.WriteLine(num1[i]);
                char ch = (char)num1[i];
                Console.WriteLine(ch);
            }
           






        }
        public void method2()
        {
             Console.WriteLine("13 - array");
            int n = Convert.ToInt32(Console.ReadLine());
             int[] arr=new int[n];

            for(int r=0;r<arr.Length;r++)
             {
                 Console.WriteLine("element{0}", r);
                 arr[r]= Convert.ToInt32(Console.ReadLine());


             }
             Console.Write("the elements in array");
             for (int p = 0; p < arr.Length; p++)
             {

                 Console.Write(arr[p]);

             }
             Console.WriteLine("\n 14 - array");
             int e = Convert.ToInt32(Console.ReadLine());
             int[] arr1 = new int[e];

             for (int q = 0; q < arr1.Length; q++)
             {
                 Console.WriteLine("element{0}", q);
                 arr1[q] = Convert.ToInt32(Console.ReadLine());


             }
             Console.WriteLine("\nthe values in array");
             for (int r = 0; r < arr1.Length; r++)
             {

                 Console.Write(arr1[r]);

             }
             Console.Write(" \n the reverse elements");
             Console.Write("\n");
             for (int t = arr1.Length-1; t >= 0; t--)
             {

                 Console.Write(arr1[t]);

             }
            Console.WriteLine("\n 15 - array");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[s];

            for (int z = 0; z < arr2.Length; z++)
            {
                Console.WriteLine("element{0}", z);
                arr2[z] = Convert.ToInt32(Console.ReadLine());


            }
           
            int sum = 0;
            for (int d = 0; d < arr2.Length; d++)
            {

                sum = sum + arr2[d];

            }
            Console.WriteLine("sum of elements in array" +sum);

            Console.WriteLine("\n 16 - array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr3 = new int[size];
            int[] arr4 = new int[size];

            for (int a = 0; a < arr3.Length; a++)
            {
                Console.WriteLine("element{0}", a);
                arr3[a] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Copy(arr3,0,arr4,0,arr3.Length);
            for (int w = 0; w < arr4.Length; w++)
            {
                Console.Write(arr4[w]);
            }
            Console.WriteLine("\n 17 - array");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] arr41 = new int[size1];
            
            for (int y = 0; y < arr41.Length; y++)
            {
                Console.WriteLine("element{0}", y);
                arr41[y] = Convert.ToInt32(Console.ReadLine());


            }
            int[] nu=new int[arr41.Length];

            for (int v = 0; v < arr41.Length; v++)
            {
                
                for (int t = v+1; v < arr41.Length-1; t++)
                {
                    if (arr41[v] == arr41[t])
                    {
                        Console.WriteLine(arr41[v]);
                        

                    }

                }
               


            }
            Console.WriteLine("\n 18 - array");
            int si = Convert.ToInt32(Console.ReadLine());
            int[] arr5 = new int[si];
            
            for (int o = 0; o< arr5.Length; o++)
            {
                Console.WriteLine("element{0}", o);
                arr5[o] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("\n 19 - array");
          int  max = arr5[0];
           int min = arr5[0];
            for (int c = 1; c <arr5.Length; c++)
            {
                if (arr5[c] > max)
                {
                    max = arr5[c];
                }
                if (arr5[c] < min)
                {
                    min = arr5[c];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);

            int i, j, sum1 = 0;
            int[,] example = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("enter the number");
                    example[i, j] = int.Parse(Console.ReadLine());
                    sum1 = sum1 + example[i, j];

                }

            }

            Console.Write("THE MATRIX");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {

                    Console.Write("{0}\t", example[i, j]);
                }

            }
            Console.WriteLine("THE SUM OF THE MATRIX" + sum1);

            Console.WriteLine("\n 20 - array");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr9 = new int[size2];
            for (int l = 0; l < arr9.Length; l++)
            {
                Console.WriteLine("element{0}", i);
                arr9[l] = Convert.ToInt32(Console.ReadLine());
            }
            for(int m=0;m<arr9.Length;m++)
            {
                if((arr9[m]%2) != 0)
                {
                    Console.WriteLine(arr9[m]);
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.method();
            //obj.method2();
            Console.ReadKey();
        }
    }
}
