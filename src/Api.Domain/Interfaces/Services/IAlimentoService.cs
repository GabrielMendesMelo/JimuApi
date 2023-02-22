using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Alimento
{
    public interface IAlimentoService
    {
        Task<AlimentoEntity?> Get(Guid id);
        Task<IEnumerable<AlimentoEntity>> GetAll();
        Task<AlimentoEntity> Post(AlimentoEntity alimento);
        Task<AlimentoEntity?> Put(AlimentoEntity alimento);
        Task<bool> Delete(Guid id);
    }
}
