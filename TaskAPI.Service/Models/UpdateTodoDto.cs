using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Service.Models
{
    public class UpdateTodoDto
    {
        [Required(ErrorMessage ="You Must Put Title In Body In  Order To Update")]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created { set; get; }

        public DateTime Deu { set; get; }

        public TodoStatus Status { get; set; }
    }
}
