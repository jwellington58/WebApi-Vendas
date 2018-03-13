using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class FornecedoresController : ControllerBase<Fornecedor>
    {
        public FornecedoresController(DataContext context) : base(context)
        {
        }
    }
}