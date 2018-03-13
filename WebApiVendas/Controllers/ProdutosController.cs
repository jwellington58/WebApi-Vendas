using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class ProdutosController : ControllerBase<Produto>
    {
        public ProdutosController(DataContext context) : base(context)
        {
        }
    }
}