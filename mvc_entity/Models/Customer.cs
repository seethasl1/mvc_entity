using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc_entity.Models
{
    public class Customer
    {
        //    [Required(ErrorMessage = "ID shoud be number")]
        //    [DataType(DataType.Text)]
        //    [Key]
        //    public string custid { get; set; }

        //    [Required]
        //    [StringLength(5)]
        //    public string custname { get; set; }
        //    [Required(ErrorMessage = "Number should be in currency")]
        //    [DataType(DataType.Currency)]

        //    public double salary { get; set; }
        //    public dept select_dept { get; set; }
        //    public state state1 { get; set; }

        //}


        //    public enum dept
        //    {
        //       Hr,Fin,Training
        //    }
        //public enum state
        //{
        //    Tamilnadu,
        //    Karnataka
        //}
       [Key]
        public int custid { get; set; }
        public string custname { get; set; }
        //public string place { get; set; }
        //public double salary { get; set; }

    }
}