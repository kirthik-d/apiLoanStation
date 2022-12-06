using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebAppLoanMSAPIConnect.Models;
using WebAppLoanMSAPIConnect.UserCredentials;

namespace WebAppLoanMSAPIConnect.Service
{
    public class LoginService : ILoginService
    {
        private readonly IUserService _userService;
        private readonly ITokenGeneration _tokenGeneration;
        public LoginService(IUserService userService, ITokenGeneration tokenGeneration)
        {
            _userService = userService;
            _tokenGeneration = tokenGeneration;
        }
        public UserCreds Login(UserCreds userCreds)
        {
            var user = _userService.GetAllUser().FirstOrDefault(u => u.UserNameOrEmail == userCreds.UserName);
            if (user != null)
            {

                if (user.Password != userCreds.Password)
                {
                    return null;
                }
                userCreds.Password = user.Password;
                userCreds.Token = _tokenGeneration.GenerateToken(userCreds);
                return userCreds;
            }
            return null;
        }

        public UserCreds Register(User user)
        {

            var userDetails = _userService.AddUser(user);
            if (userDetails != null)
                return new UserCreds
                {
                    UserName = user.UserNameOrEmail,
                    Token = _tokenGeneration.GenerateToken(new UserCreds { UserName = user.UserNameOrEmail })
                };
            return null;
        }
    }
}
