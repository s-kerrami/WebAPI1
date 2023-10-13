using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DAL.Entities;

namespace WebAPI.BLL.DTO
{
    public class FriendDTO
    {
        public int UserId { get; set; }
        public int FriendId { get; set; }

        public UserEntity Users { get; set; }
        public UserEntity Friends { get; set; }

    }
}
