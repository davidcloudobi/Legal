using System;
using System.Collections.Generic;
using System.Text;
using LegalData.Model;

namespace LegalData.DIL
{
  public  class LawyersAct:ILawyersAct
    {
        private readonly ApplicationDbContext _db;
       
        public LawyersAct(ApplicationDbContext db)
        {
            _db = db;
        }
        public IAsyncEnumerable<Lawyer> GetAll()
        {
            return  _db.Lawyers;
        }

        public bool Register(Lawyer lawyer)
        {
            if (lawyer != null)
            {
                _db.Lawyers.Add(lawyer);
                _db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
