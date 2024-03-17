﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskApi.DataAccess;

namespace TaskAPI.Service.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllToDos(int authorId)
        {
            return _context.Todos.Where(t => t.AurthorId == authorId).ToList();
        }

        public Todo GetTodo(int authorId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AurthorId == authorId);
        }
    }
}
