﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VmsEntity;

namespace VmsData
{
    class UserDataAccess : IUserDataAccess
    {
        private VmsDBContext context;
        public UserDataAccess(VmsDBContext context)
        {
            this.context = context;
        } 
        public IEnumerable<User> GetAll()
        {
            return this.context.Users.ToList();
        }

        public User GetByContact(string contact)
        {
            return this.context.Users.SingleOrDefault(x => x.Contact == contact);
        }

        public int Insert(User user)
        {
            this.context.Users.Add(user);

            return this.context.SaveChanges();
        }


        public int UpdatePassword(User user)
        {
            User us = this.context.Users.SingleOrDefault(x => x.Contact == user.Contact);
            us.Password = user.Password;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            User us = this.context.Users.SingleOrDefault(x => x.Id == id);
            this.context.Users.Remove(us);

            return this.context.SaveChanges();
        }
    }
}
