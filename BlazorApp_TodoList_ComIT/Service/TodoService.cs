using BlazorApp_TodoList_ComIT.Data;
using BlazorApp_TodoList_ComIT.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_TodoList_ComIT.Service
{
    public class TodoService
    {
        private readonly ApplicationDbContext _dbContext;

        public TodoService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All
        public List<Todo> GetTodos()
        {
            return _dbContext.Todos.ToList();
        }

        //Create
        public async Task<bool> CreatTodo(Todo todo)
        {
            await _dbContext.Todos.AddAsync(todo);
            _dbContext.SaveChanges();
            return true;
        }

        //Update
        public async Task<bool> UpdateTodo(Todo todo)
        {
            var isExist = await _dbContext.Todos.FirstOrDefaultAsync(x => x.Id == todo.Id);
            if (isExist != null)
            {
                isExist.IsChecked = todo.IsChecked;
                isExist.Content = todo.Content;
                _dbContext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}

