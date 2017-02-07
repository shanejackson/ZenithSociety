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
                new Event {EventId= 1, EventFrom =  new DateTime(2017, 03, 04, 8, 30, 0), EventTo =  new DateTime(2017, 03, 04, 10, 20, 0), EnteredBy = "johnny", ActivityId = 1, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 1).CreationDate, IsActive = false},
                new Event {EventId= 2, EventFrom = new DateTime(2017, 03, 04, 11, 30, 0), EventTo = new DateTime(2017, 03, 04, 12, 20, 0), EnteredBy = "johnny", ActivityId = 2, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 2).CreationDate, IsActive = true},
                new Event {EventId= 3, EventFrom = new DateTime(2017, 03, 04, 16, 30, 0), EventTo = new DateTime(2017, 03, 04, 18, 20, 0), EnteredBy = "mary", ActivityId = 3, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 3).CreationDate, IsActive = false},
                new Event {EventId= 4, EventFrom = new DateTime(2017, 04, 04, 9, 30, 0), EventTo = new DateTime(2017, 04, 04, 11, 20, 0), EnteredBy = "johnny", ActivityId = 4, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 4).CreationDate, IsActive = false},
                new Event {EventId= 5, EventFrom = new DateTime(2017, 04, 04, 12, 30, 0), EventTo = new DateTime(2017, 04, 04, 15, 20, 0), EnteredBy = "mary", ActivityId = 5, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 5).CreationDate, IsActive = true},
                new Event {EventId= 6, EventFrom = new DateTime(2017, 04, 04, 16, 30, 0), EventTo = new DateTime(2017, 04, 04, 18, 20, 0), EnteredBy = "johnny", ActivityId = 6, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 6).CreationDate, IsActive = true},
                new Event {EventId= 7, EventFrom = new DateTime(2017, 05, 04, 9, 30, 0), EventTo = new DateTime(2017, 05, 04, 10, 20, 0), EnteredBy = "mary", ActivityId = 7, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 7).CreationDate, IsActive = false},
                new Event {EventId= 8, EventFrom = new DateTime(2017, 05, 04, 12, 30, 0), EventTo = new DateTime(2017, 05, 04, 13, 20, 0), EnteredBy = "mary", ActivityId = 8, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 8).CreationDate, IsActive = false},
                new Event {EventId= 9, EventFrom = new DateTime(2017, 05, 04, 14, 30, 0), EventTo = new DateTime(2017, 05, 04, 15, 50, 0), EnteredBy = "johnny", ActivityId = 9, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 9).CreationDate, IsActive = true},
                new Event {EventId= 10, EventFrom = new DateTime(2017, 05, 04, 16, 0, 0), EventTo = new DateTime(2017, 05, 04, 17, 20, 0), EnteredBy = "johnny", ActivityId = 10, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 10).CreationDate, IsActive = true},
                new Event {EventId= 11, EventFrom = new DateTime(2017, 06, 04, 8, 30, 0), EventTo = new DateTime(2017, 06, 04, 9, 20, 0), EnteredBy = "mary", ActivityId = 11, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 11).CreationDate, IsActive = false},
                new Event {EventId= 12, EventFrom = new DateTime(2017, 06, 04, 11, 30, 0), EventTo = new DateTime(2017, 06, 04, 13, 20, 0), EnteredBy = "johnny", ActivityId = 12, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 12).CreationDate, IsActive = true},
                new Event {EventId= 13, EventFrom =new DateTime(2017, 07, 04, 14, 30, 0), EventTo = new DateTime(2017, 07, 04, 16, 20, 0), EnteredBy = "mary", ActivityId = 13, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 13).CreationDate, IsActive = false},
                new Event {EventId= 14, EventFrom = new DateTime(2017, 08, 04, 8, 30, 0), EventTo = new DateTime(2017, 08, 04, 11, 20, 0), EnteredBy = "johnny", ActivityId = 14, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 14).CreationDate, IsActive = false},
                new Event {EventId= 15, EventFrom = new DateTime(2017, 08, 04, 13, 30, 0), EventTo =new DateTime(2017, 08, 04, 16, 20, 0), EnteredBy = "billy", ActivityId = 15, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 15).CreationDate, IsActive = true},

                new Event {EventId= 16, EventFrom = new DateTime(2017, 04, 03, 8, 30, 0), EventTo =new DateTime(2017, 04, 03, 10, 20, 0), EnteredBy = "billy", ActivityId = 16, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 16).CreationDate, IsActive = true},
                new Event {EventId= 17, EventFrom = new DateTime(2017, 04, 03, 13, 30, 0), EventTo =new DateTime(2017, 04, 03, 16, 20, 0), EnteredBy = "billy", ActivityId = 17, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 17).CreationDate, IsActive = true},
                new Event {EventId= 18, EventFrom = new DateTime(2017, 04, 04, 13, 30, 0), EventTo =new DateTime(2017, 04, 04, 15, 20, 0), EnteredBy = "billy", ActivityId = 18, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 18).CreationDate, IsActive = true},
                new Event {EventId= 19, EventFrom = new DateTime(2017, 04, 05, 8, 30, 0), EventTo =new DateTime(2017, 04, 05, 10, 20, 0), EnteredBy = "billy", ActivityId = 19, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 19).CreationDate, IsActive = true},
                new Event {EventId= 20, EventFrom = new DateTime(2017, 04, 05, 13, 30, 0), EventTo =new DateTime(2017, 04, 05, 16, 20, 0), EnteredBy = "billy", ActivityId = 20, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 20).CreationDate, IsActive = true},
                new Event {EventId= 21, EventFrom = new DateTime(2017, 04, 06, 12, 30, 0), EventTo =new DateTime(2017, 04, 06, 14, 20, 0), EnteredBy = "billy", ActivityId = 21, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 21).CreationDate, IsActive = true},
                new Event {EventId= 22, EventFrom = new DateTime(2017, 04, 06, 13, 30, 0), EventTo =new DateTime(2017, 04, 06, 16, 20, 0), EnteredBy = "billy", ActivityId = 22, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 22).CreationDate, IsActive = true},
                new Event {EventId= 23, EventFrom = new DateTime(2017, 04, 07, 13, 30, 0), EventTo =new DateTime(2017, 04, 07, 16, 20, 0), EnteredBy = "billy", ActivityId = 23, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 23).CreationDate, IsActive = true},
                new Event {EventId= 24, EventFrom = new DateTime(2017, 04, 08, 13, 30, 0), EventTo =new DateTime(2017, 04, 08, 16, 20, 0), EnteredBy = "billy", ActivityId = 24, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 24).CreationDate, IsActive = true},
                new Event {EventId= 25, EventFrom = new DateTime(2017, 04, 09, 13, 30, 0), EventTo =new DateTime(2017, 04, 09, 16, 20, 0), EnteredBy = "billy", ActivityId = 25, CreationDate = context.Activities.FirstOrDefault(a => a.ActivityId == 25 ).CreationDate, IsActive = true}

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
                new Activity {ActivityId = 15, Description = "Senior Volleyball Tournament", CreationDate = new DateTime(2017, 08, 04)},
               
                new Activity {ActivityId = 16, Description = "Youth Basketball Tournament", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 17, Description = "BBQ Lunch", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 18, Description = "Swimming Exercise for parents", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 19, Description = "Youth choir practice", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 20, Description = "Youth craft leassons", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 21, Description = "Fun in the sun", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 22, Description = "Garage Sale", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 23, Description = "Senior's Golf Tournament", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 24, Description = "Swimming Lessons for the youth", CreationDate = new DateTime(2017, 04, 01)},
                new Activity {ActivityId = 25, Description = "Senior Volleyball Tournament", CreationDate = new DateTime(2017, 04, 01)}
                
            };

            return activities.ToArray();
        }
    }
}