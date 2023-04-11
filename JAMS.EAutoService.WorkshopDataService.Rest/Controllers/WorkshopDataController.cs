namespace JAMS.EAutoService.WorkshopDataService.Rest.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;


    using JAMS.EAutoService.WorkshopDataService.Logic;
    using JAMS.EAutoService.WorkshopDataService.Model;
    using JAMS.EAutoService.WorkshopDataService.Rest.Model;
    using Microsoft.AspNetCore.HttpOverrides;
    using static System.Net.Mime.MediaTypeNames;
    using System.Xml.Linq;
    using JAMS.EAutoService.WorkshopDataService.Model.Services;
    using JAMS.EAutoService.WorkshopDataService.Rest.Model.Services;

    [ApiController]
    [Route("[controller]")]
    public class WorkshopDataController : ControllerBase, IWorkshopDataService
    {
        private readonly ILogger<WorkshopDataController> logger;

        private readonly IWorkshopRepository workshopRepository;

        public WorkshopDataController(ILogger<WorkshopDataController> logger)
        {
            this.logger = logger;

            this.workshopRepository = new WorkshopRepository();
        }



        [HttpGet]
        [Route("GetWorkshop")]
        public Workshop GetWorkshop(int workshopID)
        {
            return workshopRepository.GetWorkshopById(workshopID);
        }

        [HttpGet]
        [Route("GetAllWorkshops")]
        public List<Workshop> GetAllWorkshops()
        {
            return workshopRepository.GetAll();
        }
    }
}
