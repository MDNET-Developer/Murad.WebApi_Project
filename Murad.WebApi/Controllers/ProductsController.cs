using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Murad.WebApi.Data;
using Murad.WebApi.Repositories;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Murad.WebApi.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var result = await _productRepository.GetAllAsync();
        //    return Ok(result);
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllV2([FromServices]IProductRepository productRepository)
        {
            var result = await productRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound($"ID-si {id} olan verilən tapılmadı");
            }
          
        }
        [HttpGet("getid/{id}")]
        public async Task<IActionResult> GetByIdV2(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound($"ID-si {id} olan verilən tapılmadı");
            }

        }
        //[HttpPost]
        //public async Task<IActionResult> Create(Product product)
        //{
        //    var createdData = await _productRepository.CreateAsync(product);
        //    return Created(string.Empty, createdData);
        //}
        //Default halo [FromBody]-dir

        [HttpPost]
        public async Task<IActionResult> CreateV2([FromQuery]Product product)
        {
            var createdData = await _productRepository.CreateAsync(product);
            return Created(string.Empty, createdData);
        }



        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            var dataid = await _productRepository.GetByIdAsync(product.Id);
            await _productRepository.UpdateAsync(product);
            return Ok($"ID={product.Id} olan data uğurla yeniləndi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _productRepository.Remove(id);
            return Ok($"{id}-ci ID olan data uğurla silindi");
        }


        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile formFile)
        {
            var newName = Guid.NewGuid() + "." + Path.GetExtension(formFile.FileName); 
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", newName); 
            var stream = new FileStream(path, FileMode.Create); 
            await formFile.CopyToAsync(stream); 
            return Created("File uğurla yükləndi", formFile);
        }
    }
}
