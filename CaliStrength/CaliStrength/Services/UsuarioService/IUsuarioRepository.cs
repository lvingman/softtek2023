using CaliStrength.Models;

namespace CaliStrength.Services.UsuarioService
{
    public interface IUsuarioRepository
    {
        Task <IEnumerable<Usuario>> ListarUsuarios();
        Task<Usuario> ObtenerUsuarioPorId(int id);
        Task AgregarUsuario(Usuario usuario);
        Task ActualizarUsuario(Usuario usuario);
        Task BorrarUsuario(Usuario usuario);
    }
}