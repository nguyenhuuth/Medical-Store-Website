using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Linq;

namespace MedicalStore.DAO
{
    public class RoleRepository: IRoleRepository
    {
        private readonly DBContext DBContext;
        public RoleRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }
        public Role GetRoleByRoleId(string roleId)
        {
            Role role = this.DBContext.Role.FirstOrDefault(item => item.RoleId == roleId);
            return role;
        }

        public string GetRoleCustomer()
        {
            Role role = this.DBContext.Role.FirstOrDefault(item => item.RoleId == "1");
            return role.RoleId;
        }
    }
}
