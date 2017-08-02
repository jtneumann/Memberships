using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("ProductLinkText")]
    public class ProductLinkText
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }

        [MaxLength(25)]
        [Required]
        public string Title { get; set; }
    }
}