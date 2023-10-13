using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.BLL.DTO
{
    public class AddUserDTO
    {
        public string NickName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Town { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;
    }
}
