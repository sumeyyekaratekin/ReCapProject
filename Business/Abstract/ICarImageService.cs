﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImagesDto carImage);
        IResult Update(CarImagesDto carImage);
        IResult Delete(CarImagesDto carImage);
        IResult DeleteByCarId(int carId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int carImageId);
        IDataResult<List<CarImage>> GetByCarId(int carId);
    }
}
