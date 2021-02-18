using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAssignment.Models
{
    public interface IBookListRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
