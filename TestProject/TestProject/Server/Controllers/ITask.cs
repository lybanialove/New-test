using Microsoft.EntityFrameworkCore;
using TestProject.Client.Pages;
using TestProject.Shared.Database;
using TestProject.Shared.Entitys;

namespace TestProject.Server.Controllers
{
    public class ITask : Task_
    {
        readonly Context _dbContext;
        public ITask(Context dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Task_> GetTaskDetails()
        {
            try
            {
                return _dbContext.Tasks.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void AddTask(Task_ task)
        {
            try
            {
                _dbContext.Tasks.Add(task);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void UpdateTaskDetails(Task_ task)
        {
            try
            {
                _dbContext.Entry(task).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public Task_ GetTaskData(int id)
        {
            try
            {
                Task_? user = _dbContext.Tasks.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        public void DeleteTask(int id)
        {
            try
            {
                Task_? user = _dbContext.Tasks.Find(id);
                if (user != null)
                {
                    _dbContext.Tasks.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
