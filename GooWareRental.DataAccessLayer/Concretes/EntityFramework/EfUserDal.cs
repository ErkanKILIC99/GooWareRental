using GooWareRental.Core.DataAccessLayer.EntityFramework;
using GooWareRental.Core.Entities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts;
using GooWareRental.DataAccessLayer.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace GooWareRental.DataAccessLayer.Concretes.EntityFramework
{
    public class EfUserDal : EntityFrameworkRepositoryBase<User, GooWareRentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new GooWareRentalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, OperationClaimName = operationClaim.OperationClaimName };
                return result.ToList();

            }
        }
    }
}
