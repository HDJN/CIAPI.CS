﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Common.Logging
{
    public class LogManager
    {
        public static ILog GetLogger(Type type)
        {
            return new NullLogger();
        }
    }
}