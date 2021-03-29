﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IEntityServiceBase<Rental>
     {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<Rental> GetLastByCarId(int carId);
        IDataResult<List<Rental>> GetAllByCustomerId(int customerId);
        IResult IsDelivered(Rental rental);
        IResult IsRentable(Rental rental);
    }
}
