using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    public class Car
    {
        public Car()
        {
            this.currentGasLevel = new Random().Next(1, 13);
        }

        public static float gasMaxValue = 13;

        public float currentGasLevel { get; set; }

        public float AddGas(float value)
        {
            return currentGasLevel + value;
        }

        public float FillToMax()
        {
            float gasTobeAdded = gasMaxValue - currentGasLevel;
            AddGas(gasTobeAdded);

            return gasTobeAdded;
        }
    }
}