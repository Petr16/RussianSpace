using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RussianSpace.DAL.Entities
{
    public class Request
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //[ForeignKey("Customername")]
        /*public int CustomerId { get; set; }

        //public int CustomerName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? TargetExecutionDate { get; set; }

        //[ForeignKey("Statusrequestname")]
        public int? StatusRequestId { get; set; }


        public DateTime? ModifyDate { get; set; }

        public string? Phone { get; set; }

        public string? Comment { get; set; }

        public string? FileUrl { get; set; }*/
    }
}
