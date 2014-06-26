namespace User.CRUD.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Model = User.CRUD.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<User.CRUD.Infrastructure.UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(User.CRUD.Infrastructure.UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Users.AddOrUpdate(
                  p => p.Name,
                  new Model.User { Name = "Tim", Surname = "Robbins", Address = "795 E DRAGRAM TUCSON AZ 85705 USA", TelephoneNumber = "600123123" },
                  new Model.User { Name = "Morgan", Surname = "Freeman", Address = "421 E DRACHMAN TUCSON AZ 85705-7598 USA", TelephoneNumber = "+48 600234234" },
                  new Model.User { Name = "Bob", Surname = "Gunton", Address = "100 MAIN ST PO BOX 1022 SEATTLE WA 98104 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "William", Surname = "Sadler", Address = "300 BOYLSTON AVE E SEATTLE WA 98102 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Clancy", Surname = "Brown", Address = "100 MAIN ST PO BOX 1022 SEATTLE WA 98104 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Gil", Surname = "Bellows", Address = "421 E DRACHMAN TUCSON AZ 85705-7598 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Mark", Surname = "Rolston", Address = "795 E DRAGRAM TUCSON AZ 85705 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Tom", Surname = "Hanks", Address = "100 MAIN ST PO BOX 1022 SEATTLE WA 98104 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Robin", Surname = "Wright", Address = "300 BOYLSTON AVE E SEATTLE WA 98102 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Sally", Surname = "Field", Address = "795 E DRAGRAM TUCSON AZ 85705 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Andrew", Surname = "Peters", Address = "100 MAIN ST PO BOX 1022 SEATTLE WA 98104 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Brice", Surname = "Lambson", Address = "421 E DRACHMAN TUCSON AZ 85705-7598 USA", TelephoneNumber = "0044 765128334" },
                  new Model.User { Name = "Rowan", Surname = "Miller", Address = "300 BOYLSTON AVE E SEATTLE WA 98102 USA", TelephoneNumber = "0044 765128334" }
                );
            
        }
    }
}
