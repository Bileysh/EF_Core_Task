using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task.Entities
{
    public class Hall
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int AmountPlaces { get; set; }
        public string TypeHall { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
