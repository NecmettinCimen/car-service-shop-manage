using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aracyonetim.web.Controllers
{
    public interface IGenericController<T> where  T : class
    {
        public Task<IActionResult> List();
        public Task<IActionResult> Get(int id);
        public Task<IActionResult> Save([FromBody] T model);
        public Task<IActionResult> Remove(int id);
    }
}