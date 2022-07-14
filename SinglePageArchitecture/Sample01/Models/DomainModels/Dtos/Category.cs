using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample01.Models.DomainModels.Dtos
{
    public class Category
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
    }
}