using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ModelsDTO
{
    public class CategoryDTO
    {   
        public CategoryDTO()
        {
            Objectives = new List<ObjectiveDTO>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ObjectiveDTO> Objectives { get; set; }
    }
}
