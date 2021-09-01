using System;
using System.Collections.Generic;
using System.Text;

namespace LoveFriends.Shared.Entities.Abstract
{
   public abstract class EntityBase
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsActive  { get; set; }
        public bool IsDeleted { get; set; }

    }
}
