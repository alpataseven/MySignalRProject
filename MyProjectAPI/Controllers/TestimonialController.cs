using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.SocialMediaDto;
using DtoLayer.TestimonialDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                TestimonialComment = createTestimonialDto.TestimonialComment,
                TestimonialImageUrl = createTestimonialDto.TestimonialImageUrl,
                TestimonialName = createTestimonialDto.TestimonialName,
                TestimonialStatus = createTestimonialDto.TestimonialStatus,
                TestimonialTitle = createTestimonialDto.TestimonialTitle
            });
            return Ok("müşteri yorum bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("müşteri yorum bilgisi silindi");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialId = updateTestimonialDto.TestimonialId,
                TestimonialComment = updateTestimonialDto.TestimonialComment,
                TestimonialName = updateTestimonialDto.TestimonialName,
                TestimonialTitle = updateTestimonialDto.TestimonialTitle,
                TestimonialImageUrl = updateTestimonialDto.TestimonialImageUrl,
                TestimonialStatus = updateTestimonialDto.TestimonialStatus
            });
            return Ok("sosyal medya bilgisi güncellendi");
        }
    }
}
