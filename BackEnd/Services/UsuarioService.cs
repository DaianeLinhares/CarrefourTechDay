using BackEnd.Context;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEnd.Services
{
    public class UsuarioService : IUsuario
    {
        private readonly AddDbContext _context;

        public UsuarioService(AddDbContext context)
        {
            _context = context;
        }

        public async Task CreateUsuario(Usuario usuario)
        {
           _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> GetUsuario()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
