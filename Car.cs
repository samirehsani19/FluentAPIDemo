using System;

namespace FluentAPIDemo
{
    public class Car :ICar
    {
        private CarDetail CarDetails = new CarDetail();
        public Car(string name)
        {
            CarDetails.Name = name;
        }
        public ICar WithColor(string color)
        {
            CarDetails.Color = color;
            return this;
        }

        public ICar WithFuelType(FuelType fuelType)
        {
            CarDetails.FuelTyp = fuelType;
            return this;
        }

        public ICar WithModel(int model)
        {
            CarDetails.Model = model;
            return this;
        }

        public ICar WithSeatAmount(int seatAmount)
        {
            CarDetails.SeatAmount = seatAmount;
            return this;
        }

        public ICar WithTransmission(Transmission transmissionType)
        {
            CarDetails.Transmission = transmissionType;
            return this;
        }
        public void CompleteBuilding()
        {
            Console.WriteLine("Your new car with the following details builded successfully!");
            Console.WriteLine($"Name: {CarDetails.Name} \nModel:{CarDetails.Model} \nColor: {CarDetails.Color} \nSeatAmount: {CarDetails.SeatAmount} \nTransmission: {CarDetails.Transmission} \nFuelType:{CarDetails.FuelTyp}");
        }
    }
    public interface ICar
    {
        ICar WithModel(int model);
        ICar WithTransmission(Transmission transmissionType);
        ICar WithColor(string color);
        ICar WithSeatAmount(int seatAmount);
        ICar WithFuelType(FuelType fuelType);
        void CompleteBuilding();
    }
    public class CarDetail
    {
        public string Name { get; set; }
        public int Model { get; set; }
        public Transmission Transmission { get; set; }
        public string Color { get; set; }
        public int SeatAmount { get; set; }
        public FuelType FuelTyp { get; set; }


    }

    public enum FuelType
    {
        Petrol,
        Diesel
    }
    public enum Transmission
    {
        Manual,
        Automat
    }
}
