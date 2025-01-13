namespace Simulation.ViewModels.Doctor
{
    public class GetDoctorVM
    {
        public int Id { get; set; }
        public IFormFile Photo { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }
    }
}
