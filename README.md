# GradeBook

ACCESS MODIFIERS
----------------
public
The type or member can be accessed by any other code in the same assembly or another assembly that references it.

private
The type or member can be accessed only by code in the same class or struct.

protected
The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
internal
The type or member can be accessed by any code in the same assembly, but not from another assembly.

protected internal 
The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.

private protected 
The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.

STATIC KEYWORD
---------------
Cannot call the method via an object. 
Ex: 
namespace GradeBook
{
    Class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Main(args);    
            // This will not work as you cannot call Main via 'p' object.

            // Instead, do this...
            Program.Main
        }
    }
}
