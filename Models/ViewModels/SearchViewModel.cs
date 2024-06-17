using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.SocialNetwork.Models.ViewModels
{
    public class SearchViewModel
    {
        public List<UserWithFriendExt> UserList { get; set; }

    }

}
