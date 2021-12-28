using System;
using Xunit;

namespace UnitTesting
{
    public class UserManagerTests
    {
        //Name Methods For Tests using this Conventions
        //UnitOfWork_ScenarioForTest_ExpectedResults
        //UserManager_LoginAdmin_ReturnTrue


        [Fact]
        public void Security_LoginAdmin_ReturnTrue()
        {
            //Arrange (Mean Set Variables and take instances from objects that test need)
            var userManager = new UserManager();


            //Act (Mean Call Function to Test depend on Arrange step)
            var result = userManager.Login("admin", "123");

            //Assert (Mean Check if result equal to expected result to say this test is success or fail)
            Assert.True(result);

        }

        [Theory]
        [InlineData("user1","pass1")]
        [InlineData("user2", "pass2")]
        [InlineData("user3", "pass3")]
        public void Security_LoginUser_ReturnTrue(string userName,string password)
        {
            //Arrange (Mean Set Variables and take instances from objects that test need)
            var userManager = new UserManager();


            //Act (Mean Call Function to Test depend on Arrange step)
            var result = userManager.Login(userName, password);

            //Assert (Mean Check if result equal to expected result to say this test is success or fail)
            Assert.True(result);
        }
    }
}
