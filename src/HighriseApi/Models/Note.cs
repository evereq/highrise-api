﻿using RestSharp.Serializers;
using System;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "note")]
    public class Note : BaseModel
    {
        [SerializeAs(Name = "body")]
        public string Body { get; set; }

        [SerializeAs(Name = "author-id")]
        public int AuthorId { get; set; }

        [SerializeAs(Name = "subject-id")]
        public int SubjectId { get; set; }

        /// <summary>
        /// #{ Party || Deal || Kase }
        /// </summary>
        [SerializeAs(Name = "subject-type")]
        public string SubjectType { get; set; }

        /// <summary>
        /// e.g. "John Doe"
        /// </summary>
        [SerializeAs(Name = "subject-name")]
        public string SubjectName { get; set; }

        [SerializeAs(Name = "collection-id")]
        public int? CollectionId { get; set; }

        [SerializeAs(Name = "collection-type")]
        public string CollectionType { get; set; }

        [SerializeAs(Name = "visible-to")]
        public string VisibleTo { get; set; }

        [SerializeAs(Name = "owner-id")]
        public int? OwnerId { get; set; }

        [SerializeAs(Name = "group-id")]
        public int? GroupId { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }
        
        
    }
}
