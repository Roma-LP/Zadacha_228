using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_228
{
    class Test
    {
        public static void FunkOne(ArrayList A, ArrayList B)
        {
            int index = 0;
            for (int i = 0; i < B.Count; i++)
            {
                if ((int)B[i] > (int)A[index])  // проверяем каждое новое цисло В[] из А[]
                {
                    while (true)
                    {
                        if ((int)B[i] > (int)A[index])
                        {
                            if (A.Count == 1+index)
                            {
                                A.Add(B[i]);
                                break;
                            }
                            else
                            {
                                index++;
                            }
                        }
                        else
                        {
                            A.Insert(index, B[i]);
                            index++;
                            break;
                        }
                    }

                }
                else
                {
                    A.Insert(index, B[i]);
                    index++;
                }
            }

            // перебор значений
            foreach (object o in A)
            {
                Console.Write(o + "\t");
            }
            Console.WriteLine();
            // перебор значений
            foreach (object o in B)
            {
                Console.Write(o + "\t");
            }

        }
    }
}
