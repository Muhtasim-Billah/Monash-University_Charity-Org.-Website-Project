//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//using System.ComponentModel.DataAnnotations;
namespace HighDistinctionTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Donation
    {
        [Required]
        public int donation_id { get; set; }
        [DisplayName("User ID:")]
        public Nullable<int> user_id { get; set; }
        [Required]
        [DisplayName("Title:")]
        public string title_ { get; set; }
        [Required]
        [DisplayName("Field:")]
        public string field { get; set; }
        [Required]
        [DisplayName("Description:")]
        public string description { get; set; }
        [Required]
        [DisplayName("Amount:")]
        public decimal amount { get; set; }
        [Required]
        [DisplayName("Donation Date:")]
        public System.DateTime donation_date { get; set; }
        [Required]
        [DisplayName("Comments:")]
        public string comments { get; set; }
    
        public virtual RegisteredUser RegisteredUser { get; set; }
    }
}