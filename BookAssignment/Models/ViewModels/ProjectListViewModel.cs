using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAssignment.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
