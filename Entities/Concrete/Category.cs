using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Bir klass bos qalmamalidir.Nedense miras almalidir indi ehtiyac olmuya biler ama zamanla lazim olacag.
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
