using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.DataLayer.Interface
{
    public interface IBaseSingleService
    {
        float  GetBaseDayFee();

        bool SetBaseDayFee(float Input);
    }
}
