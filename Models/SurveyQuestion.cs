using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class SurveyQuestion
    {
        public SurveyQuestion()
        {
            SurveyAnswers = new HashSet<SurveyAnswer>();
        }

        public Guid SurveyQuestionId { get; set; }
        public Guid SurveyId { get; set; }
        public string SurveyQuestion1 { get; set; }
        public string SurveyQuestionDescription { get; set; }
        public string QuestionType { get; set; }
        public bool ProductQuestion { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? Order { get; set; }

        public virtual SurveyDefinition Survey { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; }
    }
}
