using LearnedTry.Data;
using LearnedTry.Models;
using System.Diagnostics.Metrics;

namespace LearnedTry

{
    public class Seed
    {
            private readonly DataContext dataContext;
                public Seed(DataContext context)
                {
                    this.dataContext = context;
                }
                public void SeedDataContext()
                 {
                     dataContext.SaveChanges();
                 }

     }
}
