using BidOneTask.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BidOneTask.Helper
{
    public class FileHelper
    {
        //private readonly IWebHostEnvironment _webHostEnvironment;
        public bool Create(PersonViewModel person, IWebHostEnvironment webHostEnvironment)
        {
            bool retVal = true;

            try
            {
                JObject obj = (JObject)JToken.FromObject(person);

                string folderPath = Path.Combine(webHostEnvironment.WebRootPath,"Output");
                var fileName = Guid.NewGuid().ToString() + ".json";
                string filePath = Path.Combine(folderPath,fileName);
                File.WriteAllText(filePath, obj.ToString());

                return retVal;
            }
            catch (Exception ex)
            {

                return retVal;
            }          
           
        }
    }
}
