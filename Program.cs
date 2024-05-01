using Microsoft.VisualBasic.Devices;
using System;
using System.IO.Ports;
using System.Management;
namespace GettingPCInfo
{
    internal class Program

    {

        static void Main(string[] args)
        {

            //Getting data of pc into variables
            var versionName = new ComputerInfo().OSFullName;
            double physicalMemory = new ComputerInfo().TotalPhysicalMemory;
            double availablePhysicalMemory = new ComputerInfo().AvailablePhysicalMemory;
            string pingThisAddress = "192.168.0.1";
            var pingMe = new Network().Ping(pingThisAddress);
            var mouseWheel = new Mouse().WheelExists;
            var computerName = new ServerComputer().Name;
            var localTime = new Clock().LocalTime;

            Console.WriteLine("Version: " + versionName);
            //Console.WriteLine("Version: " + displayVersion);
            Console.WriteLine($"Physical Memory:  + {physicalMemory / 1000000000:N2} GB");
            Console.WriteLine($"Available Physical Memory:  + {availablePhysicalMemory/1000000000:N2} GB");
            Console.WriteLine($"Can you ping {pingThisAddress}:  {pingMe}");
            Console.WriteLine($"Do your mouse have a mouse wheel?: {mouseWheel}");
            Console.WriteLine($"Computer name: {computerName}");
            Console.WriteLine($"Local time: {localTime}");
            Console.ReadLine();
        }

        
    }
}
