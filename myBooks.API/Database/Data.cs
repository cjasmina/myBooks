using Microsoft.EntityFrameworkCore;

namespace myBooks.API.Database
{
    public class Data
    {
        public static void Seed(myBooksContext context)
        {
            context.Database.Migrate();
        }
    }
}
