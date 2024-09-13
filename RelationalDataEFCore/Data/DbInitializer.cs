using RelationalDataEFCore.Models;

namespace RelationalDataEFCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(JournalEnvDbContext context)
        {
            if (context.Journals.Any())
            {
                return;   // Journal has been seeded
            }

            // Implement Journal Seeding
            context.SaveChanges();
        }
    }
}
