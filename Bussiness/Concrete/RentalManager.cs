using Business.Constans;
using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class RentalManager:IRentalService
    {
        private readonly IRentalDal _rentalDal;
        private readonly ICarDal _carDal;
        public RentalManager(IRentalDal rentalDal, ICarDal carDal)
        {
            _rentalDal = rentalDal;
            _carDal = carDal;
        }
        public IResult Add(Rental rental)
        {
            var car = _carDal.Get(c => c.CarId == rental.CarId);
            // Arabanın mevcut durumunu kontrol et
            var activeRental = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<Rental>> GetAll()
        {
            var rentals = _rentalDal.GetAll();
            
            return new SuccessDataResult<List<Rental>>(rentals, Messages.Listed);
        }
        public IDataResult<List<Rental>> GetByCustomerId(int customerId)
        {
            var rentals = _rentalDal.GetAll(r => r.CustomerId == customerId);
            
            return new SuccessDataResult<List<Rental>>(rentals);
        }
        public IDataResult<Rental> GetById(int id)
        {
            var rental = _rentalDal.Get(r => r.RentalId == id);
           
            return new SuccessDataResult<Rental>(rental);
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
