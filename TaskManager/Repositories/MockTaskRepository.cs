using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.IRepositories;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class MockTodoTaskRepository : ITodoTaskRepository
    {
        private List<TodoTask> _todoTaskList;
        public MockTodoTaskRepository()
        {
            //--Seeding--
            _todoTaskList = new List<TodoTask>() {
            new TodoTask(1, "Doctors Appointment", "Thursday at 5pm"),
            new TodoTask(2, "Take Exams", "Friday 10 June at 9am"),
            new TodoTask(3, "Give Blood", "Saturday 10 March at 12pm"),
            new TodoTask(4, "Turn in the Essay", "Monday 5 January at 3pm")
            };
        }

        public TodoTask GetTodoTask(int Id)
        {
            return _todoTaskList.FirstOrDefault(e => e.TodoTaskID == Id);
        }

        public IEnumerable<TodoTask> GetAllTodoTasks()
        {
            return _todoTaskList;
        }

        public TodoTask Add(TodoTask todoTask)
        {
            todoTask.TodoTaskID = _todoTaskList.Max(e => e.TodoTaskID) + 1;
            _todoTaskList.Add(todoTask);
            return todoTask;
        }

        public TodoTask Update(TodoTask todoTaskChanges)
        {
            var todoTask = _todoTaskList.FirstOrDefault(e => e.TodoTaskID == todoTaskChanges.TodoTaskID);
            if (todoTask != null)
            {
                todoTask.Title = todoTaskChanges.Title;
                todoTask.DateAndTime = todoTask.DateAndTime;
            }
            return todoTask;
        }

        public TodoTask Delete(int Id)
        {
            var todoTask = _todoTaskList.FirstOrDefault(e => e.TodoTaskID == Id);
            if (todoTask != null)
            {
                _todoTaskList.Remove(todoTask);
            }
            return todoTask;

        }
    }
}
