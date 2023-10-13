using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.BLL.DTO;
using WebAPI.DAL;
using WebAPI.DAL.Entities;

namespace WebAPI.BLL.Services
{
    public class UserService
    {
        private readonly ButterContext _context;

        public UserService(ButterContext context)
        {
            _context = context;
        }

        public bool AddUser( AddUserDTO add)
        {

            UserEntity u = new UserEntity
            {
                NickName = add.NickName,
                Password = add.Password,
                Email = add.Email,
                BirthDate = add.BirthDate,
                Town = add.Town,
                Genre = add.Genre,

            };
            if (_context.Users.Any(e => e.Email == add.Email))
            {
                throw new ValidationException("Email deja existant");
            }
            if (_context.Users.Any(n => n.NickName == add.NickName))
            {
                throw new ValidationException("Nickname deja existant");
            }


            _context.Add(u);
            _context.SaveChanges();
           

            return true;
        
        }

    }
}
