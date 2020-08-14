using TecBan.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace TecBan.Domain.Interface
{
    public interface IAtmRepository
    {
        Task<IEnumerable<ATM>> GetAtm();
        Task<ATM> InsertAtm(ATM Atm);
        Task<ATM> UpdateAtm(ATM Atm);
        Task<bool> DeleteAtm(int id);
    }
}
