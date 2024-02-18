using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {
      //  public int? UserId { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public int ContentTypeId { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
      //  public virtual User? User { get; set; }
        public virtual ContentType? ContentType { get; set; }
        public virtual Category? Category { get; set; }
        public virtual PathFile? PathFile { get; set; }
        public virtual Organization? Organization { get; set; }
        public virtual ICollection<Lesson>? Lessons { get; set; }
      


    }
}

