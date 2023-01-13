using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Managers.FireAndForgetJobs
{
    public class ProductSchedulerJob
    {
        /// <summary>
        /// Ürün eklendikten hemen sonra bir sefer bu job operasyonu tetiklenir ve kaldırılır
        /// </summary>
        /// <param name="product"></param>
        public void Run(Product product)
        {
            Console.WriteLine($"{product.ProdcutCode} {product.ProductName} isimli ürün eklendi");
        }
    }
}
