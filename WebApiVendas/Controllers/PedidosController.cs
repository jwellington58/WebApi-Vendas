using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class PedidosController : ControllerBase<Pedido>
    {
        public PedidosController(DataContext context) : base(context)
        {
        }
    }
}