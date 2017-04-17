using Domain.Interface.Repositorys;
using Xunit;
using Moq;
using Service.Implement;
using System;
using Domain.DomainClass;

namespace TestLib
{
    public class OfficerServiceTest
    {
        [Fact]
        public void OfficerService_Cannot_AddNullName()
        {
            Mock<IOfficerRepository> moqRepo = new Mock<IOfficerRepository>();
            var officerService = new OfficerService(moqRepo.Object);
            var expectException = Record.Exception(()=>officerService.AddingOfficer(new Officer()));
            Assert.IsType(typeof(ArgumentException),expectException);
            Assert.Equal("Officer name cannot empty",expectException.Message);
        }
    }
}
