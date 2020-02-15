using System;


namespace DDDWebapi.Domain.Models
{
    public class User : Base
    {
        public string Name { get; set; }
        public DateTime Birth_date { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime EnteringDate { get; set; }

    }
}
