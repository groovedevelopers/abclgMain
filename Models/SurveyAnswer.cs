using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class SurveyAnswer
    {
        public Guid SurveyAnswerId { get; set; }
        public Guid SurveyQuestionId { get; set; }
        public string AspNetUserId { get; set; }
        public string Answer { get; set; }
        public string LongAnswer { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
