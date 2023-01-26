using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Assignment.Data;
using DDAC_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace DDAC_Assignment.Controllers
{
    public class ProductsController : Controller
    {
        //Create variable to link to db
        private readonly DDAC_AssignmentContext _context;

        //Constructor to initialize the db connection
        public ProductsController(DDAC_AssignmentContext context)
        {
            _context = context;
        }

        //Set S3 bucket name
        private const string bucketname = "ddacassignment";

        //Function: Create connection to AWS Account
        private List<string> getAWSInformation()
        {
            List<string> keys = new List<string>();

            //Collecting keys from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();

            keys.Add(configuration["AWSCredentials:accessKey"]);
            keys.Add(configuration["AWSCredentials:secretKey"]);
            keys.Add(configuration["AWSCredentials:tokenKey"]);

            return keys;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {

            var productlist = await _context.Product.ToListAsync();
            return View(productlist);
        }

        //Funtion: Load insert page
        [Authorize(Roles = "Admin")]
        public IActionResult AddProduct()
        {
            return View();
        }

        //Function: Process the insert data info
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> processInsert(Product product, IFormFile imagefile)
        {
            try
            {
                List<string> keys = getAWSInformation();
                AmazonS3Client S3objectClient = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

                //Upload to S3
                PutObjectRequest request = new PutObjectRequest
                {
                    InputStream = imagefile.OpenReadStream(),
                    BucketName = bucketname + "/images", //Images is a folder in the bucket
                    Key = imagefile.FileName,
                    CannedACL = S3CannedACL.PublicRead //If dont have this sentence, it will become private object in the s3
                };
                await S3objectClient.PutObjectAsync(request);
            }
            catch(AmazonS3Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
            product.ProductURL = "https://" + bucketname + ".s3.amazonaws.com/images/" + imagefile.FileName;
            product.ProductS3Key = imagefile.FileName;
            product.ProductRating = 0;

            //Add product to database
            _context.Product.Add(product); 
            await _context.SaveChangesAsync(); 
            return RedirectToAction("Index", "Products");
        }


        public async Task<IActionResult> deleteAction(int ProductID)
        {
            if(ProductID == null)
            {
                return NotFound();
            }

            try
            {
                var product = await _context.Product.FindAsync(ProductID);
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Products",
                    new { msg = "Product of ID " + ProductID + " is deleted from the table now!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
