using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class employee
    {
       public int salaryCalculation(int hours)
        {

            if (hours > 10 && hours < 20)
            {
                return 25000;
            }

            else if (hours > 20 && hours < 30)
            {
                return 45000;
            }

            else if (hours > 30)
            {
                return 60000;
            }

            else
            {
                return 5000;
            }


        }
    }
}
