using Core.Entities;
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

        public int DailyPrice { get; set; }

        public int MyProperty { get; set; }

    }
}
