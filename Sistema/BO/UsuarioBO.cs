using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAO;
using Sistema.Model;
using System.Windows.Forms;

namespace Sistema.BO
{
    public class UsuarioBO : UtilBase, IPersistence
    {
        //=============================================
        //========= METHOD PUBLIC =====================
        //=============================================

        public void save<Usuario> (Usuario usu)
        {
            if (validateFields(usu))
            {
                UsuarioDAO usuDAO = new UsuarioDAO();
                usuDAO.save(usu);
            }
        }

        public void delete (Usuario usuario)
        {
            UsuarioDAO usuDAO = new UsuarioDAO();
            usuDAO.delete(usuario.id);
        }

        public void update (Usuario usuario)
        {
            if (validateFields(usuario))
            {
                UsuarioDAO usuDAO = new UsuarioDAO();
                usuDAO.update();
            }
        }

        public List<Usuario> getByAll ()
        {
            UsuarioDAO usuDAO = new UsuarioDAO();
            return usuDAO.getByAll();
        }

        //=============================================
        //========= METHOD PRIVATE ====================
        //=============================================

        private bool validateFields<Usuario> (Usuario usuario)
        {
            if (!validateName(usuario.nome))
            {
                MessageBox.Show("Este nome é inválido!");
                return false;
            }

            if (typePerson(usuario.is_fisica))
            {
                if (validateFisicaPerson(usuario.cpf))
                {
                    MessageBox.Show("CPF incorreto!");
                    return false;
                }
            }
            else
            {
                if (validateJuridicaPerson(usuario.cnpj))
                {
                    MessageBox.Show("CNPJ incorreto!");
                    return false;
                }
            }

            return true;
        }

        private bool typePerson (int isFisica) 
        {
            if (isFisica == 1)
            {
                return true;
            }

            return false;
        }

        private bool validateFisicaPerson (string cpf)
        {
            if (String.IsNullOrEmpty(cpf))
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(cpf))
            {
                return false;
            }

            if (cpf.Length != 11)
            {
                return false;
            }

            return true;
        }

        private bool validateJuridicaPerson (string cnpj)
        {
            if (String.IsNullOrEmpty(cnpj))
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(cnpj))
            {
                return false;
            }

            if (cnpj.Length != 14)
            {
                return false;
            }

            return true;
        }
    }
}
