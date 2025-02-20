using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Domain.Models;

namespace Tarefa3.Application.Services
{
    public class PersonService : IPersonService
    {
        public async Task<List<Person>> GetAll()
        {
            return new List<Person>
            {
                new Person { Id = 1, Nome = "Leonardo Tristao", Idade = 20, Endereco = "Rua Doutor Antonio da Costa Carvalho 555" },
                new Person { Id = 2, Nome = "Hyan Schibelsky", Idade = 18, Endereco = "Rua Ariosvaldo Luis Mazon 284"},
                new Person { Id = 3, Nome = "Kairos Murilo", Idade = 18 , Endereco = "Rua do Peixe 2"},
                new Person { Id = 4, Nome = "Andre Barros", Idade = 19 , Endereco = "Avenida John Boyd Dunlop 3"}
            };
        }
    }
}