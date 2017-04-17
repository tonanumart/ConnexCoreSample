using Domain.DomainClass;

namespace Domain.Interface.Services
{
    public interface IOfficerService
    {
         void GetAllOfficers();
         int AddingOfficer(Officer officer);
    }
}