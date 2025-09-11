using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.Blazor.Core.Components.Dev.Resources;
public class Appointment
{
    public Appointment() { }
    public int AppointmentType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Caption { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int? Label { get; set; }
    public int Status { get; set; }
    public bool AllDay { get; set; }
    public string Recurrence { get; set; }
    public int ResourceId { get; set; } 
    public string Resources { get; set; }
    public bool Accepted { get; set; }
}
