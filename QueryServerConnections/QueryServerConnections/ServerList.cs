using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryServerConnections
{
    class ServerList
    {

        public static List<String> GetServers() 
        {
            List<String> serverList = new List<string>(){ 
                
                "LM-SQL2008.dev.local", 
                "LM-SQL2012.dev.local", 
                "LM-middletier.dev.local",
                "productdev.adastra.co.uk",
                "LM-Manual.dev.local",
                "LM-Manual2.dev.local",
                "dev-build.dev.local",
                "dev-iis.adastra.co.uk",
            };
            
            return serverList;
        }
    }
};


