using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using JAMS.EAutoService.WorkshopDataService.Model;
namespace JAMS.EAutoService.WorkshopDataService.Logic
{
    public class WorkshopRepositoryReader
    {
        public List<Workshop> GetWorkshopsFromJson(string filename)
        {
            List<Workshop> workshops = new List<Workshop>(JsonSerializer.
                Deserialize<Workshop[]>(File.ReadAllText(filename)));


            return workshops;
        }
    }
}
