
using CA_Formacion.DTOs.Breeds;
using CA_Formacion.Presenters.Abstractions;
using CA_Formacion.UseCasesPorts.Breeds;
using Microsoft.AspNetCore.Mvc;

namespace CA_Formacion.Controllers.Breeds
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreedCreateController
    {
        private readonly IBreedCreateInputPort _inputPort;
        private readonly IBreedCreateOutputPort _outputPort;

        public BreedCreateController(
            IBreedCreateInputPort inputPort,
            IBreedCreateOutputPort outputPort
        ) => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<BreedDTO> CreateBreed(BreedCreateDTO createBreedDTO)
        {
            await _inputPort.Handle(createBreedDTO);
            return ((IPresenter<BreedDTO>)_outputPort).Content;
        }
    }
}
