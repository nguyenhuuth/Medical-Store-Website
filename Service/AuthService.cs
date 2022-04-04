using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;

namespace MedicalStore.DAO
{
    public class AuthService: IAuthService
    {
        private readonly DBContext DBContext;
        private readonly IUserRepository UserRepository;
        private readonly IJwtService JWTService;
        public AuthService(DBContext dBContext, IUserRepository userRepository, IJwtService jwtService)
        {
            this.DBContext = dBContext;
            this.UserRepository = userRepository;
            this.JWTService = jwtService;
        }

        public bool RegisterHandler(User user)
        {
            return this.UserRepository.RegisterHandler(user);
        }


        public string LoginHandler(string userId)
        {
            string token = this.JWTService.GenerateToken(userId);
            return token;
        }

        public string HashingPassword(string password)

        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 8);
        }

        public bool ComparePassword(string inputPassword, string encryptedPassword)
        {
            return inputPassword.Equals(encryptedPassword);
        }

    }
}
