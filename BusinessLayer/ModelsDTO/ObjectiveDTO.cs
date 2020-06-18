using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ModelsDTO
{
    public class ObjectiveDTO
    {
        public ObjectiveDTO()
        {
            Categories = new List<CategoryDTO>();
            IsCompleted = false;
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCompleted { get; set; }

        public ICollection<CategoryDTO> Categories { get; set; }
    }
}
