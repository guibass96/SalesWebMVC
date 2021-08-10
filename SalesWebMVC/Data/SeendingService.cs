using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
namespace SalesWebMVC.Data
{
    public class SeendingService
    {
        private SalesWebMVCContext _context;

        public SeendingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Departament d1 = new Departament(1, "computer");
            Departament d2 = new Departament(2, "Eletronic");

            Seller s1 = new Seller(1,"Guilherme Rodrigues","gui@gmail.com", new DateTime(1998,4,21),"1000",d1);

            SalesRecord r1 = new SalesRecord(1,new DateTime(1998, 4, 21),111,Models.Enums.SalesStatus.Billed,s1);

            _context.Departament.AddRange(d1, d2);
            _context.Seller.AddRange(s1);
            _context.SalesRecord.AddRange(r1);

            _context.SaveChanges();
        }
    }
}
