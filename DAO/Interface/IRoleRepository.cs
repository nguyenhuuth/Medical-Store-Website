using MedicalStore.Models;

namespace MedicalStore.DAO.Interface
{
    public interface IRoleRepository
    {
        public Role GetRoleByRoleId(string roleId);

        public string GetRoleCustomer();
    }
}
