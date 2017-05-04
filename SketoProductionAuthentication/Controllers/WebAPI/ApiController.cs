using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Services;
using Microsoft.AspNetCore.Mvc;
using SketoProductionAuthentication.Data;
using SketoProductionAuthentication.Models;

namespace SketoProductionAuthentication.Controllers.WebAPI
{
    public class ApiController : Controller
    {
        private readonly MasterContext _db = new MasterContext();



        //[WebMethod]
       // public JsonResult GetUserJobs(int userId)
        public JsonResult GetUserJobs()
        {
            //SPECIALTY HAS BEEN FOUND
            var result = _db.UserJobs
                .Where(x => x.UserId == 1)
                .Select(p => new
                {
                    p.JobId
                })
                .ToList().Join(
                    _db.JobsApplied,
                    spec => new { spec.JobId},//make sure that its named the same
                    prog => new { JobId = prog.Id },
                    (spec, prog) => new
                    {
                        prog.Id,
                        prog.Company,
                        prog.DateApplied,
                        prog.Interview,
                        prog.Position
                    })
                .OrderByDescending(q => q.Company)
                .AsEnumerable()
                .GroupBy(x => x.Id)
                .Select(x => new JobsApplied
                {
                    Company = x.Select(a => a.Company).FirstOrDefault(),
                    DateApplied = x.Select(a => a.DateApplied).FirstOrDefault(),
                    Interview = x.Select(a => a.Interview).FirstOrDefault(),
                    Position = x.Select(a => a.Position).FirstOrDefault()
                }).ToList();


            return Json(result);
        }



      
    }

 
}