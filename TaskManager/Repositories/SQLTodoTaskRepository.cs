using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.IRepositories;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class SQLTodoTaskRepository : ITodoTaskRepository
    {
        public TodoTask Add(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public TodoTask Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoTask> GetAllTodoTasks()
        {
            throw new NotImplementedException();
        }

        public TodoTask GetTodoTask(int Id)
        {
            throw new NotImplementedException();
        }

        public TodoTask Update(TodoTask taskChanges)
        {
            throw new NotImplementedException();
        }
    }
}
