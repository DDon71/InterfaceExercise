using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string Engine { get; set; } = "V8";
        public string Model { get; set; } = "Urus";
        public string Wheels { get; set; } = "Four";
        public int Seats { get; set; } = 4;
        public string Logo { get; set; } = "Bull";
        public string Make { get; set; } = "Lamborghini";
        public bool PastSpeedLimit { get; set; }

        public void Speed()
        {
            Console.WriteLine($"{GetType().Name} is going fast.");
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

