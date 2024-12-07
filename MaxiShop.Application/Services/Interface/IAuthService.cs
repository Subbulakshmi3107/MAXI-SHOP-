using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiShop.Application.InputModels;
using Microsoft.AspNetCore.Identity;

namespace MaxiShop.Application.Services.Interface
{
    public interface IAuthService
    {
        Task<IEnumerable<IdentityError>> Register(Register register);

        Task<object> Login(Login login);
    }
}
