using Sistem.Domain.Impl.Entities;
using Sistem.Domain.Impl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Impl.Services
{
    // classe de serviço de dominio para entidade RegisterClient
    public class ClientDomainService : IClientDomainService
    {
       private readonly IUnitOfWork _unitOfWork;

        public ClientDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(RegisterClient entity)
        {
            if (_unitOfWork.ClientRepository.GetByEmail(entity.Email) != null)
                throw new ArgumentException("O email informado ja existe");

            if (_unitOfWork.ClientRepository.GetByUser(entity.User) != null)
                throw new ArgumentException("Usuario ja existe");
            
            await _unitOfWork.ClientRepository.CreateAsync(entity);
        }

        public async Task UpdateAsync(RegisterClient entity)
        {
            if (await _unitOfWork.ClientRepository.GetByIdAsync(entity.Id) == null)
                throw new ArgumentException("Usuario nao encontrado");

            var clienteByEmail = _unitOfWork.ClientRepository.GetByEmail(entity.Email);
            if(clienteByEmail != null && clienteByEmail.Id.Equals( entity.Id))
                throw new ArgumentException("Email nao encontrado");

        }

        public async Task DeleteAsync(RegisterClient entity)
        {
            if (await _unitOfWork.ClientRepository.GetByIdAsync(entity.Id) == null)
                throw new ArgumentException("Usuario nao encontrado");

           await _unitOfWork.ClientRepository.DeleteAsync(entity);
        }

        public async Task<List<RegisterClient>> GetAllAsync(int page, int limit)
        {
            if (limit > 250)
                throw new ArgumentException("Limite maximo 250");

            return await _unitOfWork.ClientRepository.GetAllAsync(page, limit);
        }

        public async Task<RegisterClient> GetByIdAsync(Guid id)
            => await _unitOfWork.ClientRepository.GetByIdAsync(id);

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
