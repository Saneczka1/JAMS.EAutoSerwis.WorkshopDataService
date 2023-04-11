namespace JAMS.EAutoService.WorkshopDataService.Model.Services
{
    public interface IWorkshopRepository
    {
        public Workshop GetWorkshopById(int WorkshopID);

        public List<Workshop> GetAll();

        public void AddWorkshops(List<Workshop> workshops);


    }
}
