using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;  // Needed for the AllowHtml attribute

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        [AllowHtml]
        public string HTML { get; set; }

        [NotMapped]
        public string HTMLShort { get
            {
                return HTML == null ||
                    HTML.Length < 50 ? HTML : HTML.Substring(0, 50);
            }
        }

        [Display(Name = "Wait Days")]
        public int WaitDays { get; set; }

        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }

        [Display(Name = "Is Free")]
        public bool IsFree { get; set; }

        [Display(Name = "Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}