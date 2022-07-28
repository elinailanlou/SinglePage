using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample02.Models.Infrastructures
{
    public class Convertor
    {
        #region [- DtoConvertor(Dtos.Category.DtoPostCategory dto) -]
        public static Models.DomainModels.Dtos DtoConvertor(Controllers.Dtos.Category.DtoPostCategory dto)
        {
            Models..Dtos.Category model = new Models.DomainModels.Dtos.Category();
        model.Code = dto.Code;
            model.Title = dto.Title;
            return model;
        }
    #endregion

    #region [- DtoConvertor(List<Models.DomainModels.Category> modelList) -]
    public static List<Controllers.Dtos.Category.DtoGetCategory> DtoConvertor(List<Models.DomainModels.Dtos.Category> modelList)
    {
        List<Controllers.Dtos.Category.DtoGetCategory> dtoList = new List<Controllers.Dtos.Category.DtoGetCategory>();
        foreach (var item in modelList)
        {
            var dto = new Controllers.Dtos.Category.DtoGetCategory();
            dto.Id = item.Id;
            dto.Code = item.Code;
            dto.Title = item.Title;
            dtoList.Add(dto);
        }
        return dtoList;
    }
    #endregion

}
}