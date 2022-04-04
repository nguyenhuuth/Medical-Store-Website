using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils;
using System.Collections.Generic;

namespace MedicalStore.Service
{
    public class UserService: IUserService
    {
        private readonly DBContext DBContext;
        private readonly IUserRepository UserRepository;
        private readonly IAuthService AuthService;

        public UserService(DBContext dBContext, IUserRepository userRepository, IAuthService authService)
        {
            this.DBContext = dBContext;
            this.UserRepository = userRepository;
            this.AuthService = authService;
        }

        public List<User> GetAllUserByRoleId(string roleId)
        {
            return this.UserRepository.GetListUserByRoleId(roleId);
        }

        public List<User> GetAllUsers()
        {
            return this.UserRepository.GetAllUsers();
        }

        public User GetUserById(string id)
        {
            return this.UserRepository.GetUserById(id);
        }

        public User GetUserByUsername(string username)
        {
            return this.UserRepository.GetUserByUsername(username);
        }

        public bool ManageAccountHandler(User user)
        {
            return this.UserRepository.ManageAccountHandler(user);
        }

        public bool RegisterHandler(User user)
        {
            return this.UserRepository.RegisterHandler(user);
        }

        public bool UpdatePasswordHandler(User user)
        {
            return this.UserRepository.UpdatePasswordHandler(user);
        }

        public bool UpdateUserInfoHandler(User user)
        {
            return this.UserRepository.UpdateUserInfoHandler(user);
        }
    }
}
