namespace Simulation.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }

    }
}
