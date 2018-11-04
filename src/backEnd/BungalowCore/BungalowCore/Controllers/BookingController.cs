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
            float BaseFeeTest = _baseService.GetBaseDayFee();
            float BaseFee = BaseFeeInput.BaseFee;
            _baseService.SetBaseDayFee(BaseFee);
            return true;
        }


        [HttpPost("Book")]
        public ActionResult<string> Book([FromBody] BookingInput input)
        {
            BookingInput booData = input;
            return new Guid().ToString();
        }

        [HttpGet("GetAppartmentType")]
        public ActionResult<List<Apartments>> GetAppartmentType()
        {
            var rzlt = _dataService.GetAllAppartments().ToList();
            return rzlt;
        }


        [HttpPost("CheckOut")]
        public ActionResult<float> CheckOut([FromBody] CheckOutInput input)
        {
            float rzlt = 0.0f;
            CheckOutInput booData = input;
            return rzlt;
        }


    }
}