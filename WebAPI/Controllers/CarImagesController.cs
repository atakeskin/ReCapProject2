using System;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Core.Utilities.Helpers;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        
        #region getall

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
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
            var result = _carImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region add

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Add(file);
            carImage.CreateDate = DateTime.Now;
            var result = _carImageService.Add(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region update

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var carImage = _carImageService.GetById(Id).Data;
            var result = _carImageService.Update(file,carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region delete

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        #endregion

        #region getimagesbycarid

        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesById(int id)
        {
            var result = _carImageService.GetImagesByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        #endregion
    }
}
