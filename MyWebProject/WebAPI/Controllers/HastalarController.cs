using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]// bu attrıbutedeir yani bir class hakkında bilgi verir burada demişki bu class bir kontrollerdır 

    

    public class HastalarController : ControllerBase
    {
        IHastaService _hastaService;
        public HastalarController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }

        [HttpGet("getall")]
        public List<Hasta> Get()
        {
            
            var result = _hastaService.GetAll();
            return result.Data;
        }
        

        [HttpGet("getbyhastaadı")]
        public IActionResult GetByHastaAdı(string ad)
        {

            var result = _hastaService.GetByHastaAdı(ad);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        //postmande çalıştırıken api/hastalar/getbyhastasurname?soyad=aramak istediğin soyadı yaz bu şekilde çalışır 

        [HttpGet("getbyhastasoyadı")]
        public IActionResult GetByHastaSoyadı(string soyad)
        {

            var result = _hastaService.GetByHastaSoyadı(soyad);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        

        [HttpGet("hastatc")]
        public IActionResult GetByHastaTC(string TC)
        {

            var result = _hastaService.GetByHastaTC(TC);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        //gette hasta getiriuprduk postta hasta ekliyoruz
        //Yani burada databaseye veri eklemiş oluyoruz
        //güncelleme ve silme işlemi içinde bunu kullanabiliriz aynı kullanım
        [HttpPost("add")]
        public IActionResult Add(Hasta hasta)
        {//hasta ekleem işlemi
            var result = _hastaService.Add(hasta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
