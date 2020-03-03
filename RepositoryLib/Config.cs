using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLib
{
    class Config
    {
        public string IP { get { return this._ip; } }

        public Config()
        {
            _ip = "127.0.0.1";
        }

        public bool Initialize(string ip)
        {
            // todo check valid ip
            _ip = ip;

            return true;
        }

        private string _ip;
    }
}
