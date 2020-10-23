using FernandaTron3000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FernandaTron3000.DAL
{
    public class ProjectInitializer : System.Data.Entity.CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var work = new Workmanships() {
                Name = "Workman Test",
                Description = "This is a description"
            };
            var firstCriteria = new Criteria()
            {
                Name = "Barniz Malo",
                Description = "Criteria description",
                Attachment = "Picture"
            };
            var secondCriteria = new Criteria()
            {
                Name = "Es UDP o HP?",
                Description = "Asi se ve un UDP",
                Attachment = "Otra picture"
            };
            context.Workmanships.Add(work);
            firstCriteria.Workmanship = work;
            secondCriteria.CriteriaList.Add(firstCriteria);
            context.Criteria.Add(firstCriteria);
            context.Criteria.Add(secondCriteria);

            context.SaveChanges();


        }
    }
}