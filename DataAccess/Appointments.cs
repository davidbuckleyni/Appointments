using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Appointments
    {
        [Key]
        public int id { get; set; }
        public string PatientName { get; set; }
        public DateTime DateOfBirths { get; set; }
        public bool isArrived { get; set; }
        public string Notes { get; set; }

    }
}
