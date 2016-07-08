using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.Web.Models
{
    public class MemberModels
    {
        /// <summary>
        /// Gets or sets the Member Guid
        /// </summary>
        public Int32 MemberId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Status")]
        public bool isAdmin { get; set; }

        public string ImageUrl { get; set; }

    }

    public class ListMemberViewModel
    {
        private ICollection<MemberModels> _listmemberViewModel;

        public ListMemberViewModel()
        {
            this._listmemberViewModel.Add(new MemberModels() { 
                MemberId=0,
                 FirstName="Koffi", LastName="Hermann", Gender="M", isAdmin=false, Email="xyz@peoplost.com", Phone="XX-XX-XX-XX"
            });
            this._listmemberViewModel.Add(new MemberModels()
            {
                MemberId = 1,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                isAdmin = false,
                Email = "xyz@peoplost.com",
                Phone = "XX-XX-XX-XX",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listmemberViewModel.Add(new MemberModels()
            {
                MemberId = 2,
                FirstName = "Kouakou",
                LastName = "Hermann",
                Gender = "M",
                isAdmin = false,
                Email = "xyz@peoplost.com",
                Phone = "XX-XX-XX-XX",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listmemberViewModel.Add(new MemberModels()
            {
                MemberId = 3,
                FirstName = "Kouassi",
                LastName = "Hermann",
                Gender = "M",
                isAdmin = false,
                Email = "xyz@peoplost.com",
                Phone = "XX-XX-XX-XX",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listmemberViewModel.Add(new MemberModels()
            {
                MemberId = 4,
                FirstName = "Kone",
                LastName = "Hermann",
                Gender = "M",
                isAdmin = false,
                Email = "xyz@peoplost.com",
                Phone = "XX-XX-XX-XX",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listmemberViewModel.Add(new MemberModels()
            {
                MemberId = 5,
                FirstName = "Kouadio",
                LastName = "Hermann",
                Gender = "M",
                isAdmin = false,
                Email = "xyz@peoplost.com",
                Phone = "XX-XX-XX-XX",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
        }
    }
}
