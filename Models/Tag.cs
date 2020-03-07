using Cloudy.CMS.ContentSupport;
using Cloudy.CMS.ContentTypeSupport;
using System.ComponentModel.DataAnnotations;

namespace CrmTest.Models
{
    [ContentType("e8f6760f-e6b8-4384-916d-758ed9d65092")]
    public class Tag : IContent, INameable
    {
        public string Id { get; set; }
        public string ContentTypeId { get; set; }
        public string Name { get; set; }
        [Display(GroupName = "Lorem")]
        public string Test { get; set; }
    }
}