using MedicalStore.Models;

namespace MedicalStore.DAO.Interface
{
    public interface IAuthService
    {
        public string LoginHandler(string userId);
        public bool RegisterHandler(User user);
        public string HashingPassword(string password);
        public bool ComparePassword(string inputPassword, string encryptedPassword);
    }
}
