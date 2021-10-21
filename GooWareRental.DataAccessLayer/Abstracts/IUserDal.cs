using GooWareRental.Core.DataAccessLayer;
using GooWareRental.Core.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.DataAccessLayer.Abstracts
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
