﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Common;

namespace DAL.Entities
{
    public class Lesson : BaseEntity
    {
        public required string Title { get; set; }
        public string? Description { get; set; }

    }
}
