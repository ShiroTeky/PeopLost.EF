using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.Web.Models
{
    public class AlertModels
    {

        public Int32 AlertId { get; set; }

        [Display(Name = "Comment")]
        [Required]
        public string Post { get; set; }

        public DateTime? DateAlert { get; set; }

        /// <summary>
        /// Gets or sets the User Id  
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the Person Id
        /// </summary>
        public Int32 PersonId { get; set; }

        /// <summary>
        /// Gets or sets the status of the alert: verified or not
        /// </summary>
        public bool ConcreteAlert { get; set; }
    }

    public class ListAlertViewModel
    {
        private ICollection<AlertModels> _listalertviewmodel;

        public ListAlertViewModel()
        {
            this._listalertviewmodel.Add(new AlertModels() {
                AlertId=0,
                PersonId=0,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 0
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=1,
                PersonId = 1,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 1
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=2,
                PersonId = 2,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 0
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=3,
                PersonId = 3,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 0
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=4,
                PersonId = 4,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 2
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=5,
                PersonId = 5,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 2
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=6,
                PersonId = 6,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 1
            });
            this._listalertviewmodel.Add(new AlertModels()
            {
                AlertId=7,
                PersonId = 7,
                Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
                DateAlert = DateTime.Now,
                ConcreteAlert = true,
                UserId = 2
            });
        }
    }
}
