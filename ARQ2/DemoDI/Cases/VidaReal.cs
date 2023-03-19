using System;

namespace DemoDI.Cases
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
           // Faz algo
          Console.WriteLine("Ola mundo");
        }
    }
  // tanto cliente service como cliente repositorio implementa o mesmo metodo
    public interface IClienteServices
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteServices : IClienteServices
    {
      //Adiciona outra interface
        private readonly IClienteRepository _clienteRepository;

        // no construtor e passado um contrato de um repositorio no lugar do contrato de serviço
        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        //faz referencia ao proprio contrato
        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}