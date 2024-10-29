using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Test_2_Keshika
{
    public class USerProgramCode
    {
        public static List<int> GetElements(int input1, List<int> input2)
        {
            List<int> result = input2.ToList();

            if (result.Count == 0)
            {
                result.Add(-1);
            }
                for (int i = 0; i < result.Count - 1; i++)
                {
                    for (int j = 0; j < result.Count - 1 - i; j++) 
                    {
                        if (result[j] < result[j + 1])
                        {
                            int temp = result[j];
                            result[j] = result[j + 1];
                            result[j + 1] = temp;
                        }
                    }
                }


            return result;
        }
    }

}
