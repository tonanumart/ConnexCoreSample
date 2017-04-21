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

        [Fact]
        public void OfficerService_Cannot_AddNull_Tel()
        {
            Mock<IOfficerRepository> moqRepo = new Mock<IOfficerRepository>();
            var officerService = new OfficerService(moqRepo.Object);
            var officerInput = new Officer(){
                Name  = "Anumart",
            };
            var expectException = Record.Exception(()=>officerService.AddingOfficer(officerInput));
            Assert.IsType(typeof(ArgumentException),expectException);
            Assert.Equal("Officer telephone cannot empty",expectException.Message);
        }

        [Fact]
        public void OfficerService_Add_Success()
        {
            Mock<IOfficerRepository> moqRepo = new Mock<IOfficerRepository>();
            moqRepo.Setup(x=>x.CreateOfficer(It.IsAny<Officer>())).Returns(1);
            var officerService = new OfficerService(moqRepo.Object);
            var officerInput = new Officer(){
                Name  = "Anumart",
                Telephone = "0255512134"
            };
            var expectException = Record.Exception(()=>officerService.AddingOfficer(officerInput));
            moqRepo.Verify(x=>x.CreateOfficer(It.IsAny<Officer>()),Times.Once());
        }
    }
}
