// UserInfoTest.cs

using DAL;
using Moq;
using NUnit.Framework;

namespace DALTest
{
    [TestFixture]
    public class UserInfoTest
    {
        [Test]
        public void ValidateUserTest()
        {
            // Arrange
            var mockUserInfoRepository = new Mock<IUserInfoRepository>();
            // Set up mock data or behavior if needed

            // Act
            var result = mockUserInfoRepository.Object.ValidateUser(1, "Maximus");

            // Assert
            // Add assertions to validate the result
        }
    }

    public interface IUserInfoRepository
    {
        object ValidateUser(int i, string Maximus);
    }
}