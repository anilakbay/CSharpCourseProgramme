using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo;

public class ProductDal
{
    public List<Product> GetAll()
    {
        using (ETradeContext context = new ETradeContext())
        {
            return context.Products.ToList();
        }
    }
    public void Add(Product product)
    {
        using (ETradeContext context = new ETradeContext())
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }


}
