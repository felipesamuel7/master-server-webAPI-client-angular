using System.Data.Entity;

namespace MyFoodServer.API.Context
{
    public class MyFoodContext : DbContext
    {
        public MyFoodContext() : base("DefaultConnection") { }

        public System.Data.Entity.DbSet<MyFoodServer.Dal.Models.Restaurante> Restaurantes { get; set; }

        public System.Data.Entity.DbSet<MyFoodServer.Dal.Models.Comida> Comidas { get; set; }
    }
}