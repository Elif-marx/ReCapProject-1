using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate == null)
            {
                return new ErrorResult(Messages.RentalDateNull);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalRecorded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalGetAll);
        }

        //public DataResult<List<RentalDetailDto>> GetRentalDetails()
        //{
        //    return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        //}

        public IResult Rent(Rental rental)
        {
            {
                if (rental.ReturnDate < DateTime.Now)
                {
                    _rentalDal.Add(rental);
                    return new SuccessResult(Messages.AddedRental);
                    
                }
                return new ErrorResult(Messages.FailedRentalAddOrUpdate);
            }
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
