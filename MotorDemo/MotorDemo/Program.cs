
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorDemo
{
    class Program
    {

        private static void Motorsteuerung()
        {
            de.meineWerkstatt.auto.Motor.GibGas();
            de.meineWerkstatt.ebike.Motor.GibGas();
        }

        static void Main(string[] args)
        {
            Motorsteuerung();
        }

    }
}
