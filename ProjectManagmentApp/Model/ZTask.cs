﻿using ProjectManagmentApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Model
{   
    public class ZTask
    {
        public long Id = DateTime.Now.Ticks;
        public string TaskName { get; set; }
        public string Description { get; set; }

        public PriorityEnum Priority;
        public uint AssignedTo { get; set; }
        public uint AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }

        private List<Comment> _Comment = new List<Comment>();
        public List<Comment> Comment { get { return _Comment; } set { _Comment = value; } }

        private List<Reaction> _Reaction = new List<Reaction>();
        public List<Reaction> Reaction { get { return _Reaction; } set { _Reaction = value; } }

    }
}
