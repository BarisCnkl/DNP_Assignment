using ApiContracts;
using System.Collections.Generic;
using System.Security.Claims;

namespace BlazorApp.Services
{
    public class SimpleAuthService
    {
        private UserDTO _user;

        // Set the logged-in user
        public void SetUser(UserDTO userDto)
        {
            _user = userDto;
        }

        // Get the claims for the logged-in user
        public List<Claim> GetClaims()
        {
            if (_user == null)
            {
                return new List<Claim>(); // No user logged in
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName),
                new Claim(ClaimTypes.NameIdentifier, _user.Id.ToString())
            };

            return claims;
        }

        // Check if the user is logged in
        public bool IsLoggedIn()
        {
            return _user != null;
        }
    }
}