using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Category
    {   
        public Category()
        {
            Objectives = new List<Objective>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Objective> Objectives { get; set; }
    }
}
