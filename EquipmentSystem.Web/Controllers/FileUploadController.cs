using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace EquipmentSystem.Web.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> UploadImage()
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileexe = Path.GetExtension(file.FileName);
                    var fileName = Guid.NewGuid().ToString("N") + fileexe;
                    var path = Path.Combine("images", fileName);
                    file.SaveAs(path);
                    return Json(new { Status = 200, Message = "Success", Data = new { FileName = fileName } });
                }
            }
            return Json(new { Status = 400, Message = "Error", Data = new { FileName = "" } });
        }


    }
}