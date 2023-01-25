using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Authorization;

namespace ddac.Controllers
{
    public class SNSController : Controller
    {
        private const string topicARN = "arn:aws:sns:us-east-1:197544957557:Newsletter";

        //create connection
        private List<string> getAWSInformation()
        {
            List<string> keys = new List<string>();

            //collecting all keys from the appsettings.json file
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();

            keys.Add(configuration["AWSCredentials:accessKey"]);
            keys.Add(configuration["AWSCredentials:secretKey"]);
            keys.Add(configuration["AWSCredentials:tokenKey"]);

            return keys;
        }

        //create the client object for every single action
        private AmazonSimpleNotificationServiceClient createClient()
        {
            List<string> keys = getAWSInformation();
            AmazonSimpleNotificationServiceClient SNSobjectClient = new AmazonSimpleNotificationServiceClient(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);
            return SNSobjectClient;
        }

        //create subscriber page through index page
        [Authorize(Roles = "Customer")]
        public IActionResult Index(string ? msg)
        {
            ViewBag.msg = msg;
            return View();
        }

        //subscribe to topic
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> processSNSSubscription(string emailAddress)
        {
            string message = "You have subscribed to the newsletter! Please confirm your subscription through email.";

            AmazonSimpleNotificationServiceClient clientObject = createClient();

            try
            {
                SubscribeRequest request = new SubscribeRequest
                {
                    TopicArn = topicARN,
                    Protocol = "email",
                    Endpoint = emailAddress
                };
                SubscribeResponse response = await clientObject.SubscribeAsync(request);
                message = message + "\nYour subscription id is " + response.ResponseMetadata.RequestId;

            } catch(AmazonSimpleNotificationServiceException ex) 
            {
                message = "Error Message: " + ex.Message;
            }
            
            return RedirectToAction("Index", "SNS", new { msg = message });
        }

        //admin broadcast msg to users
        [Authorize(Roles = "Admin")]
        public IActionResult broadcastMessagePage(string? msg)
        {
            ViewBag.msg = msg;
            return View();
        }

        //process the broadcast msg
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> processBroadcastMessage(string subjectTitle, string messageBodyText)
        {
            string message = "Newsletter has been sent out!";
            AmazonSimpleNotificationServiceClient snsClientObject = createClient();

            try
            {
                //create request
                PublishRequest request = new PublishRequest
                {
                    TopicArn = topicARN,
                    Message = messageBodyText,
                    Subject = subjectTitle,
                };
                PublishResponse response = await snsClientObject.PublishAsync(request);
            }
            catch (AmazonSimpleNotificationServiceException ex)
            {
                message = "Error message: " + ex.Message;
            }
            catch (Exception ex)
            {
                message = "Error message: " + ex.Message;
            }
            return RedirectToAction("broadcastMessagePage", "SNS", new { msg = message });
        }
    }

}

