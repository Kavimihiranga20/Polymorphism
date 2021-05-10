using System;

namespace Consoleprg4
{
    class Program
    {
        static void Main(string[] args)
        {
            child child1 = new child();
            child1.voice();
        }

        class parent
        {

            public virtual void voice()
            {

                Console.WriteLine("Loud Voice");
            
            }
        
        }

        class child : parent
        {

            public override void voice()
            {
                Console.WriteLine("soft Voice");
            
            }
        
        }






    }
}
