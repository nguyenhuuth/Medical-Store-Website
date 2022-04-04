using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IUserService
    {
        public bool UpdatePasswordHandler(User user);
        public bool UpdateUserInfoHandler(User user);
        public User GetUserById(string id);
        public User GetUserByUsername(string username);
        public bool RegisterHandler(User user);
        public List<User> GetAllUsers();
        public List<User> GetAllUserByRoleId(string roleId);
        public bool ManageAccountHandler(User user);
    }
}
