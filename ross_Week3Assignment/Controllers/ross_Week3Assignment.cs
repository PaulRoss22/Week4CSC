using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ross_Week3Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainApi : ControllerBase
    {


        [HttpPost(Name = "Week3Assignment")]
        public ActionResult<List<String>> IntListWork(List<int> lint)
        {
            List<string> slist = new List<string>();
            double sum = 0;
            double counter = 0;
            double stddev = 0;
            double sumSq = 0;
            
            lint.Sort();
            try
            {
                foreach (int i in lint)
                {
                    if (counter <= 0)
                    {
                        counter++;
                        sum += i;
                        sumSq += i * i;
                        stddev = Math.Sqrt((sumSq - sum * sum / counter) / (counter - 1));

                        slist.Add("List too small");
                        System.Console.WriteLine(LogObject(i));

                    }
                    else
                    {
                        counter++;
                        sum += i;
                        sumSq += i * i;
                        stddev = Math.Sqrt((sumSq - sum * sum / counter) / (counter - 1));

                        slist.Add("Elements: " + counter + " Current Standard Deviation: " + stddev);

                        System.Console.WriteLine(LogObject(i));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Something went wrong.");
            }
            return Accepted(slist);
            
        }
        // 2nd commit 
        int LogObject(int slist)
        {
            return slist;
        }
    }
}