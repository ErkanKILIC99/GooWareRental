using GooWareRental.Core.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
