using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string Engine { get; set; } = "V8";
        public string Model { get; set; } = "F150";
        public string Wheels { get; set; } = "Four";
        public int Seats { get; set; } = 4;
        public string Logo { get; set; } = "FordLogo";
        public string Make { get; set; } = "Ford";
        public bool PastSpeedLimit { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

        public void Speed()
        {
            if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} is going in four wheel drive.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} isn't going fast.");
            }
        }
        public void Drive()
        {
            if (PastSpeedLimit == true)
            {
                Console.WriteLine($"{GetType().Name} is now driving.");
            }
            else
            {
                Console.WriteLine("Going too slow!");
            }
        }
        public void Parked()
        {
            if (PastSpeedLimit == true)
            {
                Console.WriteLine($"{GetType().Name} is now parked.");
            }
            else
            {
                Console.WriteLine("Still driving!");
            }
        }
        public void MPH(bool isChanged)
        {
            PastSpeedLimit = isChanged;
        }
    }
}

