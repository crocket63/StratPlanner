using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            uint carNumber = 12;
            List<Vehicle> carList = new List<Vehicle>() ;

            for (int i=0; i < carNumber; ++i)
            {
                Vehicle v = new Vehicle();
                carList.Add(v);
            }
        }
    }
}