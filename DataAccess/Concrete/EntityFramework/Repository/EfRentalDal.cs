﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join cs in context.Customers
                             on r.CustomerId equals cs.Id
                             join u in context.Users
                             on cs.UserId equals u.Id
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 ColorName = cl.ColorName,
                                 CompanyName = cs.CompanyName,
                                 DailyPrice = c.DailyPrice,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 ModelYear = c.ModelYear
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

    }
}