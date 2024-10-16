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
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.Added);
            
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.Deleted);
            _userdal.Delete(user);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            var users= _userdal.Get(u=>u.UserId == userId);
            return new SuccessDataResult<User>(users);
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.Updated);
            _userdal.Update(user);
        }
    }
}
