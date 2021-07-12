using System;
using System.Net;
using System.Linq;

namespace HostNameInfoAPI.Models
{
    public class HostNameInfoModel
    {
        public DateTime date {get; set;}
        public string time {get; set;}

        public string hostName {get;set;}
        public string ip{get;set;}
        public string timeZone{get;set;}

        public HostNameInfoModel GetHostNameInfo()
        {
            var hostInfo = new HostNameInfoModel{

                hostName = Dns.GetHostName(),
                date = DateTime.Now.Date,
                time = DateTime.Now.ToString("h:mm:ss tt"),                                
            };
            var localZone = TimeZoneInfo.Local;            
            var host=  Dns.GetHostEntry(Dns.GetHostName());
            var ips =  host.AddressList;
            hostInfo.ip = ips.Where(h => h.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault().ToString(); ;            
            hostInfo.timeZone= localZone.DisplayName;
            return hostInfo;
        }
    }
}