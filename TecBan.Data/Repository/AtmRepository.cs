using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TecBan.Domain.Entities;
using TecBan.Domain.Interface;

namespace TecBan.Data.Repository
{
    public class AtmRepository : IAtmRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCache _memoryCache;
       
        public AtmRepository(IUnitOfWork unitOfWorK, IMemoryCache memoryCache)
        {

            _unitOfWork = unitOfWorK;
             _memoryCache = memoryCache;
        }
        public async Task<bool> DeleteAtm(int id)
        {
            try
            {
                var query = $@"DELETE FROM [dbo].[ATM]
      WHERE Id = @id";
                var param = new { id };
                await _unitOfWork.BaseRepository().Delete(query, param: param);
                return true;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<ATM>> GetAtm()
        {
            try
            {
                var query = $@"SELECT [Id]
      ,[atmDTCadastro]
      ,[atmNome]
      ,[atmPA]
      ,[atmPC]
      ,[atmEndereco]
      ,[atmComplemento]
      ,[atmBairro]
      ,[atmCidade]
      ,[atmUF]
      ,[atmCep]
      ,[atmPontoRef]
      ,[atmLongitude]
      ,[atmLatitude]
  FROM [dbo].[ATM]";
                return await _unitOfWork.BaseRepository().FindByQuery<ATM>(query);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ATM> InsertAtm(ATM Atm)
        {
            var query = $@"INSERT INTO [dbo].[ATM]
           ([atmDTCadastro]
           ,[atmNome]
           ,[atmPA]
           ,[atmPC]
           ,[atmEndereco]
           ,[atmComplemento]
           ,[atmBairro]
           ,[atmCidade]
           ,[atmUF]
           ,[atmCep]
           ,[atmPontoRef]
           ,[atmLongitude]
           ,[atmLatitude])
		   OUTPUT inserted.*
     VALUES
           (@atmDTCadastro
           ,@atmNome
           ,@atmPA
           ,@atmPC
           ,@atmEndereco
           ,@atmComplemento
           ,@atmBairro
           ,@atmCidade
           ,@atmUF
           ,@atmCep
           ,@atmPontoRef
           ,@atmLongitude
           ,@atmLatitude)";

            return await _unitOfWork.BaseRepository().InsertIdentityTable<ATM>(query, Atm);
        }

        public async Task<ATM> UpdateAtm(ATM Atm)
        {
            try
            {
                var query = $@"UPDATE [dbo].[ATM]
   SET [atmDTCadastro] = @atmDTCadastro
      ,[atmNome] = @atmNome
      ,[atmPA] = @atmPA
      ,[atmPC] = @atmPC
      ,[atmEndereco] = @atmEndereco
      ,[atmComplemento] = @atmComplemento
      ,[atmBairro] = @atmBairro
      ,[atmCidade] = @atmCidade
      ,[atmUF] = @atmUF
      ,[atmCep] = @atmCep
      ,[atmPontoRef] = @atmPontoRef
      ,[atmLongitude] = @atmLongitude
      ,[atmLatitude] = @atmLatitude
 WHERE Id = @Id";

                await _unitOfWork.BaseRepository().Update(query, param: null);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Atm;
        }
    }
    }

