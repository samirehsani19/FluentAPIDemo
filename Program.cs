using System;

namespace FluentAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new Car("Volvo")
                .WithModel(2021)
                .WithColor("White")
                .WithFuelType(FuelType.Petrol)
                .WithSeatAmount(5)
                .WithTransmission(Transmission.Manual)
                .CompleteBuilding();
        }
    }
}
