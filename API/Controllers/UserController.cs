using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.DataBase;
using API.Entities;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers

{
     [ApiController]
     [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context){
            _context = context;
        }
       
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser(){
              return await  _context.Users.ToListAsync();
          
        }
          [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){
             return await  _context.Users.FindAsync(id);
              
        }
    }
}