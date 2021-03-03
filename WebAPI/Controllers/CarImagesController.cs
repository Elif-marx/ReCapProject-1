using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Business.Abstract;
using Business.Constants;
using Business.Helpers.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;
        private IUploadProcessHelper _imageUpload;

        public CarImagesController(ICarImageService carImageService, IUploadProcessHelper imageUpload)
        {
            _carImageService = carImageService;
            _imageUpload = imageUpload;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-car-id")]
        public IActionResult GetImagesByCarId(int carId)
        {
            var result = _carImageService.GetImagesByCarId(carId);
            if (result.Data.Capacity <= 0)
            {
                var defaultResult = _carImageService.GetById(7);
                return Ok(defaultResult);
            }
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddImage3([FromForm] CarImages carImages, [FromForm] IFormFile image)
        {
            var tempImage = _imageUpload.CreatePath2(carImages, image);

            var result = _carImageService.Add(tempImage);
            if (result.Success)
            {
                _imageUpload.CopyFile(image, tempImage.ImagePath);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]//Postmanden image & Id
        public IActionResult UpdateImage3([FromForm] CarImages carImages, [FromForm] IFormFile image)
        {
            var tempImage = _imageUpload.CreatePath2(carImages, image);
            var deletePath = _carImageService.GetById(carImages.id).Data.ImagePath;

            var result = _carImageService.Update(tempImage);
            if (result.Success)
            {
                _imageUpload.CopyFile(image, tempImage.ImagePath);
                _imageUpload.DeleteImageIfExists2(deletePath);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImages carImages)
        {
            var result = _carImageService.Delete(carImages);
            _imageUpload.DeleteImageIfExists2(carImages.ImagePath);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        #region OldCodes

        [HttpPost("old-add")]
        public IActionResult Add(CarImages carImages)
        {
            var result = _carImageService.Add(carImages);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("old-addImage")]
        public IActionResult AddImage([FromForm] CarImages carImages, [FromForm] IFormFile image)
        {
            string imagePath = _imageUpload.CreatePath(image);
            if (imagePath == "0")
            {
                BadRequest(Messages.NullImagePath);
            }
            carImages.Date = DateTime.Now;
            carImages.ImagePath = imagePath;
            //carImage.CarId = 1;
            var result = _carImageService.Add(carImages);
            if (result.Success)
            {
                _imageUpload.CopyFile(image, imagePath);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("old-update")]
        public IActionResult Update(CarImages carImages)
        {
            var result = _carImageService.Update(carImages);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("old-updateImage")]
        public IActionResult UpdateImage([FromForm] CarImages carImages, [FromForm] IFormFile image)
        {
            string imagePath = _imageUpload.UploadImage(image, carImages.id);
            if (imagePath == "0")
            {
                BadRequest(Messages.NullImagePath);
            }
            carImages.Date = DateTime.Now;
            carImages.ImagePath = imagePath;
            var result = _carImageService.Update(carImages);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        #endregion
    }
}
