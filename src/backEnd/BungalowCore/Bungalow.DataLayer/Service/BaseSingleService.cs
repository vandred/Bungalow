using Bungalow.DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.DataLayer.Service
{
    public class BaseSingleService : IBaseSingleService
    {
        static float baseDayFee = 99.99f;

        public float GetBaseDayFee()
        {
             return baseDayFee;
        }

        public bool SetBaseDayFee(float Input)
        {
            baseDayFee = Input;
             return true;
        }
    }
}
