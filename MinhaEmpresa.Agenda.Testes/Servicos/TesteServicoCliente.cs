using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinhaEmpresa.Agenda.Dominio.Entidades;
using MinhaEmpresa.Agenda.Dominio.Servicos;

namespace MinhaEmpresa.Agenda.Testes.Servicos
{
    [TestClass]
    public class TesteServicoCliente : TesteRepositorioBase
    {
        public ServicoCliente Servico { get; set; }

        public TesteServicoCliente() 
        {
            Servico = new ServicoCliente();
        }


        [TestMethod]
        public void PodeConsultarSeVipEPossuiEmail()
        {
            using (var sessao = Helper.AbrirSessao())
            {
                var cliente = new Cliente();
                cliente.Nome = "Asdrubal";
                cliente.Email = "asdrubal@nomesbons.com";
                cliente.Ativo = true;
                var retorno = Servico.ClientesVipEPossuiEmail(cliente);

                Console.WriteLine();
                Console.WriteLine(@"VERIFICA EMAIL E VIP:");
                Console.WriteLine(@"=====================================");
                Assert.AreEqual(retorno, true);
            }


        }


    }
}
