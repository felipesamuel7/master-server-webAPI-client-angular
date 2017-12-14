using MyFoodServer.Dal.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace MyFoodServer.API.Context
{
    public class MyFoodDatabaseInitializer : DropCreateDatabaseIfModelChanges<MyFoodContext>
    {
        protected override void Seed(MyFoodContext context)
        {
            base.Seed(context);

            Restaurante restauranteA = new Restaurante { Id = 1, Nome = "Restaurante A", Cidade = "Uberlândia", Logradouro = "Rua A", Numero = 10, Bairro = "Centro", Estado = "MG", Telefone = "3322-2233" };
            context.Restaurantes.Add(restauranteA);
            context.Comidas.AddOrUpdate(
                new Comida { Nome = "X-Burger", Valor = 15.5, Restaurante = restauranteA },
                new Comida { Nome = "X-Frango", Valor = 10.5, Restaurante = restauranteA },
                new Comida { Nome = "X-Bacon", Valor = 12.5, Restaurante = restauranteA },
                new Comida { Nome = "X-Salada", Valor = 9.5, Restaurante = restauranteA });

            Restaurante restauranteB = new Restaurante { Id = 2, Nome = "Restaurante B", Cidade = "Uberlândia", Logradouro = "Rua B", Numero = 10, Bairro = "Luizote", Estado = "MG", Telefone = "3322-3344" };
            context.Restaurantes.AddOrUpdate(restauranteB);
            context.Comidas.AddOrUpdate(
                new Comida { Nome = "X-Burger", Valor = 12.5, Restaurante = restauranteB },
                new Comida { Nome = "X-Frango", Valor = 13.5, Restaurante = restauranteB },
                new Comida { Nome = "X-Bacon", Valor = 18.5, Restaurante = restauranteB },
                new Comida { Nome = "X-Salada", Valor = 16.5, Restaurante = restauranteB });

            Restaurante restauranteC = new Restaurante { Id = 3, Nome = "Restaurante C", Cidade = "Uberlândia", Logradouro = "Rua C", Numero = 10, Bairro = "Morumbi", Estado = "MG", Telefone = "3322-4455" };
            context.Restaurantes.AddOrUpdate(restauranteC);
            context.Comidas.AddOrUpdate(
                new Comida { Nome = "X-Burger", Valor = 15.9, Restaurante = restauranteC },
                new Comida { Nome = "X-Frango", Valor = 10.3, Restaurante = restauranteC },
                new Comida { Nome = "X-Bacon", Valor = 12.98, Restaurante = restauranteC },
                new Comida { Nome = "X-Salada", Valor = 9.9, Restaurante = restauranteC });

            Restaurante restauranteD = new Restaurante { Id = 4, Nome = "Restaurante D", Cidade = "Uberlândia", Logradouro = "Rua D", Numero = 10, Bairro = "Santa Mônica", Estado = "MG", Telefone = "3322-5566" };
            context.Restaurantes.AddOrUpdate(restauranteD);
            context.Comidas.AddOrUpdate(
                new Comida { Nome = "X-Burger", Valor = 16.75, Restaurante = restauranteD },
                new Comida { Nome = "X-Frango", Valor = 22.80, Restaurante = restauranteD },
                new Comida { Nome = "X-Bacon", Valor = 10.48, Restaurante = restauranteD },
                new Comida { Nome = "X-Salada", Valor = 7.59, Restaurante = restauranteD });

            Restaurante restauranteE = new Restaurante { Id = 5, Nome = "Restaurante E", Cidade = "Uberlândia", Logradouro = "Rua E", Numero = 10, Bairro = "Tibery", Estado = "MG", Telefone = "3322-6677" };
            context.Restaurantes.AddOrUpdate(restauranteE);
            context.Comidas.AddOrUpdate(
                new Comida { Nome = "X-Burger", Valor = 20.65, Restaurante = restauranteE },
                new Comida { Nome = "X-Frango", Valor = 16.65, Restaurante = restauranteE },
                new Comida { Nome = "X-Bacon", Valor = 18.52, Restaurante = restauranteE },
                new Comida { Nome = "X-Salada", Valor = 8.99, Restaurante = restauranteE });

            context.SaveChanges();
        }
    }
}