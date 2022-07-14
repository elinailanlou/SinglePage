
using Sample01.Models.DomainModels;
using Sample01.Models.Infrastructures;
using Sample01.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample01.Models.ViewModels
{
    public class CategoryViewModel
    {
        private readonly IProductRepository _productRepository;

        #region [- ctor -]

        public CategoryViewModel(IProductRepository productRepository)
        {
            CategoryRepository = new Services.CategoryRepository();
            _productRepository = productRepository;
        }
        #endregion

        #region [- Props for Class -]
        public Services.CategoryRepository CategoryRepository { get; private set; }
        #endregion

        #region [- LoadCategories() -]
        public List<Category> LoadCategories()
        {
            var c = CategoryRepository.Select();
            return c;
        }
        #endregion

        #region [- Save() -]
        public void Save(Controllers.Dtos.Category.DtoPostCategory dtoPostCategory)
        {
            CategoryRepository.Insert(Convertor.DtoConvertor(dtoPostCategory));
        }
        #endregion

        #region [- ShowDetails(int? id) -]
        //public Models.DomainModels.Category ShowDetails(int? id)
        //{
        //    return Ref_CategoryService.FindId(id);
        //}
        #endregion

        #region [- Edit() -]
        //public void Edit(Controllers.Dto.Category Category)
        //{
        //    Ref_CategoryService.Update(Convertor.DtoConvertor(Category));
        //}
        #endregion

        #region [- Delete(int id) -]
        //public void Delete(int id)
        //{
        //    Ref_CategoryService.Delete(id);
        //}
        #endregion
    }
}