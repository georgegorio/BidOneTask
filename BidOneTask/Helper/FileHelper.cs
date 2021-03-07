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
        public string Create(PersonViewModel person, IWebHostEnvironment webHostEnvironment)
        {
            string retVal = "";

            try
            {
                JObject obj = (JObject)JToken.FromObject(person);

                // folder path is in wwwroot/output folder
                string folderPath = Path.Combine(webHostEnvironment.WebRootPath,"Output");

                // file name is a GUID.json
                var fileName = Guid.NewGuid().ToString() + ".json";
                string filePath = Path.Combine(folderPath,fileName);                
           
                File.WriteAllText(filePath, obj.ToString());

                return retVal;
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }          
           
        }
    }
}
