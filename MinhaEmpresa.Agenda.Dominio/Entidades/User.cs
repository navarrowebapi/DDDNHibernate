using MinhaEmpresa.Agenda.Dominio.ValueObjects;
using MinhaEmpresa.SharedKernel.Dominio.Agregacoes;
using System.Collections.Generic;

namespace MinhaEmpresa.Agenda.Dominio.Entidades
{
    public class User : IAggregateRoot
    {
        public User(string userName)
        {
            UserName = userName;
        }
        public int Id { get; private set; }
        public string UserName { get; private set; }

        public Address Address { get; private set; }

        //Criação de 1 Endereço
        public void CreateNewAddress(string street1, string street2, string city,
            string region, string country, string postalCode)
        {
            Address = new Address(street1, street2, city, region, country, postalCode);
        }


        //public IList<Address> Address { get; private set; }

        ////Criação por uma Lista de Endereços
        //public void CreateNewAddress(IList<Address> enderecos)
        //{
        //    Address = new List<Address>();
        //    foreach (var endereco in enderecos)
        //    {
        //        Address.Add(endereco);
        //    }

        //}

        //Just for NHibernate
        public User()
        {   
        }
        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
        }
    }
}
