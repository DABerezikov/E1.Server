using System;
using System.Collections.Generic;
using System.Linq;

namespace E1.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exerciseCount;
            
            int inputDateCount = int.Parse(Console.ReadLine());
          
            int outTime;
            string result;
                        
            for (int i = 0; i < inputDateCount*2; i++)
            {

                if (int.TryParse(Console.ReadLine(), out exerciseCount))
                {
                    result = null;
                    outTime = 0;

                    for (int j = 0; j < exerciseCount; j++)
                    {
                        var tasks = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                        
                        
                        
                            if (outTime >= tasks[0])
                            {
                                outTime+=tasks[1];
                            }
                            else
                            {
                                outTime = tasks[0] + tasks[1];
                            }
                        
                        result += (outTime + " ");
                    }

                }
                else
                {
                    continue;
                }                            
                Console.WriteLine(result);

            }
            
        }
    }
}
