using System;

namespace JAMS.EAutoService.WorkshopDataService.Model
{
    public class Workshop
    {
        public int WorkshopID { get; set; }
        public string Addres { get; set; }
      
      


        public Workshop() { }
        public Workshop(int workshopID, string addres)
        {
            WorkshopID = workshopID;
            Addres = addres;
        }
    }
}
