using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_asa_shared_localization.Enums.ModuleWebsite.RecruitmentPost
{
    public enum RecruitmentApplicationKeys
    {
        NOT_FOUND,
        RECRUITMENT_POST_NOT_FOUND,
        RECRUITMENT_POST_EXPIRED,

        CANNOT_UPDATE_STATUS_REJECTED,
        CANNOT_CHANGE_REVIEWED_TO_PENDING,
        CANNOT_CHANGE_INTERVIEW_TO_REVIEWED_OR_PENDING,
        CANNOT_CHANGE_ACCEPTED_TO_PREVIOUS,
        INVALID_DATE_FUTURE_REQUIRED,
        INTERVIEW_DATE_REQUIRED,
        ACCEPTED_DATE_REQUIRED
    }

}
