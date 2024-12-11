using GamerMarketApp.Services.Data;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MockQueryable;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketApp.Services.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<UserManager<IdentityUser>> mockUserManager;
        private Mock<RoleManager<IdentityRole<string>>> mockRoleManager;
        private UserService userService; 

        [SetUp]
        public void SetUp()
        {
            mockUserManager = new Mock<UserManager<IdentityUser>>(
                Mock.Of<IUserStore<IdentityUser>>(),
                null, null, null, null, null, null, null, null);

            mockRoleManager = new Mock<RoleManager<IdentityRole<string>>>(
                Mock.Of<IRoleStore<IdentityRole<string>>>(),
                null, null, null, null);

            userService = new UserService(mockUserManager.Object, mockRoleManager.Object);
        }
        [Test]
        public async Task AssignUserRoleAsync_ShouldReturnFailed_WhenUserNotFound()
        {
            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((IdentityUser)null);

            mockRoleManager
                .Setup(m => m.RoleExistsAsync(It.IsAny<string>()))
                .ReturnsAsync(true);

            var result = await userService.AssignUserRoleAsync("invalidUserId", "Admin");

            Assert.IsFalse(result.Succeeded);
        }
        [Test]
        public async Task AssignUserRoleAsync_ShouldReturnFailed_WhenRoleDoesNotExist()
        {
            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityUser { Id = "validUserId" });

            mockRoleManager
                .Setup(m => m.RoleExistsAsync(It.IsAny<string>()))
                .ReturnsAsync(false);

            var result = await userService.AssignUserRoleAsync("validUserId", "NonExistentRole");

            Assert.IsFalse(result.Succeeded);
        }
        [Test]
        public async Task AssignUserRoleAsync_ShouldAddRole_WhenUserNotInRole()
        {
            var user = new IdentityUser { Id = "validUserId" };

            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);

            mockRoleManager
                .Setup(m => m.RoleExistsAsync(It.IsAny<string>()))
                .ReturnsAsync(true);

            mockUserManager
                .Setup(m => m.IsInRoleAsync(It.IsAny<IdentityUser>(), It.IsAny<string>()))
                .ReturnsAsync(false);

            mockUserManager
                .Setup(m => m.AddToRoleAsync(It.IsAny<IdentityUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            var result = await userService.AssignUserRoleAsync("validUserId", "Admin");

            Assert.IsTrue(result.Succeeded);
            mockUserManager.Verify(m => m.AddToRoleAsync(user, "Admin"), Times.Once);
        }
        [Test]
        public async Task AssignUserRoleAsync_ShouldReturnSuccess_WhenUserAlreadyInRole()
        {
            var user = new IdentityUser { Id = "validUserId" };

            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);

            mockRoleManager
                .Setup(m => m.RoleExistsAsync(It.IsAny<string>()))
                .ReturnsAsync(true);

            mockUserManager
                .Setup(m => m.IsInRoleAsync(It.IsAny<IdentityUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);

            var result = await userService.AssignUserRoleAsync("validUserId", "Admin");

            Assert.IsTrue(result.Succeeded);
           mockUserManager.Verify(m => m.AddToRoleAsync(It.IsAny<IdentityUser>(), It.IsAny<string>()), Times.Never);
        }

        [Test]
        public async Task DeleteUserAsync_ShouldReturnFailed_WhenUserNotFound()
        {
            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((IdentityUser)null);

            var result = await userService.DeleteUserAsync("invalidUserId");

            Assert.IsFalse(result.Succeeded);
            mockUserManager.Verify(m => m.DeleteAsync(It.IsAny<IdentityUser>()), Times.Never);
        }

        [Test]
        public async Task DeleteUserAsync_ShouldReturnFailed_WhenDeletionFails()
        {
            var user = new IdentityUser { Id = "validUserId" };

            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);

            mockUserManager
                .Setup(m => m.DeleteAsync(It.IsAny<IdentityUser>()))
                .ReturnsAsync(IdentityResult.Failed());

            var result = await userService.DeleteUserAsync("validUserId");

            Assert.IsFalse(result.Succeeded);
            mockUserManager.Verify(m => m.DeleteAsync(user), Times.Once);
        }

        [Test]
        public async Task DeleteUserAsync_ShouldReturnSuccess_WhenDeletionSucceeds()
        {
            var user = new IdentityUser { Id = "validUserId" };

            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);

            mockUserManager
                .Setup(m => m.DeleteAsync(It.IsAny<IdentityUser>()))
                .ReturnsAsync(IdentityResult.Success);

            var result = await userService.DeleteUserAsync("validUserId");

            Assert.IsTrue(result.Succeeded);
            mockUserManager.Verify(m => m.DeleteAsync(user), Times.Once);
        }

        [Test]
        public async Task DisableUserAsync_ShouldReturnFailed_WhenUserNotFound()
        {
            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((IdentityUser)null);

            var result = await userService.DisableUserAsync("invalidUserId");

            Assert.IsFalse(result.Succeeded);
            mockUserManager.Verify(m => m.SetLockoutEnabledAsync(It.IsAny<IdentityUser>(), It.IsAny<bool>()), Times.Never);
            mockUserManager.Verify(m => m.SetLockoutEndDateAsync(It.IsAny<IdentityUser>(), It.IsAny<DateTimeOffset>()), Times.Never);
        }

        [Test]
        public async Task DisableUserAsync_ShouldReturnSuccess_WhenLockoutEnabledSuccessfully()
        {
            var user = new IdentityUser { Id = "validUserId" };

            mockUserManager
                .Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(user);

            mockUserManager
                .Setup(m => m.SetLockoutEnabledAsync(It.IsAny<IdentityUser>(), true))
                .ReturnsAsync(IdentityResult.Success);

            mockUserManager
                .Setup(m => m.SetLockoutEndDateAsync(It.IsAny<IdentityUser>(), It.IsAny<DateTimeOffset>()))
                .ReturnsAsync(IdentityResult.Success);

            var result = await userService.DisableUserAsync("validUserId");

            Assert.IsTrue(result.Succeeded);
            mockUserManager.Verify(m => m.SetLockoutEnabledAsync(user, true), Times.Once);
            mockUserManager.Verify(m => m.SetLockoutEndDateAsync(user, It.Is<DateTimeOffset>(d => d.Date == DateTime.Today.AddYears(10))), Times.Once);
        }
        [Test]
        public async Task GetAllUsersAsync_ReturnsUsersWithRoles()
        {

            var users = new List<IdentityUser>
            {
                new IdentityUser { Id = "1", Email = "user1@example.com" },
                new IdentityUser { Id = "2", Email = "user2@example.com" }
            };

            var usersData = users.BuildMock();

            mockUserManager.Setup(m => m.Users)
                .Returns(usersData);

            mockUserManager.Setup(m => m.GetRolesAsync(It.IsAny<IdentityUser>()))
                           .ReturnsAsync(new List<string> { "Admin" }); 

            var result = await userService.GetAllUsersAsync();

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(2)); 
        }

        [Test]
        public async Task GetAllUsersAsync_ReturnsEmptyList_WhenUsersAreNull()
        {
            var users = new List<IdentityUser>();

            var usersData = users.BuildMock();

            mockUserManager.Setup(m => m.Users)
                .Returns(usersData);


            var result = await userService.GetAllUsersAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);  
        }

        [Test]
        public async Task GetAllUsersAsync_ReturnsUserWithoutRoles_WhenUserHasNoRoles()
        {
            var users = new List<IdentityUser>
            {
                new IdentityUser { Id = "1", Email = "user1@example.com" },
                new IdentityUser { Id = "2", Email = "user2@example.com" },
            };
            var usersData = users.BuildMock();
            mockUserManager
                .Setup(m => m.Users)
                .Returns(usersData);

            mockUserManager
                .Setup(m => m.GetRolesAsync(It.IsAny<IdentityUser>()))
                .ReturnsAsync(new List<string>());

            var result = await userService.GetAllUsersAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
        }
    }
}

