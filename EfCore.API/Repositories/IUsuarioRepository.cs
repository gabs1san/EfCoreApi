using eCommerce.Models;

namespace EfCore.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();

        Usuario GetUsuario();

        void Add(Usuario usuario);

        void Update(Usuario usuario);

        void Delete(int id);
    }
}
