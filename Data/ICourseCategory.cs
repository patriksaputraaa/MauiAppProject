using MauiAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppProject.Data
{
    public interface ICourseCategory
    {
        Task<List<CourseCategory>> ListAsync();
        Task<List<CourseCategory>> GetAsync(int id);
        Task<CourseCategory> AddAsync(CourseCategory category);
        Task<CourseCategory> UpdateAsync(CourseCategory category);
        Task<CourseCategory> DeleteAsync(int id);
    }
}
