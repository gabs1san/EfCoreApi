using eCommerce.Models;
using EfCore.API.Database;

namespace EfCore.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EfCoreContext _db;
        public UsuarioRepository(EfCoreContext db)
        {
            _db = db;
        }
        public List<Usuario> Get()
        {
            return _db.Usuarios.OrderBy(a => a.Id).ToList();
        }
        public Usuario Get(int id)
        {
            return _db.Usuarios.Find(id)!;
        }
        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
            _db.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _db.Update(usuario);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }

        
    }
}
