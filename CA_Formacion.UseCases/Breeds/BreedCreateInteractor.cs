using CA_Formacion.DomainAbstractions;
using CA_Formacion.DTOs.Breeds;
using CA_Formacion.Entities.Interfaces;
using CA_Formacion.Entities.POCO;
using CA_Formacion.UseCasesPorts.Breeds;

namespace CA_Formacion.UseCases.Breeds
{
    public class BreedCreateInteractor : IBreedCreateInputPort
    {

        private readonly IBreedRepository _repository;
        private readonly IBreedCreateOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;

        public BreedCreateInteractor(
            IBreedCreateOutputPort outputPort,
            IBreedRepository repository,
            IUnitOfWork unitOfWork) => 
            (_outputPort, _repository, _unitOfWork) = (outputPort, repository, unitOfWork);


        public Task Handle(BreedCreateDTO data)
        {
            Breed breed = MapBreed(data);
            Breed breedCreated = _repository.Create(breed);
            _unitOfWork.SaveChanges();
            BreedDTO breedDTO = new BreedDTO(breedCreated);
            _outputPort.Handle(breedDTO);
            return Task.CompletedTask;
        }
        
        private Breed MapBreed(BreedCreateDTO data)
        {
            return new Breed()
            {
                Name = data.Name,
                MaxAge = data.MaxAge
            };
        }
    }
}
