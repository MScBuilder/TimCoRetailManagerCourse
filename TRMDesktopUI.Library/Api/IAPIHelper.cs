using System.Threading.Tasks;
using TRMDesktopUI.Models;

namespace TRMDesktopUI.Library.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}