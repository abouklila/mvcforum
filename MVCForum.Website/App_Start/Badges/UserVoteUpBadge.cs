﻿using MVCForum.Domain.DomainModel;
using MVCForum.Domain.DomainModel.Attributes;
using MVCForum.Domain.Interfaces.API;
using MVCForum.Domain.Interfaces.Badges;

namespace MVCForum.Website.Badges
{
    [Id("c9913ee2-b8e0-4543-8930-c723497ee65c")]
    [Name("UserVoteUp")]
    [DisplayName("Badge.UserVoteUpBadge.Name")]
    [Description("Badge.UserVoteUpBadge.Desc")]
    [Image("UserVoteUpBadge.png")]
    [AwardsPoints(2)]
    public class UserVoteUpBadge : IVoteUpBadge
    {
        public bool Rule(MembershipUser user, IMVCForumAPI api)
        {
            return user.Votes != null && user.Votes.Count >= 1;
        }
    }
}