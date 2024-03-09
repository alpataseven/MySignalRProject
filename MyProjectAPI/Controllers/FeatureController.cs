using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.FeatureDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                FirstDescription = createFeatureDto.FirstDescription,
                SecondDescription = createFeatureDto.SecondDescription,
                ThirdDescription = createFeatureDto.ThirdDescription,
                FirstTitle = createFeatureDto.FirstTitle,
                SecondTitle = createFeatureDto.SecondTitle,
                ThirdTitle = createFeatureDto.ThirdTitle
            });
            return Ok("öne çıkan bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("öne çıkan bilgisi silindi");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                FeatureId = updateFeatureDto.FeatureId,
                FirstDescription = updateFeatureDto.FirstDescription,
                SecondDescription = updateFeatureDto.SecondDescription,
                ThirdDescription = updateFeatureDto.ThirdDescription,
                FirstTitle = updateFeatureDto.FirstTitle,
                SecondTitle = updateFeatureDto.SecondTitle,
                ThirdTitle = updateFeatureDto.ThirdTitle
            });
            return Ok("öne çıkan bilgisi güncellendi");
        }
    }
}
