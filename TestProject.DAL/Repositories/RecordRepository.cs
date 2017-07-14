using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.Interfaces;
using TestProject.Domain;

namespace TestProject.DAL.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly AppContext _context;

        public RecordRepository(AppContext context)
        {
            _context = context;
        }

        public void AddRecord(Record record)
        {
            if (record != null)
            {
                _context.Records.Add(record);
                _context.SaveChanges();
            }
            else
                throw new ArgumentNullException();
        }
    }
}
