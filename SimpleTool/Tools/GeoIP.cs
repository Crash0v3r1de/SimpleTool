using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleTool.Tools
{
    class GeoIP
    {
        public string GetCountry(string ipAddress)
        {
            string code;
            code = RegexCountry(new WebClient().DownloadString($"http://api.hostip.info/?ip={ipAddress}"));
            if (String.IsNullOrWhiteSpace(code))
            {
                return "Unknown";
            }
            else
            {
                return code;
            }
        }

        private string RegexCountry(string data)
        {
            string found;
            try
            {
                found = Regex.Match(data, "<countryAbbrev>(.*?)</countryAbbrev>").Groups[1].Value;
            }
            catch
            {
                found = null;
            }
            return found;
        }
    }
}
