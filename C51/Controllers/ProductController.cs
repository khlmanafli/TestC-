using C51.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace C51.Controllers
{

    [ApiController]
    public class ProductController : ControllerBase
    {

        DBGR93Context db = new DBGR93Context();

        [Route("api/[controller]")]
        [HttpGet]
        public List<Product> Get()
        {
            return db.Products.ToList();
        }


        [Route("api/[controller]")]
        [HttpGet]
        public Product Get(int id)
        {
            Product data = db.Products.Find(id);
            return data;
        }

        [Route("api/[controller]")]
        [HttpPost]
        public string Gonder(Product pro)
        {
            string res = "";
            try
            {
                db.Products.Add(pro);
                db.SaveChanges();
                res = "Success";
            }
            catch (SqlException ex)
            {
                res = ex.Message;
            }
            finally
            {
                db.Dispose();
            }
            return res;
        }

        [Route("api/[controller]")]
        [HttpPut]
        public string Deyis(int id, Product prod)
        {
            string res = "";
            try
            {
                var pro = db.Products.Find(id);
                pro.Name = prod.Name;
                pro.Category = prod.Category;
                pro.MadedBy = prod.MadedBy;
                pro.ProductDate = prod.ProductDate;
                pro.Price = prod.Price;
                db.SaveChanges();
                res = "Success";
            }
            catch (SqlException ex)
            {
                res = ex.Message;
            }
            finally
            {
                db.Dispose();
            }
            return res;
        }

        [Route("api/[controller]")]
        [HttpDelete]

        public string Delete(int id)
        {
            string res = "";
            try
            {
                var pro = db.Products.Find(id);
                db.Remove(pro);
                db.SaveChanges();
                res = "Success";

            }
            catch (SqlException ex)
            {
                res = ex.Message;
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return res;
        }

    }
}
