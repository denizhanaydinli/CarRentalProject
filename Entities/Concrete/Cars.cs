using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Cars :IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }

    }
}
