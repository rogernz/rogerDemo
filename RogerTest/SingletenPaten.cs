using System;
using System.Collections.Generic;

namespace RogerTest
{
    public class SingletenPaten
    {
        public SingletenPaten()
        {
        }
    }

    public class Server
    {
        public string name{ set;get; }
        public int id { set; get; }
    }

    public sealed class LoadBalance
    {
        private List<Server> serverList = new List<Server>();
        Random random = new Random();

        protected LoadBalance()
        {
            serverList.Add(new Server() { id = 1,name="server1" } );
            serverList.Add(new Server() { id = 2, name = "server2" });
            serverList.Add(new Server() { id = 3, name = "server3" });
            serverList.Add(new Server() { id = 4, name = "server4" });
            serverList.Add(new Server() { id = 5, name = "server5" });
        }

        private static readonly LoadBalance _Instance = new LoadBalance();

        public static LoadBalance getInstance() {
            return _Instance;
        }

        public Server GetNextServer {
            get
            {
                int i = random.Next(serverList.Count);
                return serverList[i];
            }

        }
    }

    public class CheckTheLoadBalance
    {


    }

}
