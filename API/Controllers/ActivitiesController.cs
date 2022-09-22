using System;
using Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;


namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public DataContext _context { get; }
        public ActivitiesController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActvities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActvity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}