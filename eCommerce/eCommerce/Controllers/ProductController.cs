using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using eCommerce.Interfaces;
using eCommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace eCommerce.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        readonly IWebHostEnvironment _hostingEnvironment;
        readonly IProductService _productService;
        readonly IConfiguration _config;
        readonly string coverImageFolderPath = string.Empty;

        public ProductController(IConfiguration config, IWebHostEnvironment hostingEnvironment, IProductService productService)
        {
            _config = config;
            _productService = productService;
            _hostingEnvironment = hostingEnvironment;
            coverImageFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, "Upload");
            if (!Directory.Exists(coverImageFolderPath))
            {
                Directory.CreateDirectory(coverImageFolderPath);
            }
        }

        /// <summary>
        /// Get the list of available products
        /// </summary>
        /// <returns>List of Products</returns>
        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await Task.FromResult(_productService.GetAllProducts()).ConfigureAwait(true) ;
        }

        /// <summary>
        /// Get the specific product data corresponding to the ProductId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product = _productService.GetProductData(id);
            if(product!=null)
            {
                return Ok(product);
            }
            return NotFound();
        }

        /// <summary>
        /// Get the list of available categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCategoriesList")]
        public async Task<IEnumerable<Categories>> CategoryDetails()
        {
            return await Task.FromResult(_productService.GetCategories()).ConfigureAwait(true) ;
        }



        /// <summary>
        /// Add a new productrecord
        /// </summary>
        /// <returns></returns>
        [HttpPost, DisableRequestSizeLimit]
        [Authorize(Policy = UserRoles.Admin)]
        public async Task<IActionResult> AddProdct([FromBody] Product model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var postId = await _productService.AddProduct(model);
                    if (postId > 0)
                    {
                        return Ok(postId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        // <summary>
        // Update a particular product record
        // </summary>
        // <returns></returns>
        [HttpPut]
        [Authorize(Policy = UserRoles.Admin)]
        public async Task<IActionResult> UpdateProduct([FromBody] Product model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _productService.UpdateProduct(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName ==
                             "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }

        /// <summary>
        /// Delete a particular product record
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("{productId}")]
        [Authorize(Policy = UserRoles.Admin)]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            int result = 0;

           /* if (productId == null)
            {
                return BadRequest();
            }*/

            try
            {
                result = await _productService.DeleteProduct(productId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

    }
}
