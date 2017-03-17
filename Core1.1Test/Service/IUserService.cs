using CoreTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Service
{
    public interface IUserService
    {
        Task<User> Find(int id);
    }
}
