

namespace Zoom_Visitor_s_statistic.Student
{
    public class Student
    {
        public void autorize(string AccessCode, string url)
        {
            Authorization.Authorization Auth = new Authorization.Authorization();

            Auth.autorize(AccessCode, url);
        }
    }
}
