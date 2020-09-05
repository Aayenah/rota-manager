using Microsoft.AspNetCore.Identity;
using MyRota.SmartEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyRota.Models
{
    public class Employee : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EnumDataType(typeof(Branch))]
        public Branch Branch { get; set; }

        [Required]
        [EnumDataType(typeof(Branch))]
        public Position Position { get; set; }

        public List<Shift> Shifts { get; } = new List<Shift>();

        public int MaxShiftLengthInHours { get; set; } = 8;

        public double TotalWeeklyHours { get; set; }


        public void AddShift(DateTime start, DateTime end, Branch branch, string comment = "No comments.")
        {
            if (start > end) // shift starts after it ends?
            {
                Console.WriteLine($"Shift cannot start after it ends. Start: {start} - End: {end}");
                return;
            }
            if (end - start > TimeSpan.FromHours(MaxShiftLengthInHours)) //shift is more than allowed hours?
            {
                Console.WriteLine($"Not allowed to work more than {MaxShiftLengthInHours} hours. Shift length: {end - start}");
                return;
            }
            Shifts.Add(new Shift { StartTime = start, EndTime = end });
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Gender.ToString()}";
        }
    }
}
