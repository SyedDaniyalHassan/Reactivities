using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController:BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> Get()
        {
            return await _context.Activity.ToListAsync();
        }

        [HttpGet("{id}")] // find by id
        public async Task<ActionResult<Activity>> Get(Guid id)
        {
            return await _context.Activity.FindAsync(id) ;
        }
    }
}