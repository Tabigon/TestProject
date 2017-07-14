using System.Collections.Generic;
using System.Data.Entity;
using TestProject.Domain;

namespace TestProject.DAL
{
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            var d1 = new Record { Id = 1,UserName = "Elk", UserRecord = "Some interesting text" };
            var d2 = new Record { Id = 2, UserName = "Elk # 2", UserRecord = "Some more interesting text then the first one" };

            context.Records.AddRange(new List<Record> { d1, d2});
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
