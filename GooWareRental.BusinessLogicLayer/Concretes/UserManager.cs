using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.Core.Entities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Insert(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.UserEMail == email);
        }
    }
}
