using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.WebApi.Models
{
    [Table("employ")] //自訂db table name 
    public class Employ
    {
        [Key]//主键
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//透過db自動產出的唯一識別值
        [Column("id")] //自訂db table 欄位名稱 
        public int Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("salary")]
        public long Salary { get; set; }
    }
}