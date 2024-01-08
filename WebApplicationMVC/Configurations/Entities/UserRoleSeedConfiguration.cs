using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "9c57g0ee-5b31-4544-b654-283583120d3d",
                    RoleId = "9d57g0ee-5b31-4544-a654-283583120c3c"
                },
                new IdentityUserRole<string>
                {
                    UserId = "9c57g0ee-5b31-4544-b654-283584560d3d",
                    RoleId = "9d57g0rr-5b31-8544-a654-283583120c3d"
                });
        }
    }
}