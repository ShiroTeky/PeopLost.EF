using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.Web.Models
{
    public class PersonModels
    {

        /// <summary>
        /// Gets or sets the Person Guid
        /// </summary>
        public Int32 PersonId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Day of the Disappearing")]
        [Required]
        public DateTime DayDisappear { get; set; }

        [Display(Name = "Adress or street where he disappeared")]
        [Required]
        public string LooserAddress { get; set; }

        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }

        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Year Old")]
        [Required]
        public int YearsOld { get; set; }

        [Display(Name = "Caracteristics")]
        [Required]
        public string Caracteristics { get; set; }

        public string ImageUrl { get; set; }
    }

    public class ListPersonViewModel
    {
        private ICollection<PersonModels> _listpersonViewModel;

        public ListPersonViewModel()
        {
            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 0,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country="Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress="Abobo",
                DayDisappear=DateTime.Now,
                Caracteristics="Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 1,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Cocody",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 2,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Plateau",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 3,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Adjame",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 4,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Abobo",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });
            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 5,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Adjame",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });

            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 6,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Adjame",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl = "/Images/alexisdiaw.jpg"
            });

            this._listpersonViewModel.Add(new PersonModels()
            {
                PersonId = 7,
                FirstName = "Koffi",
                LastName = "Hermann",
                Gender = "M",
                Country = "Cote d'ivoire",
                City = "Abidjan",
                YearsOld = 12,
                LooserAddress = "Adjame",
                DayDisappear = DateTime.Now,
                Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
                ImageUrl ="/Images/alexisdiaw.jpg"
            });
        }
    }
}