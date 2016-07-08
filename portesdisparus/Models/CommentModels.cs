﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PeopLost.Web.Models
{
    public class CommentModels
    {
        [Display(Name = "Comment")]
        [Required]
        public string Post { get; set; }

        [Display(Name = "Date Post")]
        public DateTime? DatePost { get; set; }

        /// <summary>
        /// Gets or sets the Alert Id
        /// </summary>
        public int AlertId { get; set; }

        /// <summary>
        /// Gets or sets the Member Id
        /// </summary>
        public int MemberId { get; set; }

    }

    public class ListViewCommentModel
    {
        private ICollection<CommentModels> _listcommentviewModel;

        public ListViewCommentModel()
        {
            this._listcommentviewModel.Add(new CommentModels(){
             AlertId=0,
              DatePost=DateTime.Now,
              MemberId=0,
             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });
            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 0,
                DatePost = DateTime.Now,
                MemberId = 1,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });
            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 0,
                DatePost = DateTime.Now,
                MemberId = 2,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 1,
                DatePost = DateTime.Now,
                MemberId = 0,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 1,
                DatePost = DateTime.Now,
                MemberId = 1,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 1,
                DatePost = DateTime.Now,
                MemberId = 2,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 3,
                DatePost = DateTime.Now,
                MemberId = 0,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 3,
                DatePost = DateTime.Now,
                MemberId = 1,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 3,
                DatePost = DateTime.Now,
                MemberId = 2,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 4,
                DatePost = DateTime.Now,
                MemberId = 0,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 5,
                DatePost = DateTime.Now,
                MemberId = 0,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 6,
                DatePost = DateTime.Now,
                MemberId = 0,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });
            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 6,
                DatePost = DateTime.Now,
                MemberId = 1,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });


            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 7,
                DatePost = DateTime.Now,
                MemberId = 0,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });

            this._listcommentviewModel.Add(new CommentModels()
            {
                AlertId = 7,
                DatePost = DateTime.Now,
                MemberId = 1,
                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            });



        }
    }
}
