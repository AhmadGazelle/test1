using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AbCOn.Models
{
	public partial class ABCN : DbContext
	{
		public ABCN()
			: base("name=ABCN")
		{
		}

		public virtual DbSet<Cours> Course { get; set; }
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<Tetcher> Tetchers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
