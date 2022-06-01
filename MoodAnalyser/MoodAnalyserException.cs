﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserException:Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOD, NULL_MOOD, NO_SUCH_CLASS, NO_SUCH_METHOD, NO_SUCH_FIELD
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
