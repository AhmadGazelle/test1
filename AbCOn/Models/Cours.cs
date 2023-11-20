namespace AbCOn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Cours
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        [StringLength(50)]
        public string IsAvilable { get; set; }
    }
}
