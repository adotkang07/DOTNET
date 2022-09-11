using System.ComponentModel.DataAnnotations;

namespace WebAPIDemo.Models
{
    public class CustomerModel
    {
        [Required]
        public string FirstName { get; set; }
    }
}
