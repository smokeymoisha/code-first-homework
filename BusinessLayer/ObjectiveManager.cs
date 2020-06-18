using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using BusinessLayer.ModelsDTO;
using DataAccess;

namespace BusinessLayer
{
    public class ObjectiveManager
    {
        private readonly Mapper _mapper;

        public ObjectiveManager()
        {
            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Objective, ObjectiveDTO>();
                cfg.CreateMap<CompletedObjective, CompletedObjectiveDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            _mapper = new Mapper(conf);
        }

        public IList<ObjectiveDTO> GetAllObjectives()
        {
            using(var context = new ObjectiveContext())
            {
                return _mapper.Map<IList<ObjectiveDTO>>(context.Objectives.ToList());
            }
        }

        public IList<CategoryDTO> GetAllCategories()
        {
            using (var context = new ObjectiveContext())
            {
                return _mapper.Map<IList<CategoryDTO>>(context.Categories.ToList());
            }
        }

        public IList<CompletedObjectiveDTO> GetAllCompletedObjectives()
        {
            using (var context = new ObjectiveContext())
            {
                return _mapper.Map<IList<CompletedObjectiveDTO>>(context.CompletedObjectives.ToList());
            }
        }

        public void CompleteObjectiveById(int id)
        {
            using(var context = new ObjectiveContext())
            {
                var objective = context.Objectives.FirstOrDefault(obj => obj.Id == id);

                objective.IsCompleted = true;

                context.SaveChanges();

                //SQL Trigger (it works, I checked):

                //CREATE TRIGGER Objective_Complete
                //ON Objectives
                //AFTER UPDATE
                //AS
                //INSERT INTO CompletedObjectives
                //SELECT i.Id, GETDATE()
                //FROM Objectives o
                //INNER JOIN INSERTED i on o.Id = i.id
                //AND i.IsCompleted = 1
            }
        }
    }
}
