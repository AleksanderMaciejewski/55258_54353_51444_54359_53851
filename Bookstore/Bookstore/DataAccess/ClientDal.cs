using Bookstore.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.DataAccess
{
    public class ClientDal : IClientDal
    {
        private readonly ApplicationDbContext _context;

        public ClientDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddClientAsync(ClientModel client, CancellationToken ct)
        {
            _context.Clients.Add(client);
            return await _context.SaveChangesAsync(ct) > 0;
            // true if added successfully false if not
        }

        public async Task<bool> DeleteClientAsync(int id, CancellationToken ct)
        {
            var c = await _context.Clients.FindAsync(new object[] { id }, ct);
            if (c == null) return false;

            _context.Clients.Remove(c);
            return await _context.SaveChangesAsync(ct) > 0;
            // true if deleted successfully false if not
        }

        public async Task<bool> UpdateClientAsync(int id, ClientModel client, CancellationToken ct)
        {
            var c = await _context.Clients.FindAsync(new object[] { id }, ct);
            if (c == null) return false;

            c.Name = client.Name;

            _context.Clients.Update(c);
            return await _context.SaveChangesAsync(ct) > 0;
            // true if updated successfully false if not
        }

        public async Task<List<ClientModel>> GetClientsAsync(CancellationToken ct)
        {
            return await _context.Clients.ToListAsync(ct);
        }

        public async Task<ClientModel> GetClientByIdAsync(int id, CancellationToken ct)
        {
            return await _context.Clients.FindAsync(new object[] { id }, ct);
        }

    }
}
