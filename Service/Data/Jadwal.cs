//using System;
//using System.Collections.Specialized;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Services;
//using System.Web.Routing;
//using Quartz;
//using Quartz.Impl;
//using Service.Service;

//namespace Service.Data
//{
//    public class Jadwal
//    {
//        public static void Start()
//        {

//            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

//            if (!scheduler.IsStarted)
//                scheduler.Start();

//            IJobDetail job = JobBuilder.Create<DBJob>()
//                .WithIdentity("dbjob", "rm")
//                .Build();

//            ITrigger trigger = TriggerBuilder.Create()
//                .WithIdentity("dbjob", "rm")
//                .StartNow()
//                .WithSimpleSchedule(x => x
//                    .WithIntervalInSeconds(20)
//                    .RepeatForever())
//                .Build();

//            if (scheduler.CheckExists(new JobKey("dbjob", "rm")))
//            {
//                scheduler.DeleteJob(new JobKey("dbjob", "rm"));
//            }

//            scheduler.ScheduleJob(job, trigger);
//        } 
//    }

//    public class DBJob : IJob
//    {
//        public void Execute(IJobExecutionContext context)
//        {
//            Kondisi kon = new Kondisi();
//            RekamMedis rm = new RekamMedis();
//            RekamObat ro = new RekamObat();
//            RekamTerapi rt = new RekamTerapi();

//            kon.database();
//            rm.database();
//            ro.database();
//            rt.database();
//        }
//    }

//}