using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FernandaTron3000.Models
{
    public class Criteria
    {
        public Criteria(){
            CriteriaList = new HashSet<Criteria>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Attachment { get; set; }
        public int WorkmanshipId { get; set; }
        public virtual Workmanships? Workmanship { get; set; }
        public virtual ICollection<Criteria> CriteriaList {get; set;}
    }
}