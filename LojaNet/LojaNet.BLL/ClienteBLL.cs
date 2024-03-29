﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaNet.Models;
using LojaNet.DAL;



namespace LojaNet.BLL
{
    public class ClienteBLL : IClienteDados
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
            if(string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado");
            }
            if (string.IsNullOrEmpty(cliente.Id))
            {
                cliente.Id = Guid.NewGuid().ToString();

            }

            var dal = new ClienteDal();
            dal.Incluir(cliente);

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
            var dal = new ClienteDal();
            var lista = dal.ObterTodos();
            return lista;

        }
    }
}
