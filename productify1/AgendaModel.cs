namespace productify1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AgendaModel : DbContext
    {
        public AgendaModel()
            : base("name=AgendaModel")
        {
        }

        public virtual DbSet<Agendum> Agenda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
