using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DAL.Entities;

namespace WebAPI.BLL.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Town { get; set; }

        public string Genre { get; set; }
        public ICollection<FriendEntity> MyFriends { get; set; }
        //AmiDe
        public ICollection<FriendEntity> Friends { get; set; }
    }
}
