using Bungalow.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.DataLayer.Interface
{
    public interface IBaseSingleService
    {
        float  GetBaseDayFee();

        bool SetBaseDayFee(float Input);

        BookRecords GetBook(string input);

        List<BookRecords> SaveBook(BookRecords Input);

        List<BookRecords> GetBookList();
    }
}
