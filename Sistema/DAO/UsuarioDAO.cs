using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;

namespace Sistema.DAO
{
    public class UsuarioDAO
    {
        private DB_Model db_base;

        public UsuarioDAO ()
        {
            db_base = new DB_Model();
        }

        public void save (Usuario usuario)
        {
            db_base.Usuario.Add(usuario);
            db_base.SaveChanges();
        }

        public void delete (int id)
        {
            var usuario = (db_base.Usuario.First(usu => usu.id == id));
            db_base.Usuario.Remove(usuario);
            db_base.SaveChanges();
        }

        public Usuario getById (int id)
        {
            var usuario = (db_base.Usuario.First( usu => usu.id == id));
            return usuario;
        }

        public List<Usuario> getByAll ()
        {
            var usuario = (db_base.Usuario.ToList());
            return usuario;
        }

        public void update ()
        {
            db_base.SaveChanges();
        }
    }
}
