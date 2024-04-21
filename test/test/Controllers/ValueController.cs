using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test.Model;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public ResponseModel Get()
        {
            ResponseModel res = new ResponseModel();
            res.status = true;
            res.message = "success";
            res.value = 50.0;
            return res;
        }
        [HttpPost]
        public ResponseModel Post(BaseModel model)
        {
            ResponseModel res = new ResponseModel();
            

            List<DiscountMain> listdiscount = new List<DiscountMain>();
            listdiscount.Add(new DiscountMain { name = "a", type = "A" });
            listdiscount.Add(new DiscountMain { name = "b", type = "A" });
            listdiscount.Add(new DiscountMain { name = "c", type = "C" });
            var total = 0;
            var dis = model.Discounts;
            //foreach (var item in dis)
            //{
            //    if (item.total > 0)
            //    {
            //        this.getValueaaaa("a");
            //        if (listdiscount.Select(x => x.name).Contains(item.name))
            //        {
            //            total += item.total;
            //        }
            //        else
            //        {
            //            res.message = "not found discount";
            //            return res;
            //        }

            //    }
            //}
            res.status = true;
            res.message = "calculate success";
            res.value = total;
            return res;
        }
        private int getValueaaaa(string a)
        {
            return 1;
        }
       
    }
}


