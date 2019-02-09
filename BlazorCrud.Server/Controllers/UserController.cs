using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Server.DataAccess;
using BlazorCrud.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorCrud.Server.Controllers
{
    public class UserController : Controller
    {
        UserDataAccessLayer objemployee = new UserDataAccessLayer();

        [HttpGet]
        [Route("api/User/Index")]
        public IEnumerable<User> Index()
        {
            return objemployee.GetAllUsers();
        }

        [HttpPost]
        [Route("api/User/Create")]
        public void Create([FromBody] User user)
        {
            if (ModelState.IsValid)
                objemployee.AddUser(user);
        }

        [HttpGet]
        [Route("api/User/Details/{id}")]
        public User Details(int id)
        {

            return objemployee.GetUserData(id);
        }

        [HttpPut]
        [Route("api/User/Edit")]
        public void Edit([FromBody]User user)
        {
            if (ModelState.IsValid)
                objemployee.UpdateUser(user);
        }

        [HttpDelete]
        [Route("api/User/Delete/{id}")]
        public void Delete(int id)
        {
            objemployee.DeleteUser(id);
        }
    }
}
