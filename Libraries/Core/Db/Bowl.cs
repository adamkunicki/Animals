namespace Animal.Db
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Bowl")]
    public partial class Bowl
    {
        public int BowlId { get; set; }

        public int DogId { get; set; }

        public DateTime Date { get; set; }

        public int ClickCount { get; set; }

        public virtual Dog Dog { get; set; }
    }
}
