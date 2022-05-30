using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VideoSearchService.Service.Interfaces
{
    public interface ITokenService
    {
        Task<TokenResponse> GetAccessTokenAsync();
        Task<TokenResponse> RefreshAccessTokenAsync();
    }
}
