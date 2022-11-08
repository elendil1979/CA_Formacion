
using CA_Formacion.DTOs.Dogs;
using CA_Formacion.Presenters.Abstractions;
using CA_Formacion.UseCasesPorts.Dogs;
using Microsoft.AspNetCore.Mvc;

namespace CA_Formacion.Controllers.Dogs
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogCreateController
    {
        private readonly IDogCreateInputPort _inputPort;
        private readonly IDogCreateOutputPort _outputPort;

        public DogCreateController(
            IDogCreateInputPort inputPort,
            IDogCreateOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<DogDTO> CreateDog(CreateDogDTO data)
        {
            await _inputPort.Handle(data);
            return ((IPresenter<DogDTO>)_outputPort).Content;
        }
    }
}
