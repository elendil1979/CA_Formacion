using CA_Formacion.DTOs.Breeds;
using CA_Formacion.Entities.Interfaces;
using CA_Formacion.Entities.POCO;
using CA_Formacion.UseCasesPorts.Breeds;

namespace CA_Formacion.UseCases.Breeds
{
    public class CreateBreedInteractor : IBreedCreateInputPort
    {

        private IBreedRepository _repository;
        private IBreedCreateOutputPort _outputPort;

        public CreateBreedInteractor(
            IBreedCreateOutputPort outputPort,
            IBreedRepository repository) => (_outputPort, _repository) = (outputPort, repository);


        public Task Handle(CreateBreedDTO data)
        {
            Breed breed = MapBreed(data);
            Breed breedCreated = _repository.Create(breed);
            BreedDTO breedDTO = new BreedDTO(breedCreated);
            _outputPort.Handle(breedDTO);
            return Task.CompletedTask;
        }
        
        private Breed MapBreed(CreateBreedDTO data)
        {
            return new Breed()
            {
                Name = data.Name,
                MaxAge = data.MaxAge
            };
        }
    }
}
