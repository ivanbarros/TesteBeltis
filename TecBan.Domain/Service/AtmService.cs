using System.Collections.Generic;
using System.Threading.Tasks;
using TecBan.Domain.Entities;
using TecBan.Domain.Interface;
using System;

namespace TecBan.Domain.Service
{
    public class AtmService : IAtmService
    {
        private readonly IAtmRepository _atmRepository;

        public AtmService(IAtmRepository atmRepository)
        {
            _atmRepository = atmRepository;
        }
        public async Task<bool> DeleteAtm(int id)
        {
            try
            {
                return await _atmRepository.DeleteAtm(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ATM>> GetAtm()
        {
            try
            {
                return await _atmRepository.GetAtm();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ATM> InsertAtm(ATM Atm)
        {
            try
            {
                return await _atmRepository.InsertAtm(Atm);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<ATM> UpdateAtm(ATM Atm)
        {
            try
            {
                return await _atmRepository.UpdateAtm(Atm);
            }
            catch (Exception)
            {

                throw;
            };
        }
    }
}
