using aracyonetim.web.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace aracyonetim.web.Controllers
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