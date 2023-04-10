using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApp.Models
{
    public class Item : Entity
    {
        public string ItemNumber { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        [ForeignKey("classroom_id")]
        public Guid ClassroomId { get; set; }
        [ForeignKey("category_id")]
        public Guid CategoryId { get; set; }
    }
}
