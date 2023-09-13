using System.ComponentModel.DataAnnotations;

namespace Ticket.Api.Models;

public class Place
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public long Capacity { get; set; }
    public long Rows { get; set; }
    public long SeatsInRow { get; set; }

}