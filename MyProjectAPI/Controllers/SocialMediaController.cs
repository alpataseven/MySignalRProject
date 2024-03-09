using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.SocialMediaDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                SocialMediaIcon = createSocialMediaDto.SocialMediaIcon,
                SocialMediaTitle = createSocialMediaDto.SocialMediaTitle,
                SocialMediaUrl = createSocialMediaDto.SocialMediaUrl
            });
            return Ok("sosyal medya bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(value);
            return Ok("sosyal medya bilgisi silindi");
        }
        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                SocialMediaId = updateSocialMediaDto.SocialMediaId,
                SocialMediaIcon = updateSocialMediaDto.SocialMediaIcon,
                SocialMediaTitle = updateSocialMediaDto.SocialMediaTitle,
                SocialMediaUrl = updateSocialMediaDto.SocialMediaUrl
            });
            return Ok("sosyal medya bilgisi güncellendi");
        }
    }
}
