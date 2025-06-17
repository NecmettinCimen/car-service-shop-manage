using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Entities.Dtos
{
    public class DataGridDto<T> where T : class
    {
        public List<T> data { get; set; }
        public int totalCount { get; set; }
        public string key { get; set; }
    }

    public class GenerateDataGridDto<T> where T : class
    {

        public static async Task<DataGridDto<T>> Store(IQueryable<T> queryable)
        {
            return new DataGridDto<T>()
            {
                data = await queryable.ToListAsync(),
                totalCount = await queryable.CountAsync()
            };
        }
        public static async Task<DataGridDto<T>> Store(IQueryable<T> queryable, string key)
        {
            return new DataGridDto<T>()
            {
                data = await queryable.ToListAsync(),
                totalCount = await queryable.CountAsync(),
                key = key
            };
        }
    }
}