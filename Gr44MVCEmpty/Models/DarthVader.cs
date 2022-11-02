namespace Gr44MVCEmpty.Models
{
    public class DarthVader
    {
        public static string TestFever(double temp)
        {
            return(temp > 37)? "Doctor Vader says you have fever...have a cookie": "Doctor Vader says you don't have any fever...so no cookie";
        }
    }
}
