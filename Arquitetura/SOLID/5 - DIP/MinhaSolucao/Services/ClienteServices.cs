using SOLID._5___DIP.MinhaSolucao.Interfaces;
using SOLID._5___DIP.MinhaSolucao.Models;
using SOLID._5___DIP.MinhaSolucao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___DIP.MinhaSolucao.Services
{
  public class ClienteServices : IClienteServices
  {
    private readonly IClienteRepository _clienteRepository;
    private readonly IEmailService _emailService;

    public ClienteServices(IClienteRepository clienteRepository, IEmailService emailService)
    {
      _clienteRepository = clienteRepository;
      _emailService = emailService;
    }


    public string AdicionarCliente(Cliente cliente)
    {
      if (!cliente.Validar())
        return "Dados inválidos";
      _clienteRepository.AdicionarCliente(cliente);

      _emailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");
      return "Cliente cadastrado com sucesso";
    }
  }

  public class TesteUtilizacao
  {
    public TesteUtilizacao()
    {
      Cliente pedro = new Cliente()
      {
        ClienteId = 2,
        Cpf = new Cpf() { Numero = "99999999999" },
        DataCadastro = DateTime.Now,
        Email = new Email() { Endereco = "Toninho@teste.com.br" },
        Nome = "Antonio Rubens Nascimento"
      };

      ClienteServices cliente = new ClienteServices(new ClienteRepository(), new EmailServices());
      cliente.AdicionarCliente(pedro);
    }
  }
}
