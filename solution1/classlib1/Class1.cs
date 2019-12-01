using System;

namespace classlib1
{
    public class Class1
    {
        public string Go(){
            #if NET472
             return "NET472";
            #else
             return ".NET Standard 2.0";
            #endif
        }
    }
}
