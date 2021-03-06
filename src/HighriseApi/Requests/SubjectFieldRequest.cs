﻿using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Serializers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace HighriseApi.Requests
{
    public class SubjectFieldRequest : RequestBase, ISubjectFieldRequest
    {
        public SubjectFieldRequest(IRestClient client) : base(client) { }

        public IEnumerable<SubjectField> Get()
        {
            var response = Client.Execute<List<SubjectField>>(new RestRequest("subject_fields.xml", Method.GET));
            var subjectFields = response.Data;
            return subjectFields;
        }

        public SubjectField Create(SubjectField subjectfield)
        {
            var request = new RestRequest("subject_fields.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(subjectfield);

            var response = Client.Execute<SubjectField>(request);
            return response.Data;
        }

        public bool Update(SubjectField subjectField)
        {
            var request = new RestRequest("subject_fields/{id}.xml", Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddParameter("id", subjectField.Id, ParameterType.UrlSegment);
            request.AddBody(subjectField);

            var response = Client.Execute<Kase>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = Client.Execute<Kase>(new RestRequest(String.Format("subject_fields/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
