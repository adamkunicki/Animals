namespace Animal.Db
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Dog")]
    public partial class Dog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dog()
        {
            Bowls = new HashSet<Bowl>();
        }

        public int DogId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int TargetClickCount { get; set; }

        public int CurrentClickCount { get; set; }

        public string SadImg { get; set; }

        public string HappyImg { get; set; }

        [Required]
        public string SponsorLogo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bowl> Bowls { get; set; }
    }
}
