using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Entities
{
    [Table("Log_19118162", Schema = "19118162")]
    public class Log_19118162
    {
        public Guid Id { get; set; }
        public string TableName { get; set; }
        public string OperationType { get; set; }
        public DateTime Date { get; set; }
    }
}
