using System;
using Domain.DomainClass;
using Domain.Interface.Repositorys;
using Domain.Interface.Services;

namespace Service.Implement
{
    public class OfficerService : IOfficerService
    {
        public IOfficerRepository OfficerRepository { get; set; }

        public OfficerService(IOfficerRepository officerRepository)
        {
            this.OfficerRepository = officerRepository;

        }

        public int AddingOfficer(Officer officer)
        {
            if(string.IsNullOrEmpty(officer.Name)){
                throw new ArgumentException("Officer name cannot empty");
            }
            throw new NotImplementedException();
        }

        public void GetAllOfficers()
        {
            throw new NotImplementedException();
        }
    }
}