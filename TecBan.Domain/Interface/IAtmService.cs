using System.Collections.Generic;
using System.Threading.Tasks;
using TecBan.Domain.Entities;
namespace TecBan.Domain.Interface
{
    public interface IAtmService
    {
        Task<IEnumerable<ATM>> GetAtm();
        Task<ATM> InsertAtm(ATM Atm);
        Task<ATM> UpdateAtm(ATM Atm);
        Task<bool> DeleteAtm(int id);
    }
}
