using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.Common
{
    public class BaseModel
    {
        [Key]

        public int Id { get; set; }

        public DateTime CreateOn { get; set; } = DateTime.UtcNow; 
    }
}
