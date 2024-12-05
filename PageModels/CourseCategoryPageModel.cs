using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppProject.PageModels
{
    public partial class CourseCategoryPageModel : ObservableObject, IProjectTaskPageModel
    {
        private readonly ICourseCategory _courseCategory;
        public IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand => throw new NotImplementedException();

        public bool IsBusy => throw new NotImplementedException();

        public ObservableCollection<CourseCategory> CourseCategories { get; } = new(); 

        public CourseCategoryPageModel(ICourseCategory courseCategory) 
        {
            _courseCategory = courseCategory;
        }

        [RelayCommand]
        async Task LoadCourseCategories()
        {
            try
            {
                CourseCategories.Clear();
                var courseCategories = await _courseCategory.ListAsync();
                foreach (var courseCategory in courseCategories)
                {
                    CourseCategories.Add(courseCategory);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
    }
}
