﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Business.Helpers.Abstract
{
    public interface IUploadProcessHelper
    {
        string UploadImage(IFormFile imageFile, int imageId = 0);
        string CreatePath(IFormFile imageFile);
        void CopyFile(IFormFile imageFile, string filePath);
        void DeleteImageIfExists(int createdImageId);
        void DeleteImageIfExists2(string path);
        CarImages CreatePath2([FromForm] CarImages carImages, IFormFile imageFile);
    }
}
