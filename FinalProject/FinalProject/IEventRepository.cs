using System;
using FinalProject.Models;

namespace FinalProject
{
	public interface IEventRepository
	{
        public IEnumerable<Event> GetAllEvents();
    }

}

