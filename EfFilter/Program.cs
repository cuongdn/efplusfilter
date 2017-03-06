using System;
using System.Linq;
using Core.DataAccess.Repositories;
using DataAccess;
using DataAccess.Entities;

namespace EfFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EfContext())
            {
                var repo = new ReadOnlyRepository<Tenant>(context);
                var entity = repo
                        .AsNoFilter()
                        .SingleOrDefault(x => x.Id == 1);
                Console.WriteLine(entity?.Name);
            }
        }
    }
}
