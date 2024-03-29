﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager:IImageFileServices
    {
        IImageFileDal _imageFileDal;
        public ImageFileManager(IImageFileDal imageFileDal)
        {
            _imageFileDal = imageFileDal;
        }

        public List<ImageFile> GetAll()
        {
            return _imageFileDal.List();
        }
    }
}
