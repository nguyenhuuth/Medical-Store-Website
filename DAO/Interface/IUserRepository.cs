using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IUserRepository
    {
        public User GetUserByUsername(string username);
        public User GetUserById(string id);
        public bool RegisterHandler(User user);
        public bool UpdatePasswordHandler(User user);
        public bool UpdateUserInfoHandler(User user);
        public List<User> GetAllUsers();
        public List<User> GetListUserByRoleId(string roleId);
        public bool ManageAccountHandler(User user);
    }
}
