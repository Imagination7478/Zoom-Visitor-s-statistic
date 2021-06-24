

namespace Zoom_Visitor_s_statistic.Student
{
    public class Student
    {
        public string autorize(string url)
        {
            Authorization.Authorization Auth = new Authorization.Authorization();

            return (Auth.autorize(1, url));
        }
    }
}
