namespace IEQ2_BSIT32E1_SAW.Models.User
{
    public class GetUserResponse
    {
        public List<GetUserDto> Users { get; set; }

        public class GetUserDto
        {

            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}
