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
        async Task<IEnumerable<Usuario>> IUsuario.GetUsuarios()
        {
                return await _context.Usuarios.ToListAsync();
        }
        public async Task<Usuario> GetUsuario(int id)
        {
           var usuario = await _context.Usuarios.FindAsync(id);
            return usuario;
        }
        public async Task CreateUsuario(Usuario usuario)
        {
           _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
        public async Task DeleteUsuario(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        } 
    }
}
