using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class ClientesController : ControllerBase<Cliente>
    {
        public ClientesController(DataContext context) : base(context)
        {
        }
    }
}