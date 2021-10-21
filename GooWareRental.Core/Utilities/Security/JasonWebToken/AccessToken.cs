using System;

namespace GooWareRental.Core.Utilities.Security.JasonWebToken
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
