using AzureUppgift_2016_11_23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace AzureUppgift_2016_11_23.Controllers
{
    public class HomeController : Controller
    {


        private CloudStorageAccount storageAccount;
        private CloudTableClient tableClient;
        private CloudTable table;

        public HomeController()
        {
            storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=http;AccountName=sebbstorage;AccountKey=X6psta3fD7F93R/LMnYClB5E3N8gavdOByzdlrGqpg/xlQjFfQCoXqrJ9+0tuoHkbk24eqIm8ZshHzNuDUiFIQ==;");
            tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference("LocalTable");
            table.CreateIfNotExists();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVP(GuestResponse g)
        {
            if (ModelState.IsValid == true)
            {
                GuestResponse person = new GuestResponse(Guid.NewGuid().ToString()) { Name = g.Name, Telephone = g.Telephone, Adress = g.Adress };

                TableOperation insertOperation = TableOperation.Insert(person);

                table.Execute(insertOperation);
                return View("Thanks", g);
            }
            return View();
        }

        [HttpGet]
        public ActionResult info()
        {
            return View(PrintInformation());
        }

        [NonAction]
        public List<GuestResponse> PrintInformation()
        {
            List<GuestResponse> PeopleInformation = new List<GuestResponse>();
       
            // Construct the query operation for all customer entities where PartitionKey="Smith".
            TableQuery<GuestResponse> query = new TableQuery<GuestResponse>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "KoraBil"));


            foreach (GuestResponse item in table.ExecuteQuery(query))
	        {
                PeopleInformation.Add(item);
	        }


            return PeopleInformation;
            
        }

    }
}