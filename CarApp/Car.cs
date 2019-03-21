using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    public class Car
    {
        public Car(float CurrentGasLevel)
        {
            this.CurrentGasLevel = CurrentGasLevel;
        }

        public static float gasMaxValue = 13;

        public float CurrentGasLevel { get; set; }

        public float AddGas(float value)
        {
            return CurrentGasLevel + value;
        }

        public float FillToMax()
        {
            float gasTobeAdded = gasMaxValue - CurrentGasLevel;
            AddGas(gasTobeAdded);

            return gasTobeAdded;
        }
    }
}