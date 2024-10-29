//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.Xml.Linq;
//linqToXml.cs

namespace Linqtoxml
{
    internal class Program
    {


        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("C:\\xmlfile.xml");
            var countries = from country in xdoc.Descendants("countries").Elements("country").Attributes("name")
                            select country.Value;
            //ddlCountry.DataSource = countries;
            //ddlCountry.DataBind();
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }

}
