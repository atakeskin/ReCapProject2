using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;

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
            var result = _carService.Update(car);
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

        [HttpGet("getcardetails")]
        public IActionResult getCarDetails()
        {
            var result = _carService.GetCarDetailsByCarProperty();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsbybrand")]
        public IActionResult getCarsByBrand(int brandId)
        {
            var result = _carService.GetCarByBrand(brandId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsbycolor")]
        public IActionResult getCarsByColor(int colorId)
        {
            var result = _carService.GetCarByColor(colorId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletebycarid")]
        public IActionResult DeleteByCarId(CarDetailDto carDetailDto)
        {
            var result = _carService.DeleteByCarId(carDetailDto);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        #endregion

    }
}
