using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomInitializer : DropCreateDatabaseIfModelChanges<ObjectiveContext>
    {
        protected override void Seed(ObjectiveContext context)
        {
            var objectiveList = new List<Objective>
            {
                new Objective {Text = "Do the dishes"},
                new Objective {Text = "Make dinner"},
                new Objective {Text = "Go to the gym with brother"},
                new Objective {Text = "Visit mom"},
                new Objective {Text = "Play basketball"}
            };

            var categoriesList = new List<Category>
            {
                new Category {Name = "Home"},
                new Category {Name = "Sport"},
                new Category {Name = "Family"}
            };

            categoriesList[0].Objectives.Add(objectiveList[0]);
            categoriesList[0].Objectives.Add(objectiveList[1]);

            categoriesList[1].Objectives.Add(objectiveList[2]);
            categoriesList[1].Objectives.Add(objectiveList[4]);

            categoriesList[2].Objectives.Add(objectiveList[2]);
            categoriesList[2].Objectives.Add(objectiveList[3]);

            context.Objectives.AddRange(objectiveList);
            context.Categories.AddRange(categoriesList);

            context.SaveChanges();
        }
    }
}
