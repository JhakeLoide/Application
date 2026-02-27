using App.Domain.Enums;
namespace App.Domain.Entities
{
    public class Computer
    {
        public int PCNumber { get; set; }

        public string PartDamage { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty;  

    }
}
