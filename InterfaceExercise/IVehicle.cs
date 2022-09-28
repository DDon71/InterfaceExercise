using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Engine { get; set; }
        public string Model { get; set; }
        public string Wheels { get; set; }
        public int Seats { get; set; }
        public bool PastSpeedLimit { get; set; }

        public void Speed();
        public void Drive();
        public void Parked();
        public void MPH();
    }
}

