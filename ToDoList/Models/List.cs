using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }

        public string Title { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } //ICollection is collection made up of inputs from model Task, and is called Tasks

    }
}