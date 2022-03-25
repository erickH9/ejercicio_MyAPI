using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ejercicio_myApiWeb.Models;

namespace ejercicio_myApiWeb.Controllers
{
    public class ProductsController : ApiController
    {
        // Introducción a web API 2 | Crear API: https://docs.microsoft.com/es-mx/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api
        // ProductsController | Insertar POST, PUT y DELETE al controlador: https://github.com/dotnet/AspNetDocs/blob/main/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client/sample/server/ProductsApp/Controllers/ProductsController.cs
        // Llamada a Web API desde un cliente | Consumo de la API GET, POST, PUT y DETELE: https://docs.microsoft.com/es-mx/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

        // HttpClient | Definición: https://docs.microsoft.com/es-mx/dotnet/api/system.net.http.httpclient?view=net-6.0#see-also
        // Enrutar en ASP.NET Web API: https://docs.microsoft.com/es-mx/aspnet/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api
        // Usar Migraciones de Code First para seed the Database | Exploración de la API: https://docs.microsoft.com/es-mx/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-3
        // Error CORS: https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0
        // Plugin de VS code: Thundes Client

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
