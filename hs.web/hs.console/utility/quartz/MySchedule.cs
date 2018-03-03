using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility.quartz
{
    public class MySchedule
    {
        /// <summary>
        /// 执行任务调度
        /// cron-like表达式
        /// </summary>
        public static void Start()
        {
            //1.首先创建一个作业调度池
            ISchedulerFactory schedf = new StdSchedulerFactory();
            IScheduler sched = schedf.GetScheduler();
            //2.创建出来一个具体的作业
            IJobDetail job = JobBuilder.Create<MyJob>().Build();
            //3.创建并配置一个触发器
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                .StartAt(DateTime.Now)
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(3).WithRepeatCount(20)).Build();
            //4.加入作业调度池中
            sched.ScheduleJob(job, trigger);
            //5.开始运行
            sched.Start();
        }
    }
}
