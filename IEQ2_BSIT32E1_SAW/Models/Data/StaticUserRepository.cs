namespace IEQ2_BSIT32E1_SAW.Models.Data
{
    public static class StaticUserRepository
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User()
            {
                Id = 1,
                Username = "admin",
                FirstName = "Admin",
                LastName = "User",
                Email = "admin@gmail.com",
                UserGroupId = 1
            },
            new User()
            {
                Id = 2,
                Username = "student",
                FirstName = "Juan",
                LastName = "Dela Cruz",
                Email = "student@gmail.com",
                UserGroupId = 2
            }
        };

        public static List<UserGroup> UserGroups { get; set; } = new List<UserGroup>()
        {
            new UserGroup()
            {
                Id = 1,
                GroupName = "Administrator"
            },
            new UserGroup()
            {
                Id = 2,
                GroupName = "Student"
            }
        };
    }
}