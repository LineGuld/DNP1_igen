using System;
using System.Collections.Generic;

namespace s2_CarsAndPredicates
{
    public class Car
    {
        private string Color { get; set; }
        private int EngineSize { get; set; }
        private double FuelEconomy { get; set; }
        private bool IsManualShift { get; set; }

        public override string ToString()
        {
            return $"Color: {Color} \n" +
                   $"Engine size: {EngineSize} liters \n" +
                   $"Fuel economy: {FuelEconomy} l/ 100 km \n" +
                   $"Manual shift: {IsManualShift}";
        }

        public List<Car> GetColorsCars(string Color, List<Car> carsList)
        {
            List<Car> colorCars = carsList.FindAll(car => Color.ToLower().Equals(Color));
            return colorCars;
        }

        public List<Car> GetColorsCars(string Color1, string Color2, List<Car> carsList)
        {
            List<Car> colorCars =
                carsList.FindAll(car => Color.ToLower().Equals(Color1) || Color.ToLower().Equals(Color2));
            return colorCars;
        }

        public List<Car> GetColorsCars(List<string> colors, List<Car> carsList)
        {
            List<Car> colorCars =
                carsList.FindAll(car =>
                    {
                        foreach (string color in colors)
                        {
                            if (Color.ToLower().Equals(color)) ;
                        }

                        return false;
                    }
                );
            return colorCars;
        }
    }
}