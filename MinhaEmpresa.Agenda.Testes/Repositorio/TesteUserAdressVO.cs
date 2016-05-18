using System;
using System.Collections.Generic;
using MinhaEmpresa.Agenda.Dominio.Entidades;
using MinhaEmpresa.Agenda.Dominio.ValueObjects;
using MinhaEmpresa.SharedKernel.Repositorio;
using NUnit.Framework;

namespace MinhaEmpresa.Agenda.Testes.Repositorio
{
    [TestFixture]
    public class TesteUserAdressVo : TesteRepositorioBase
    {
        [TestFixtureSetUp]
        public void SetupContext()
        {
            
        }

        //[Test]
        //public void PodePersistirUmUsuarioComVariosEnderecosValueObject()
        //{
        //    using (var sessao = Helper.AbrirSessao())
        //    {

        //        try
        //        {
        //            var usuario = new User("Aldreen");
        //            var end1 = new Address("Rua111", "Rua2", "Marilia", "CentroOeste", "Brasil", "17500-111");
        //            var end2 = new Address("Rua222", "Rua2", "Marilia", "CentroOeste", "Brasil", "17500-222");
        //            var ends = new List<Address> { end1, end2 };
        //            usuario.CreateNewAddress(ends);

        //            sessao.IniciaTransacao();

        //            var repo = sessao.GetRepositorio<User>();
        //            repo.Inclui(usuario);

        //            sessao.ComitaTransacao();
        //        }
        //        catch (Exception ex)
        //        {
        //            sessao.RollBackTransacao();
        //            Assert.Fail(ex.ToString());
        //        }
        //    }
        //}

        [Test]
        public void PodePersistirUmUsuarioComUnicoEnderecoSendoUmValueObject()
        {
            using (var sessao = Helper.AbrirSessao())
            {

                try
                {
                    var usuario = new User("Joan Baez");
                    //usuario.Address.City = "asda"; 
                    //NAO POSSO FAZER ISSO, POIS ADDRESS POSSUI sets privados. Tenho q usar o metodo existente 
                    //já definido para este caso, pois ADRRESS é um ValueObject.

                    usuario.CreateNewAddress("Rua1", "Rua2", "Marilia", "CentroOeste", "Brasil", "17500-000");

                    sessao.IniciaTransacao();

                    var repo = sessao.GetRepositorio<User>();
                    repo.Inclui(usuario);

                    sessao.ComitaTransacao();
                }
                catch (Exception ex)
                {
                    sessao.RollBackTransacao();
                    Assert.Fail(ex.ToString());
                }
            }
        }
    }
}