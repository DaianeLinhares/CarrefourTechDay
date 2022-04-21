using BackEnd.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEnd.Services
{
    public interface IUsuario
    {
        Task<IEnumerable<Usuario>> GetUsuario();
        Task CreateUsuario(Usuario usuario);
        Task UpdateUsuario(Usuario usuario);
        Task DeleteUsuario(Usuario usuario);
    }
}
