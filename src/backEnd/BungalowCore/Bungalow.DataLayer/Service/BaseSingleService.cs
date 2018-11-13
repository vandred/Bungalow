using Bungalow.Core.Model;
using Bungalow.DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bungalow.DataLayer.Service
{
    public class BaseSingleService : IBaseSingleService
    {
        static List<BookRecords> booList = new List<BookRecords>();
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

        public BookRecords GetBook(string registreId)
        {
            BookRecords rzlt = booList.Where(x => x.ReservationNumber == registreId).FirstOrDefault();
            return new BookRecords();
        }

        public List<BookRecords> SaveBook(BookRecords Input)
        {
            booList.Add(Input);
            return booList;
        }

        public List<BookRecords> GetBookList()
        {
            return booList;
        }

    }
}
