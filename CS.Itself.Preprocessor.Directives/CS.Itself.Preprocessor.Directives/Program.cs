#define Enterprise
#if Professional || Enterprise
#define Advanced
#endif

using System;

namespace CS.Itself.Preprocessor.Directives
{
#if Advanced
    class Enjoy
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
#endif


    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
            #warning Be carefull with debug options
                Console.WriteLine("DEBUG configuration");
            #else 
                Console.WriteLine("RELEASE configuration");
            #error Is not ready for deploy
            #endif

            #region Preprocessor If-End If
                #if Advanced
                            Enjoy enjoy = new Enjoy();
                            enjoy.Print("Advanced");

                #endif
            #endregion

            
        }
    }


    
}
