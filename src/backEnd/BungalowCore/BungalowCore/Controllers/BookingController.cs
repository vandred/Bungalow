using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bungalow.Core.Model;
using Bungalow.DataLayer.Interface;
using Bungalow.Web.Host.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Bungalow.Web.Host.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private IApartmentService _dataService;
        private IBaseSingleService _baseService;

        public BookingController(IApartmentService dataService, IBaseSingleService baseService)
        {
            _baseService = baseService;
            _dataService = dataService;
        }

        [HttpPost("SetUpBaseFee")]
        public ActionResult<bool> SetUpBaseFee([FromBody] BaseFeeInput BaseFeeInput)
        {
            float BaseFee = BaseFeeInput.BaseFee;
            _baseService.SetBaseDayFee(BaseFee);
            return true;
        }


        [HttpPost("Book")]
        public ActionResult<BookingOut> Book([FromBody] BookingInput input)
        {
            //  BookingInput booData = input;

            var apartT = _dataService.GetAllAppartments().Where(x=>x.Id.ToString()==input.ApartmentId).First();

            BookingOut rzlt = new BookingOut();
            rzlt.ReservationNumber= Guid.NewGuid().ToString();

            BookRecords newBook = new BookRecords();
            newBook.FName = input.Fname;
            newBook.lName = input.Lname;
            newBook.Email = input.Email;
            newBook.ReservationNumber = rzlt.ReservationNumber;
            newBook.StartDate = input.StartDate;
            newBook.AType = apartT;

            var bookRecords = _baseService.SaveBook(newBook);


            return rzlt;
        }

        [HttpGet("GetAppartmentType")]
        public ActionResult<List<Apartments>> GetAppartmentType()
        {
            var rzlt = _dataService.GetAllAppartments().ToList();
            return rzlt;
        }


        [HttpPost("CheckOut")]
        public ActionResult<CheckOutOutput> CheckOut([FromBody] CheckOutInput input)
        {
            CheckOutOutput rzlt = new CheckOutOutput();
            BookRecords bookEnt = _baseService.GetBook(input.ReservationNumber);
            if (bookEnt!=null)
            {
                bookEnt.EndDate = input.CheakOutDate;
            var testDays = (bookEnt.EndDate - bookEnt.StartDate).TotalDays;
                rzlt.Price = (float)testDays * _baseService.GetBaseDayFee()* bookEnt.AType.Price;
            }
            else
            {
                rzlt = null;
            }

            return rzlt;
        }


    }
}