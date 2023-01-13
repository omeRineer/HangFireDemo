using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Managers.DelayedJobs
{
    public class ProductDelayedSchedulerJob
    {
        public void ProductAddedInfoSendEmail(Product product, string email)
        {
            Console.WriteLine($"{product.ProductName} ürün eklenme bilgisi {email} mailine iletildi");
        }
    }
}
