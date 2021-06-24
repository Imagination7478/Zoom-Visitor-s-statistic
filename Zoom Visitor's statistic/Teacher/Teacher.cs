
namespace Zoom_Visitor_s_statistic.Teacher
{
    public class Teacher
    {

        public string autorize(string url)
        {
            Authorization.Authorization Auth = new Authorization.Authorization();

            return (Auth.autorize(0, url));
        }
    }

    
}
