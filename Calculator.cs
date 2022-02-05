using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task_10_5_1
{
    internal class Calculator : IAddition
    {
        int A;
        int B;
        int C;


        public string Addition(string A, string B)
        {
            return A + B;   
        }
    }
}
