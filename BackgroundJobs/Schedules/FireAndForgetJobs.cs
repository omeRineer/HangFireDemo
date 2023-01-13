using BackgroundJobs.Managers.FireAndForgetJobs;
using Entities;
using Hangfire;

namespace BackgroundJobs.Schedules
{
    /// <summary>
    /// Bir kere ve hemen çalışan job tipidir
    /// </summary>
    public static class FireAndForgetJobs
    {
        public static void ProductLogJob(Product product)
        {
            BackgroundJob.Enqueue<ProductSchedulerJob>(j => j.Run(product));
        }
    }
}
