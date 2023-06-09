﻿using Microsoft.EntityFrameworkCore;

namespace UniversityApp.Models
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Student> Students { get; set; }
	}


}
