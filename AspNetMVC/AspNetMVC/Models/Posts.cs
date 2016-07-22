namespace AspNetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Posts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Posts()
        {
            Comments = new HashSet<Comments>();
            Posts_Tags = new HashSet<Posts_Tags>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Body { get; set; }

        public DateTime Date { get; set; }

        public int? AuthorID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posts_Tags> Posts_Tags { get; set; }

        public virtual Users Users { get; set; }
    }
}
