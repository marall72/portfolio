using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoList.Enum;

namespace TodoList.Model
{
    [Table("Log")]
    public class Log : ModelBase
    {
        public LogType Type { get; set; }
        [Required]
        public string Desciption { get; set; }
    }
}
