using Simulation.Models;
using Simulation.ViewModels.Doctor;

namespace Simulation.ViewModels.Departament
{
    public class GetDepartments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GetDoctorVM> Doctors { get; set; }
    }
}
