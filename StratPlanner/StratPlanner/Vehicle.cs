using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratPlanner
{
    class Vehicle
    {
        static uint nbInstance=0;

        double trackPosition = 100;
        double absoluteRacePosition = 0;

        uint currentLap;

        uint vehicleID;

        public Vehicle() {
            ++nbInstance;
            vehicleID = nbInstance;
            System.Console.WriteLine("Creation Vehicle n° " + vehicleID);
        }

        ~Vehicle() {
            nbInstance--;
        }
    }
}

