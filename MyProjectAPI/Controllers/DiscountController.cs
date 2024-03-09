using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.CategoryDto;
using DtoLayer.DiscountDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                DiscountAmount = createDiscountDto.DiscountAmount,
                DiscountDescription = createDiscountDto.DiscountDescription,
                DiscountImageUrl = createDiscountDto.DiscountImageUrl,
                DiscountTitle = createDiscountDto.DiscountTitle
            });
            return Ok("İndirim bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim bilgisi silindi");
        }
        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                DiscountAmount = updateDiscountDto.DiscountAmount,
                DiscountDescription = updateDiscountDto.DiscountDescription,
                DiscountId = updateDiscountDto.DiscountId,
                DiscountImageUrl = updateDiscountDto.DiscountImageUrl,
                DiscountTitle = updateDiscountDto.DiscountTitle
            });
            return Ok("İndirim bilgisi güncellendi");
        }
    }
}
