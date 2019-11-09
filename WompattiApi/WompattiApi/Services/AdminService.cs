using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;
using WompattiApi.Repositories;

namespace WompattiApi.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Admin CreateAdmin(Admin admin)
        {
            return _adminRepository.CreateAdmin(admin);
        }

        public Admin DeleteAdmin(long id)
        {
            Admin admin = ReadAdmin(id);
            return _adminRepository.DeleteAdmin(admin);
        }

        public Admin ReadAdmin(long id)
        {
            return _adminRepository.ReadAdmin(id);
        }

        public List<Admin> ReadAdmins()
        {
            return _adminRepository.ReadAdmins();
        }

        public List<Admin> ReadAdmins(string userName)
        {
            return _adminRepository.ReadAdmins(userName);
        }

        public Admin UpdateAdmin(Admin admin, long id)
        {
            if (admin != null)
            {
                if (admin.Id.Equals(id))
                {
                    return _adminRepository.UpdateAdmin(admin);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
