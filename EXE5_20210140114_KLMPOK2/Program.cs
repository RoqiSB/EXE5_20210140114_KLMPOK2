using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140114_KLMPOK2
{
    class Node
    {
        int ROQI, BACHRI, max = 5;
        int[] queue_array = new int[5];
        public Node()
        {
            ROQI = -1;
            BACHRI = -1;
        }
        public void insert(int element)
        {
            if ((ROQI == 0 && BACHRI == max - 1) || (ROQI == BACHRI + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            if (ROQI == -1)
            {
                ROQI = 0;
                BACHRI = 0;
            }
            else
            {
                if (BACHRI == max - 1)
                    BACHRI = 0;
                else
                    BACHRI = BACHRI + 1;
            }
            queue_array[BACHRI] = element;
        }
        public void remove()
        {
            if (ROQI == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe Element deleted fromt he queue is: " + queue_array[ROQI]
                + "\n");
            if (ROQI == BACHRI)
            {
                ROQI = -1;
                BACHRI = -1;
            }
            else
            {
                if (ROQI == max - 1)
                    ROQI = 0;
                else
                    ROQI = ROQI + 1;
            }
        }
        public void display()
        {
            int ROQI_position = ROQI;
            int BACHRI_position = BACHRI;
            if (ROQI == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are ........................\n");
            if (ROQI_position <= BACHRI_position)
            {
                while (ROQI_position <= BACHRI_position)
                {
                    Console.Write(queue_array[ROQI_position] + "    ");
                    ROQI_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while (ROQI_position <= max - 1)
                {
                    Console.Write(queue_array[ROQI_position] + "    ");
                    ROQI_position++;
                }
                ROQI_position = 0;
                while (ROQI_position <= BACHRI_position)
                {
                    Console.Write(queue_array[ROQI_position] + "     ");
                    ROQI_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Node queue = new Node();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. INSERT");
                    Console.WriteLine("2. DELETE");
                    Console.WriteLine("3. DISPLAY");
                    Console.WriteLine("4. EXIT");
                    Console.Write("\nEnter your choice (1-4):   ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number:  ");
                                string num = (string)(Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(ch);
                            }
                            break;
                        case '2':
                            {
                                queue.remove();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option !!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }
}
