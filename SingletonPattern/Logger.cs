﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._11sigleton
{
    public class Logger
    {
        private static Logger logger;
        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;

        }
    }
}