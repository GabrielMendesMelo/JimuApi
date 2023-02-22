using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Alimento;

namespace Api.Service.Services
{
    public class AlimentoService : IAlimentoService
    {
        private IRepository<AlimentoEntity> _repository;

        public AlimentoService(IRepository<AlimentoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<AlimentoEntity?> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<AlimentoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<AlimentoEntity> Post(AlimentoEntity alimento)
        {
            return await _repository.InsertAsync(alimento);
        }

        public async Task<AlimentoEntity?> Put(AlimentoEntity alimento)
        {
            return await _repository.UpdateAsync(alimento);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
