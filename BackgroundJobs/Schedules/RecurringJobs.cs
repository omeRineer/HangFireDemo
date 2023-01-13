using BackgroundJobs.Managers.RecurringJobs;
using Hangfire;

namespace BackgroundJobs.Schedules
{
    /// <summary>
    /// Zamanlanmış ve düzenli olarak çalışan job türüdür. Her hafta Her gün Her Saat gibi
    /// </summary>
    public static class RecurringJobs
    {
        /// <summary>
        /// Ürün eklendikten sonra Queue'ya kaydedilen job her bir dakikada bir bu metodu çalıştırır
        /// </summary>
        public static void AddedProductInfo()
        {
            RecurringJob.AddOrUpdate<ProductRecurringSchedulerJobs>(
                j => j.AddedProductInfo(),
                Cron.Minutely);
        }
    }
}
