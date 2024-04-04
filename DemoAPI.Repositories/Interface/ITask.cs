using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Repositories.Interface
{
	public interface ITask
	{
		Task<IEnumerable<Task>> GetAll();
		Task<Task> Get(int id);
		Task<Task> Add(Task task);
		Task<Task> Update(Task task);
		Task<Task> Delete(int id);
		Task<Task> Delete(Task task);
	}
}
