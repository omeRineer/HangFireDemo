using BackgroundJobs.Managers.DelayedJobs;
using Entities;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Schedules
{
    /// <summary>
    /// Oluşturulduktan belirli bir zaman sonra sadece bir sefer çalışan job tipidir
    /// </summary>
    public static class DelayedJobs
    {
        /// <summary>
        /// Ürün eklendikten 10 saniye sonra emaile bilgi gider
        /// </summary>
        /// <param name="product"></param>
        public static void ProductAddedSendEmail(Product product)
        {
            BackgroundJob.Schedule<ProductDelayedSchedulerJob>(
                j => j.ProductAddedInfoSendEmail(product, "omer@gmail.com"),
                TimeSpan.FromSeconds(10));
        }
    }
}
