using DataAccess;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BookCategory
    {
        public enum Mode
        {
            Add,
            Update
        }

        private BookCategoriesDTO _categoryDto;
        private Mode _currentMode;

        public Mode CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }
        public int CategoryId
        {
            get => _categoryDto.CategoryId;
            set => _categoryDto.CategoryId = value;
        }

        public string CategoryName
        {
            get => _categoryDto.CategoryName;
            set => _categoryDto.CategoryName = value;
        }

        public string CategoryDescription
        {
            get => _categoryDto.CategoryDescription;
            set => _categoryDto.CategoryDescription = value;
        }

        public BookCategory()
        {
            _categoryDto = new BookCategoriesDTO();
            _currentMode = Mode.Add;
        }

        private BookCategory(BookCategoriesDTO categoryDto)
        {
            _categoryDto = categoryDto;
            _currentMode = Mode.Update;
        }

        public static async Task<DataTable> GetAllCategoriesAsync()
        {
            return await BookCategoriesData.GetAllCategoriesAsync();
        }

        public static List<string> GetAllCategoryNames()
        {
            return BookCategoriesData.GetAllCategoryNames();
        }

        private bool AddNew()
        {
            CategoryId = BookCategoriesData.AddCategory(_categoryDto);
            return CategoryId > 0;
        }

        private bool Update()
        {
            return BookCategoriesData.UpdateCategory(_categoryDto);
        }

        public bool Save()
        {
            if (_currentMode == Mode.Add)
            {
                if (AddNew())
                {
                    _currentMode = Mode.Update;
                    return true;
                }

                return false;
            }

            return Update();
        }

        public static BookCategory FindCategory(int categoryId)
        {
            BookCategoriesDTO categoryDto = BookCategoriesData.GetCategoryById(categoryId);
            return categoryDto == null ? null : new BookCategory(categoryDto);
        }

        public static BookCategory FindCategory(string categoryName)
        {
            BookCategoriesDTO categoryDto = BookCategoriesData.GetCategoryByName(categoryName);
            return categoryDto == null ? null : new BookCategory(categoryDto);
        }

        public static bool DeleteCategory(int categoryId)
        {
            return BookCategoriesData.DeleteCategoryById(categoryId);
        }

        public string GetCategoryDescription()
        {
            return string.IsNullOrWhiteSpace(CategoryDescription) ? "No Description" : CategoryDescription;
        }
    }
}