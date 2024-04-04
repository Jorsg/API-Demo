using DemoAPI.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Repositories.Interface
{
	public interface IEvent
	{
		Task<IEnumerable<Event>> GetAll();
		Task<Event> Get(int id);
		Task<Event> Add(Event Event);
		Task<Event> Update(Event Event);
		Task<Event> Delete(int id);
	}
}
