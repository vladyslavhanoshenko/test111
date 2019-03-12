using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace HW3._1
{

    class Program
    {
        public static bool isStop = true;
        public static bool isSorted = true;

        public static void ShortList(int[] array)
        {
            if (array.Length >= 2)
            {
                int[] newArr = new int[2];
                newArr[0] = array[0];
                newArr[newArr.Length - 1] = array[array.Length - 1];
                Console.WriteLine("Your short list is:");
                Console.WriteLine($"{newArr[0]} {newArr[1]}");
            }                    
        }


        public static void DescendOrder(ArrayList lst)
        {
            Console.WriteLine("Your sorted descending list is: ");
            int count = 0;
            int max = 0;
            int min = 1;

            foreach (var item in lst)
            {
                count++;
            }

            
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = (int)lst[i];       
            }
            for (int i = 0; i < count; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if(array[i] < min)
                {
                    min = array[i];
                }     
            }
          
            while(isSorted){

                for (int i = 0; i < array.Length - 1; i++)
                {
                    int temp = 0;
                    if(array[0] == max && array[array.Length-1] == min)
                    {
                        isSorted = false;
                    }
                    if (array[i] < array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
               
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ShortList(array);
           
        }

        public static void Start()
        {
            Console.WriteLine("Please enter int items to the list(enter 'stop' to finish:)");
            ArrayList lst = new ArrayList();
            int i = 0;



            while (isStop)
            {
                try
                {
                    string temp = Console.ReadLine();
                    if (temp == "stop")
                    {
                        isStop = false;
                        break;

                    }

                    lst.Add(Convert.ToInt32(temp));
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Entered value is not an int. Please enter a number: ");
                    continue;

                }
            }
            Console.WriteLine("Your list is:");

            foreach (var a in lst)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            DescendOrder(lst);

            Console.ReadLine();

        }

            static void Main(string[] args)
            {
            Start();
            }
        }
    }

