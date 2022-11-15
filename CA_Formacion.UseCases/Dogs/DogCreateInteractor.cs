
using CA_Formacion.DomainAbstractions;
using CA_Formacion.DTOs.Breeds;
using CA_Formacion.DTOs.Dogs;
using CA_Formacion.Entities.Interfaces.Dogs;
using CA_Formacion.Entities.POCO;
using CA_Formacion.UseCasesPorts.Dogs;

namespace CA_Formacion.UseCases.Dogs
{
    public class DogCreateInteractor : IDogCreateInputPort
    {
        private readonly IMutationDogsRepository _repository;
        private readonly IDogCreateOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;

        public DogCreateInteractor(
            IMutationDogsRepository repository,
            IDogCreateOutputPort outputPort,
            IUnitOfWork unitOfWork) =>
            (_repository, _outputPort, _unitOfWork) = (repository, outputPort, unitOfWork);

        public Task Handle(CreateDogDTO dogDto)
        {
            Dog dog = MapDog(dogDto);
            Dog dogCreated = _repository.Create(dog);
            _unitOfWork.SaveChanges();
            DogDTO dogOutput = MapDogDTO(dogCreated);
            _outputPort.Handle(dogOutput);
            return Task.CompletedTask;
        }

        private DogDTO MapDogDTO(Dog dogCreated)
        {
            return new DogDTO()
            {
                Id = dogCreated.Id,
                Name = dogCreated.Name,
                //Breed = new BreedDTO(dogCreated.Breed)
            };
        }

        private Dog MapDog(CreateDogDTO dogDto)
        {
            return new Dog()
            {
                Name = dogDto.Name,
                BreedId = dogDto.BreedId,
            };
        }
    }
}
