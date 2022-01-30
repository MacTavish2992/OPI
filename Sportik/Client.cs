namespace Sportik
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        public int IdClient { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Surname { get; set; }

        [Required]
        [StringLength(40)]
        public string Patronymic { get; set; }

        public int Age { get; set; }

        [StringLength(14)]
        public string PhoneNumber { get; set; }

        public int IdInstructor { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
