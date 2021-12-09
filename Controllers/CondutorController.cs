using System.Threading.Tasks;
using AutoMapper;
using DetranApp.Data.Interfaces;
using DetranApp.DTO;
using DetranApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DetranApp.Controllers
{
    public class CondutorController : BaseApiController
    {
        private readonly ICondutorRepository _condutorRepository;
        private readonly IMapper _mapper;

        public CondutorController(ICondutorRepository condutorRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._condutorRepository = condutorRepository;
        }

        #region CRUD

        [HttpPost]
        public async Task<ActionResult<CondutorReturnDto>> Create(CondutorRegisterDto condutorRegisterDto)
        {
            _condutorRepository.Create<Condutor>(_mapper.Map<Condutor>(condutorRegisterDto));

            var condutor = await _condutorRepository.SaveAllAsynsc();

            return _mapper.Map<CondutorReturnDto>(condutor);
        }

        #endregion
    }
}