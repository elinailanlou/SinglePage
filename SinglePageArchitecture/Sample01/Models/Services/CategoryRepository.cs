using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sample01.Models.Services
{
    public class CategoryRepository
    {
//        #region [- ctor -]
//        public CategoryRepository()
//        {

//        }
//        #endregion

//        #region [- Props -]
//        public string Message { get; private set; }
//        #endregion

//        #region [- Select() -]
//        public List<Models.DomainModels.Dtos.Category> Select()
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    var q = context.Category.ToList();
//                    return q;
//                }
//                catch (Exception)
//                {

//                    throw;
//                }
//                //finally
//                //{
//                //    if (context == null)
//                //    {
//                //        context.Dispose();
//                //    }
//                //}

//            }
//        }
//        #endregion

//        #region [- Insert() -]
//        public void Insert(Models.DomainModels.Dtos.Category category)
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    context.Category.Add(category);
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }


//        #endregion

//        #region [- FindId(int? id) -]
//        public Models.DomainModels.Category FindId(int? id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    return q;
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion

//        #region [- Update() -]
//        public void Update(Models.DomainModels..Category category)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    context.Entry(category).State = EntityState.Modified;
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }

//        }
//        #endregion

//        #region [- Delete(int id) -]
//        public void Delete(int id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    context.Category.Remove(q);
//                    context.SaveChanges();

//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion#region [- ctor -]
//        public CategoryRepository()
//        {

//        }
//        #endregion

//        #region [- Props -]
//        public string Message { get; private set; }
//        #endregion

//        #region [- Select() -]
//        public List<Models.DomainModels.Dtos.Category> Select()
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    var q = context.Category.ToList();
//                    return q;
//                }
//                catch (Exception)
//                {

//                    throw;
//                }
//                //finally
//                //{
//                //    if (context == null)
//                //    {
//                //        context.Dispose();
//                //    }
//                //}

//            }
//        }
//        #endregion

//        #region [- Insert() -]
//        public void Insert(Models.DomainModels.Dtos.Category category)
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    context.Category.Add(category);
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }


//        #endregion

//        #region [- FindId(int? id) -]
//        public Models.DomainModels.Category FindId(int? id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    return q;
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion

//        #region [- Update() -]
//        public void Update(Models.DomainModels..Category category)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    context.Entry(category).State = EntityState.Modified;
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }

//        }
//        #endregion

//        #region [- Delete(int id) -]
//        public void Delete(int id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    context.Category.Remove(q);
//                    context.SaveChanges();

//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion#region [- ctor -]
//        public CategoryRepository()
//        {

//        }
//        #endregion

//        #region [- Props -]
//        public string Message { get; private set; }
//        #endregion

//        #region [- Select() -]
//        public List<Models.DomainModels.Dtos.Category> Select()
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    var q = context.Category.ToList();
//                    return q;
//                }
//                catch (Exception)
//                {

//                    throw;
//                }
//                //finally
//                //{
//                //    if (context == null)
//                //    {
//                //        context.Dispose();
//                //    }
//                //}

//            }
//        }
//        #endregion

//        #region [- Insert() -]
//        public void Insert(Models.DomainModels.Dtos.Category category)
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    context.Category.Add(category);
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }


//        #endregion

//        #region [- FindId(int? id) -]
//        public Models.DomainModels.Category FindId(int? id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    return q;
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion

//        #region [- Update() -]
//        public void Update(Models.DomainModels..Category category)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    context.Entry(category).State = EntityState.Modified;
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }

//        }
//        #endregion

//        #region [- Delete(int id) -]
//        public void Delete(int id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    context.Category.Remove(q);
//                    context.SaveChanges();

//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion#region [- ctor -]
//        public CategoryRepository()
//        {

//        }
//        #endregion

//        #region [- Props -]
//        public string Message { get; private set; }
//        #endregion

//        #region [- Select() -]
//        public List<Models.DomainModels.Dtos.Category> Select()
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    var q = context.Category.ToList();
//                    return q;
//                }
//                catch (Exception)
//                {

//                    throw;
//                }
//                //finally
//                //{
//                //    if (context == null)
//                //    {
//                //        context.Dispose();
//                //    }
//                //}

//            }
//        }
//        #endregion

//        #region [- Insert() -]
//        public void Insert(Models.DomainModels.Dtos.Category category)
//        {
//            using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//            {
//                try
//                {
//                    context.Category.Add(category);
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }


//        #endregion

//        #region [- FindId(int? id) -]
//        public Models.DomainModels.Category FindId(int? id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    return q;
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        #endregion

//        #region [- Update() -]
//        public void Update(Models.DomainModels..Category category)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    context.Entry(category).State = EntityState.Modified;
//                    context.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }

//        }
//        #endregion

//        #region [- Delete(int id) -]
//        public void Delete(int id)
//        {
//            using (var context = new Models.DomainModels.OnlineStoreEntities())
//            {
//                try
//                {
//                    var q = context.Category.Find(id);
//                    context.Category.Remove(q);
//                    context.SaveChanges();

//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//                finally
//                {
//                    if (context != null)
//                    {
//                        context.Dispose();
//                    }
//                }

//            }
//        }
//        //#endregion#region [- ctor -]
//        //public CategoryRepository()
//        //{

//        //}
//        //#endregion

//        //#region [- Props -]
//        //public string Message { get; private set; }
//        //#endregion

//        //#region [- Select() -]
//        //public List<Models.DomainModels.Dtos.Category> Select()
//        //{
//        //    using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//        //    {
//        //        try
//        //        {
//        //            var q = context.Category.ToList();
//        //            return q;
//        //        }
//        //        catch (Exception)
//        //        {

//        //            throw;
//        //        }
//        //        //finally
//        //        //{
//        //        //    if (context == null)
//        //        //    {
//        //        //        context.Dispose();
//        //        //    }
//        //        //}

//        //    }
//        //}
//        //#endregion

//        //#region [- Insert() -]
//        //public void Insert(Models.DomainModels.Dtos.Category category)
//        //{
//        //    using (var context = new Models.DomainModels.Dtos.OnlineShopDbContext())
//        //    {
//        //        try
//        //        {
//        //            context.Category.Add(category);
//        //            context.SaveChanges();
//        //        }
//        //        catch (Exception)
//        //        {
//        //            throw;
//        //        }
//        //        finally
//        //        {
//        //            if (context != null)
//        //            {
//        //                context.Dispose();
//        //            }
//        //        }

//        //    }
//        //}


//        //#endregion

//        //#region [- FindId(int? id) -]
//        //public Models.DomainModels.Category FindId(int? id)
//        //{
//        //    using (var context = new Models.DomainModels.OnlineStoreEntities())
//        //    {
//        //        try
//        //        {
//        //            var q = context.Category.Find(id);
//        //            return q;
//        //        }
//        //        catch (Exception)
//        //        {
//        //            throw;
//        //        }
//        //        finally
//        //        {
//        //            if (context != null)
//        //            {
//        //                context.Dispose();
//        //            }
//        //        }

//        //    }
//        //}
//        //#endregion

//        //#region [- Update() -]
//        //public void Update(Models.DomainModels..Category category)
//        //{
//        //    using (var context = new Models.DomainModels.OnlineStoreEntities())
//        //    {
//        //        try
//        //        {
//        //            context.Entry(category).State = EntityState.Modified;
//        //            context.SaveChanges();
//        //        }
//        //        catch (Exception)
//        //        {
//        //            throw;
//        //        }
//        //        finally
//        //        {
//        //            if (context != null)
//        //            {
//        //                context.Dispose();
//        //            }
//        //        }

//        //    }

//        //}
//        //#endregion

//        //#region [- Delete(int id) -]
//        //public void Delete(int id)
//        //{
//        //    using (var context = new Models.DomainModels.OnlineStoreEntities())
//        //    {
//        //        try
//        //        {
//        //            var q = context.Category.Find(id);
//        //            context.Category.Remove(q);
//        //            context.SaveChanges();

//        //        }
//        //        catch (Exception)
//        //        {
//        //            throw;
//        //        }
//        //        finally
//        //        {
//        //            if (context != null)
//        //            {
//        //                context.Dispose();
//        //            }
//        //        }

//        //    }
//        //}
//        //#endregion
  }
}