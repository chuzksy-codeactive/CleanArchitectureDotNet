using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniviersityDbContext _context;
        public CourseRepository(UniviersityDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
