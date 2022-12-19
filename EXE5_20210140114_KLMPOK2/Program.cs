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
    }
}
