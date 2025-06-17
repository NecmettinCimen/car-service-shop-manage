using System.Threading.Tasks;
using CarServiceShopManage.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceShopManage.Web.Controllers
{
    public interface IGenericController<T> where T : class
    {
        [MenuFilter]
        public Task<IActionResult> List();
        [MenuFilter]
        public Task<IActionResult> Get(int id);
        [MenuFilter]
        public Task<IActionResult> Save([FromBody] T model);
        [MenuFilter]
        public Task<IActionResult> Remove(int id);
    }
}