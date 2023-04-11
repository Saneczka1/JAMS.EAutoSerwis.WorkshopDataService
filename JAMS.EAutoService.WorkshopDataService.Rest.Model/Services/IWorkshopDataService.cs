using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMS.EAutoService.WorkshopDataService.Rest.Model.Services
{
    using JAMS.EAutoService.WorkshopDataService.Model;
    using JAMS.EAutoService.WorkshopDataService.Rest.Model;
    public interface IWorkshopDataService
    {
        public Workshop GetWorkshop(int workshopID);

    }
}
