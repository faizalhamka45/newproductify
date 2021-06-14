namespace productify1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agendum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Jenis { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        public DateTime Tanggal { get; set; }

        public TimeSpan? Pukul { get; set; }

        [StringLength(50)]
        public string Tempat { get; set; }

        [StringLength(80)]
        public string Deskripsi { get; set; }
    }
}
