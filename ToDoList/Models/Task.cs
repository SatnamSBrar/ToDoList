﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }

        public string TaskName { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("List")]
        public int ListID { get; set; }

        
    }
}