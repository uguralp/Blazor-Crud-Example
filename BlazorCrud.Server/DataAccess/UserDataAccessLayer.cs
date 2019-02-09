using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.DataAccess
{
    public class UserDataAccessLayer
    {
        UserContext db = new UserContext();

        //To Get all employees details   
        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return db.tblUser.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record     
        public void AddUser(User user)
        {
            try
            {
                db.tblUser.Add(user);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateUser(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public User GetUserData(int id)
        {
            try
            {
                User user = db.tblUser.Find(id);
                return user;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee    
        public void DeleteUser(int id)
        {
            try
            {
                User usr = db.tblUser.Find(id);
                db.tblUser.Remove(usr);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
