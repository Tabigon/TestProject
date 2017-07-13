using System;
using TestProject.BL.DTO;
using TestProject.BL.Interfaces;
using TestProject.DAL.Interfaces;
using TestProject.Domain;

namespace TestProject.BL.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;

        public RecordService(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public void AddRecord(RecordDTO recordDTO)
        {
            if (recordDTO == null)
                throw new ArgumentNullException();

            var record = new Record
            {
                UserName = recordDTO.UserName,
                UserRecord = recordDTO.UserRecord
            };

            _recordRepository.AddRecord(record);
        }
    }
}
