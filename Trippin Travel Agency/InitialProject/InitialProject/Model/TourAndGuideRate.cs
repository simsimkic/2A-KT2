using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Model
{
    public class TourAndGuideRate
    {
        public int id { get; set; }

        public int guestId { get; set; }
        public int tourId { get; set; }

        public int guideKnowledgeRating { get; set; }

        public int guideLanguageUsageRating { get; set; }

        public int contentRating { get; set; }

        public string personalComment { get; set; }
        public int tourGuideId { get; set; }
        public bool valid { get; set; }

        public TourAndGuideRate(int guestId,int tourId, int guideKnowledgeRating, int guideLanguageUsageRating, int contentRating, string personalComment, int tourGuideID)
        {
            this.guestId = guestId;
            this.tourId = tourId;
            this.guideKnowledgeRating = guideKnowledgeRating;
            this.guideLanguageUsageRating = guideLanguageUsageRating;
            this.contentRating = contentRating;
            this.personalComment = personalComment;
            this.tourGuideId = tourGuideID;
            this.valid = true;
        }
        public TourAndGuideRate() { }
    }
}
