using Microsoft.AspNetCore.Components;
using CoronaApp.Data.Persistence;
using System.Threading.Tasks;
using CoronaApp.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoronaApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(
            AppDbContext context
            )
        {
            _context = context;
        }

        public async Task Add(Aufgabe aufgabe)
        {
            _context.Aufgaben.Add(aufgabe);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aufgabe>> GetAll()
        {
            return await _context.Aufgaben.ToArrayAsync();
        }

        public async Task Update(Aufgabe aufgabe)
        {
            var old = await _context.Aufgaben.FirstOrDefaultAsync(a => a.ID == aufgabe.ID);
            if(old != null)
            {
                old.Text = aufgabe.Text;
                old.Erledigt = aufgabe.Erledigt;
                old.ErledigtBis = aufgabe.ErledigtBis;
                await _context.SaveChangesAsync();
            }
        }
    }
}
