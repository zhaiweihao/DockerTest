using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTest.Domain;
using CoreTest.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreTest.Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> Find(int id)
        {
            var result = await _context.Users.Where(a => a.Id == id).SingleOrDefaultAsync();
            return result;
        }
    }
}
