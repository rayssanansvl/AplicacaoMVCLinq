using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c3 = new Cliente(3, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c4 = new Cliente(4, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c5 = new Cliente(5, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
