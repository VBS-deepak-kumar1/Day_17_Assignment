//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabPracticeProblem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DeepakFriend
    {
        public int FriendID { get; set; }
        [Required(ErrorMessage = "Friend Name Empty Not Allowed")]
        [StringLength(15, ErrorMessage = "Friend Name Can't exceed 15 character")]
        public string FriendName { get; set; }
        public string Place { get; set; }
    }
}