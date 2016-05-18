using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaEmpresa.Agenda.Dominio.Entidades;

namespace MinhaEmpresa.Agenda.Dominio.Servicos
{
    public class ServicoCliente
    {

        public ServicoCliente()
        {
            
        }
        //Simulando um Serviço de Domínio (aquele que agrega funções e disponibiliza para a
        //as camadas superiores.
        public bool ClientesVipEPossuiEmail(Cliente cliente)
        {
            if (cliente.ClienteVip() && !string.IsNullOrEmpty(cliente.Email))
            {
                return true;
            }
            return false;
        }
    }
}
