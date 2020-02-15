using System;

namespace DDDWebapi.Application.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth_date { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public DateTime EnteringDate { get; set; }
    }
}
