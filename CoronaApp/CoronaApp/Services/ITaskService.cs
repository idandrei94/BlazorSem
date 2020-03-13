using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaApp.Data;

namespace CoronaApp.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Aufgabe>> GetAll();
        Task Add(Aufgabe aufgabe);
        Task Update(Aufgabe aufgabe);
    }
}
