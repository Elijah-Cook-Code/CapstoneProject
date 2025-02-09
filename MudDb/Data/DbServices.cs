using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MudDb.Data
{
    public class DatabaseService
    {
        private readonly AppDbContext _context;

        
        public DatabaseService(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Client>> GetClientsAsync()
        {
            try
            {
                Console.WriteLine("🔍 Running DB Query: SELECT * FROM Clients");
                var clients = await _context.Clients.ToListAsync();

                Console.WriteLine($"📦 Retrieved {clients.Count} clients from database.");

                if (clients.Count > 0)
                {
                    foreach (var client in clients)
                    {
                        Console.WriteLine($"📝 Client ID: {client.Id}, Name: {client.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("⚠️ No clients in database.");
                }

                return clients;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"🚨 Database Error: {ex.Message}");
                return new List<Client>(); // Prevent crashes
            }
        }






        public async Task AddClientAsync(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClientAsync(Client client)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}
