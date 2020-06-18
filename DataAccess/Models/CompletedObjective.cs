﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("CompletedObjectives")]
    public class CompletedObjective : Objective
    {
        public DateTime CompletionDate { get; set; }
    }
}
