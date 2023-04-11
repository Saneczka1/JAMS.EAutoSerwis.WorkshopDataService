using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMS.EAutoService.WorkshopDataService.Model;
using JAMS.EAutoService.WorkshopDataService.Model.Services;

namespace JAMS.EAutoService.WorkshopDataService.Logic
{
    public class WorkshopRepository : IWorkshopRepository
    {
        private static readonly List<Workshop> Workshops;

        private static readonly object workshopLock = new object();

        private const string workshopJsonFilename = "workshop.json";

        static WorkshopRepository()
        {
            lock (WorkshopRepository.workshopLock)
            {
                WorkshopRepositoryReader workshopRepositoryReader = new WorkshopRepositoryReader();
                Workshops = workshopRepositoryReader.GetWorkshopsFromJson(workshopJsonFilename);
            }
        }
        public WorkshopRepository()
        {
        }


        public void AddWorkshops(List<Workshop> workshops)
        {
            lock (workshopLock)
            {

            }
        }

        public Workshop GetWorkshopById(int workshopID)
        {
            lock (workshopLock)
            {
                return Workshops.Find(x => x.WorkshopID == workshopID);
            }
        }

        public List<Workshop> GetAll()
        {
            lock (workshopLock)
            {
                return Workshops;
            }

        }
    }
}
