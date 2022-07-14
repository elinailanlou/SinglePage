using Sample01.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample01.Controllers
{
    public class CategoryController : Controller
    {
        //#region [- ctor -]
        //public CategoryController()
        //{
        //    CategoryViewModel = new Models.ViewModels.CategoryViewModel();
        //}
        //#endregion

        //#region [- Props -]

        //public Models.ViewModels.CategoryViewModel CategoryViewModel { get; private set; }
        //public Controllers.Dtos.Category.DtoGetCategory DtoGetCategory { get; set; }

        //#endregion

        //#region [-Actions-]

        //#region [-Category()-]
        //public ActionResult Category()
        //{
        //    DtoGetCategory = new Dtos.Category.DtoGetCategory();
        //    return View(DtoGetCategory);
        //}

        //#endregion

        //#region [- LoadDataTable() -]
        
        //public JsonResult LoadDataTable()
        //{
        //    var result =Convertor.DtoConvertor( CategoryViewModel.LoadCategories());
        //    return Json(new { data = result },JsonRequestBehavior.AllowGet);

        //}
        //#endregion

        //#region [- Create() -]
        //[HttpPost]
        //public ActionResult Create( Controllers.Dtos.Category.DtoPostCategory category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        CategoryViewModel.Save(category);
        //        return RedirectToAction("Category");
        //    }
        //    else { return View("Category"); }
        //}
        //#endregion

        //#region [- Edit() -]
        ////[HttpPost]

        ////public ActionResult Edit([Bind(Include = "Id,CategoryCode,CategoryName")] ProductCategory productCategory)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        Ref_ProductCategoryViewModel.Edit(productCategory);
        ////        return RedirectToAction("ProductCategory");
        ////    }
        ////    else
        ////    {
        ////        return View("ProductCategory");
        ////    }
        ////}
        //#endregion

        //#region [- Delete() -]
        ////[HttpPost]
        ////public ActionResult Delete(int id)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        Ref_ProductCategoryViewModel.Delete(id);
        ////        return RedirectToAction("ProductCategory");
        ////    }
        ////    else
        ////    {
        ////        return View("ProductCategory");
        ////    }

        ////}
        //#endregion

        //#endregion


    }
}