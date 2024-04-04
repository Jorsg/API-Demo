using DemoAPI.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Repositories
{
	public class TaskRepository : ITask
	{
		public Task<Task> Add(Task task)
		{
			throw new NotImplementedException();
		}

		public Task<Task> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Task> Delete(Task task)
		{
			throw new NotImplementedException();
		}

		public Task<Task> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Task>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Task> Update(Task task)
		{
			throw new NotImplementedException();
		}
	}
}
