using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        #region getall

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region getbyId

        [HttpGet("getbyId")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region add

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region update

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region delete

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region getcardetails

        [HttpPost("getcardetails")]
        public IActionResult GetCarDetailsByCarProperty(Expression<Func<Car, bool>> filter = null)
        {
            var result = _carService.GetCarDetailsByCarProperty(filter);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

    }
}
