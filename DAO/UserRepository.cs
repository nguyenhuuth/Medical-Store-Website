using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class UserRepository: IUserRepository
    {
        private readonly DBContext DBContext;
        public UserRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

       
        public User GetUserByUsername(string username)
        {
            User user = this.DBContext.User.FirstOrDefault(item => item.Username == username);
            return user;
        }

        public User GetUserById(string id)
        {
            User user = this.DBContext.User.FirstOrDefault(item => item.UserId == id);
            return user;
        }

        public bool RegisterHandler(User user)
        {
            this.DBContext.User.Add(user);
            return this.DBContext.SaveChanges() > 0;
        }
        public bool UpdatePasswordHandler(User user)
        {
            this.DBContext.User.Update(user);
            this.DBContext.SaveChanges();
            return true;
        }
        public bool UpdateUserInfoHandler(User user)
        {
            this.DBContext.User.Update(user);
            this.DBContext.SaveChanges();
            return true;
        }

        public bool ManageAccountHandler(User user)
        {
            this.DBContext.User.Update(user);
            return this.DBContext.SaveChanges() > 0;
        }
        public List<User> GetAllUsers()
        {
            List<User> listUser = this.DBContext.Set<User>().ToList<User>();
            return listUser;
        }

        public List<User> GetListUserByRoleId(string roleId)        {
            List<User> listUser = this.DBContext.User.Where(item => item.RoleId == roleId).ToList();
            return listUser;
        }
    }
}
