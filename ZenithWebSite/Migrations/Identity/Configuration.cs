namespace ZenithWebSite.Migrations.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithWebSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(ZenithWebSite.Models.ApplicationDbContext context)
        {
            context.Activities.AddOrUpdate(a => a.ActivityId, getActivities());
            context.SaveChanges();
            context.Events.AddOrUpdate(e => e.EventId, getEvents(context));
            context.SaveChanges();
        }

        private Event[] getEvents(ZenithWebSite.Models.ApplicationDbContext context)
        {
            var events = new List<Event>
            {
                new Event {EventId= 1, EventFrom =  new DateTime(2017, 03, 04, 8, 30, 0), EventTo =  new DateTime(2017, 03, 04, 10, 20, 0), EnteredBy = "richard93", ActivityId = 1, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 1).CreationDate, IsActive = false},
                new Event {EventId= 2, EventFrom = new DateTime(2017, 03, 04, 11, 30, 0), EventTo = new DateTime(2017, 03, 04, 12, 20, 0), EnteredBy = "richard93", ActivityId = 2, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 2).CreationDate, IsActive = true},
                new Event {EventId= 3, EventFrom = new DateTime(2017, 03, 04, 16, 30, 0), EventTo = new DateTime(2017, 03, 04, 18, 20, 0), EnteredBy = "lisha788", ActivityId = 3, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 3).CreationDate, IsActive = false},
                new Event {EventId= 4, EventFrom = new DateTime(2017, 04, 04, 9, 30, 0), EventTo = new DateTime(2017, 04, 04, 11, 20, 0), EnteredBy = "richard93", ActivityId = 4, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 4).CreationDate, IsActive = false},
                new Event {EventId= 5, EventFrom = new DateTime(2017, 04, 04, 12, 30, 0), EventTo = new DateTime(2017, 04, 04, 15, 20, 0), EnteredBy = "richard93", ActivityId = 5, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 5).CreationDate, IsActive = true},
                new Event {EventId= 6, EventFrom = new DateTime(2017, 04, 04, 16, 30, 0), EventTo = new DateTime(2017, 04, 04, 18, 20, 0), EnteredBy = "richard93", ActivityId = 6, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 6).CreationDate, IsActive = true},
                new Event {EventId= 7, EventFrom = new DateTime(2017, 05, 04, 9, 30, 0), EventTo = new DateTime(2017, 05, 04, 10, 20, 0), EnteredBy = "lisha788", ActivityId = 7, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 7).CreationDate, IsActive = false},
                new Event {EventId= 8, EventFrom = new DateTime(2017, 05, 04, 12, 30, 0), EventTo = new DateTime(2017, 05, 04, 13, 20, 0), EnteredBy = "lisha788", ActivityId = 8, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 8).CreationDate, IsActive = false},
                new Event {EventId= 9, EventFrom = new DateTime(2017, 05, 04, 14, 30, 0), EventTo = new DateTime(2017, 05, 04, 15, 50, 0), EnteredBy = "richard93", ActivityId = 9, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 9).CreationDate, IsActive = true},
                new Event {EventId= 10, EventFrom = new DateTime(2017, 05, 04, 16, 0, 0), EventTo = new DateTime(2017, 05, 04, 17, 20, 0), EnteredBy = "richard93", ActivityId = 10, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 10).CreationDate, IsActive = true},
                new Event {EventId= 11, EventFrom = new DateTime(2017, 06, 04, 8, 30, 0), EventTo = new DateTime(2017, 06, 04, 9, 20, 0), EnteredBy = "lisha788", ActivityId = 11, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 11).CreationDate, IsActive = false},
                new Event {EventId= 12, EventFrom = new DateTime(2017, 06, 04, 11, 30, 0), EventTo = new DateTime(2017, 06, 04, 13, 20, 0), EnteredBy = "richard93", ActivityId = 12, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 12).CreationDate, IsActive = true},
                new Event {EventId= 13, EventFrom =new DateTime(2017, 07, 04, 14, 30, 0), EventTo = new DateTime(2017, 07, 04, 16, 20, 0), EnteredBy = "lisha788", ActivityId = 13, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 13).CreationDate, IsActive = false},
                new Event {EventId= 14, EventFrom = new DateTime(2017, 08, 04, 8, 30, 0), EventTo = new DateTime(2017, 08, 04, 11, 20, 0), EnteredBy = "richard93", ActivityId = 14, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 14).CreationDate, IsActive = false},
                new Event {EventId= 15, EventFrom = new DateTime(2017, 08, 04, 13, 30, 0), EventTo =new DateTime(2017, 08, 04, 16, 20, 0), EnteredBy = "lisha788", ActivityId = 15, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 15).CreationDate, IsActive = true}
            };

            return events.ToArray();
        }

        private Activity[] getActivities()
        {
            var activities = new List<Activity>()
            {
                new Activity {ActivityId = 1, Description = "Senior's Golf Tournament", CreationDate = new DateTime(2017, 03, 04)},
                new Activity {ActivityId = 2, Description = "Leadership General Assembly Meeting", CreationDate = new DateTime(2017, 03, 04)},
                new Activity {ActivityId = 3, Description = "Youth Bowling Tournament", CreationDate = new DateTime(2017, 03, 04)},
                new Activity {ActivityId = 4, Description = "Young ladies cooking lessons", CreationDate = new DateTime(2017, 04, 04)},
                new Activity {ActivityId = 5, Description = "Youth craft leassons", CreationDate = new DateTime(2017, 04, 04)},
                new Activity {ActivityId = 6, Description = "Youth choir practice", CreationDate = new DateTime(2017, 04, 04)},
                new Activity {ActivityId = 7, Description = "Lunch", CreationDate = new DateTime(2017, 05, 04)},
                new Activity {ActivityId = 8, Description = "Pancake Breakfast", CreationDate = new DateTime(2017, 05, 04)},
                new Activity {ActivityId = 9, Description = "Swimming Lessons for the youth", CreationDate = new DateTime(2017, 05, 04)},
                new Activity {ActivityId = 10, Description = "Swimming Exercise for parents", CreationDate = new DateTime(2017, 05, 04)},
                new Activity {ActivityId = 11, Description = "Bingo Tournament", CreationDate = new DateTime(2017, 06, 04)},
                new Activity {ActivityId = 12, Description = "BBQ Lunch", CreationDate = new DateTime(2017, 06, 04)},
                new Activity {ActivityId = 13, Description = "Garage Sale", CreationDate = new DateTime(2017, 07, 04)},
                new Activity {ActivityId = 14, Description = "Youth Basketball Tournament", CreationDate = new DateTime(2017, 08, 04)},
                new Activity {ActivityId = 15, Description = "Senior Volleyball Tournament", CreationDate = new DateTime(2017, 08, 04)}
            };

            return activities.ToArray();
        }
    }
}