using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAssignment.Models
{
    public class EFBookListRepository : IBookListRepository 
    {
        private BookDbContext _context;

        //constructor
        public EFBookListRepository (BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
