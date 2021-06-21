
namespace Zoom_Visitor_s_statistic.Teacher
{
    public class Teacher
    {

        public void autorize(string AccessCode, string url)
        {
            Authorization.Authorization Auth = new Authorization.Authorization();

            Auth.autorize(AccessCode, url);
        }
    }

    
}
