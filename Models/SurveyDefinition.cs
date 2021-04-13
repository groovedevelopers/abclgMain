using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class SurveyDefinition
    {
        public SurveyDefinition()
        {
            SurveyQuestions = new HashSet<SurveyQuestion>();
        }

        public Guid SurveyId { get; set; }
        public Guid CompanyId { get; set; }
        public string SurveyName { get; set; }
        public string SurveyDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool VisibleAfterFill { get; set; }
        public bool FillAgainPossible { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
