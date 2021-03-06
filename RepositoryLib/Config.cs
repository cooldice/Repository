﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLib
{
    public class Config
    {
        static public string IP { get { return _ip; } }

        static public string RootPath { get { return _rootPath; } }

        static Config()
        {
        }

        static public bool Initialize(string ip, string rootPath)
        {
            // todo check valid ip
            _ip = ip;
            _rootPath = @"\\" + ip + @"\" + rootPath;

            return true;
        }

        static private string _ip = "";
        static private string _rootPath = "";
    }
}
