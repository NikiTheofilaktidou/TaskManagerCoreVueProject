using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.IRepositories
{
    public interface ITodoTaskRepository
    {
        TodoTask GetTodoTask(int Id);
        IEnumerable<TodoTask> GetAllTodoTasks();
        TodoTask Add(TodoTask task);
        TodoTask Update(TodoTask taskChanges);
        TodoTask Delete(int Id);
    }
}
