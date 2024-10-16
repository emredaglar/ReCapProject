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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult Add(Customer customer)
        {
            _customerdal.Add(customer);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.Deleted);
            _customerdal.Delete(customer);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll());
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            var customers=_customerdal.Get(c=>c.CustomerId == customerId);
            return new SuccessDataResult<Customer>(customers);  
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.Updated);
            _customerdal.Update(customer);
        }
    }
}
