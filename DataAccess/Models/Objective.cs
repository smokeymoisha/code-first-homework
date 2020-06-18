using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Objective
    {
        public Objective()
        {
            Categories = new List<Category>();
            IsCompleted = false;
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCompleted { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
