using Cloudy.CMS.ContentSupport;
using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.UI.FormSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrmTest.Models
{
    [ContentType("77d9d9b7-9b84-459f-af72-344b8cc04406")]
    public class Prospect : IContent, INameable
    {
        public string Id { get; set; }
        public string ContentTypeId { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"\A.*@.*\..*\Z")]
        public string Email { get; set; }
        public ProspectAddress Address { get; set; }
        [Display(GroupName = "Lorem")]
        public string Test { get; set; }
        [UIHint("dropdown('e8f6760f-e6b8-4384-916d-758ed9d65092')")]
        public IEnumerable<string> Tags { get; set; }

        [Form("8af368be-5ee8-4948-9415-89ab338bfcc2")]
        public class ProspectAddress
        {
            public string Street { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }
    }
}
