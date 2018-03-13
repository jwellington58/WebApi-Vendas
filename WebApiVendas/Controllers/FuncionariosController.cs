using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class FuncionariosController : ControllerBase<Funcionario>
    {
        public FuncionariosController(DataContext context) : base(context)
        {
        }
    }
}