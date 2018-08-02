using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPractike.Models
{
    public class DaysDTO
    {
        public int Id { get; set; }//id
        public DateTime Date { get; set; }//дата и время
        public string Target { get; set; }//цель
        public int V { get; set; }//галочка выполнения
    }
}
