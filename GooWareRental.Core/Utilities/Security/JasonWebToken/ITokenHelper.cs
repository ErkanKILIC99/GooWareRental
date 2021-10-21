using GooWareRental.Core.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.Core.Utilities.Security.JasonWebToken
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
