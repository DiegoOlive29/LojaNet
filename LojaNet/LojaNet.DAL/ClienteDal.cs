using LojaNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet.DAL
{
    public class ClienteDal : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string Id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            DbHelper.ExecuteNonquery("ClienteIncluir",
                "@Id", cliente.Id,
                "@Nome", cliente.Nome,
                "@Email", cliente.Email,
                "@Telefone", cliente.Telefone
                );
        }

        public Cliente ObterPorEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()

        {
            var lista = new List<Cliente>();
            using(var reader = DbHelper.ExecuteReader("ClienteListar"))
            {
                while (reader.Read())
                {
                    var cliente = new Cliente();
                    cliente.Id = reader["Id"].ToString();
                    cliente.Nome = reader["Nome"].ToString();
                    cliente.Email = reader["Email"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();

                    lista.Add(cliente);
                }
            }
            return lista;
        }
    }
}
