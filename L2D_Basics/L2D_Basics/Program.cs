// Single line comment

/*
 * Multi-line comment
 */

/// <summary>
/// This is most commonly used to give a description of a method while also giving the Intellisense information to the programmer.
/// </summary>

/*
 * Software development specific words used:
 * 
 * Intellisense - This is a feature that assists the programmer find the API they are searching for. It will give a list of available members of
 *                a namespace or class, as well as all of the details for said member.
 * 
 * keyword - This is as it sounds. A keyword is a predefined, and reserved, identifier that is used by Visual Studio to compile the code.
 * 
 * namespace - A namespace is simply a collection of classes. They can be used in the code two ways. One way is to reference it with the
 *             "using" keyword, so that you don't need to do the other way: directly append it to the begining of the class, that you want to
 *             use. IE: System.Console.WriteLine("Text"); System (namespace) . Console (class) . WriteLine (method) "Text" (string variable passed)
 *             
 * class - A class holds all of the variables, methods, and a sort of "blueprint" that will be used in our software. This is also called
 *         an object. C# is an Object Oriented Programing (OOP) language. It's main features include the ability to create classes to be
 *         instantiated objects that are used by other objects.
 *         
 * instance - An instance is basically just a copy of a class. Each copy can hold it's own unique, different, or similar data to other instances.
 *            Other words are instantiating (creating an instance), instantiated (already created instance), ect
 *            
 * method - A method is a section, or block, of code that executes statments, calculations, or other types of data usage and manipulation. Every type
 *          of function, that a program computes, is contained in a method.
 *          
 * member - A class member is basically varibles, methods, or other types of structure that is declared inside of a class.
 *            
 * array - An array is a collection of variables.
 * 
 * string - A string is a class that references a specific type of data. In this case, generic text. I'll explain this more in a future episode.
 */

using System; // Here the program defaults to including the System namespace

namespace L2D_Basics // Here is our new namespace, created automatically based on what you named your project
{
    class Program // Our first class, automatically named "Program"
    {
        /// <summary>
        /// Here is our Main method, which the program defaults to execute on startup, of a new program.  This method is declared with the default "static"
        /// modifier, which allows it to be called from an external class without the need of instantiating it. The keyword static implies that the classes
        /// member will not be called via instance, but with a direct reference to the class and member. IE: Program.Main(args[])
        /// </summary>
        /// <param name="args">This method expects an array of string arguments.</param>
        static void Main(string[] args)
        {
            /*
             * The program's default first method call and function. This instruction tells the software to output the string "Hellow World!" to
             * the console, so that the user can read it. Console is a class and WriteLine is a method inside of that class. This specific method
             * requires a string to be included in it's call.
             */
            Console.WriteLine("Hello World!"); // Output text to the console

            /*
             * Compile and run the program, or click Debug -> Start Debugging or the green arrow, at the top of Visual Studio.
             * You'll notice that the output "Hello World!" is displayed and then the program exits immediately. This happens
             * because the program doesn't know that it should pause, in order to give the user an adequate amount of time to
             * read the output. Try adding Console.WriteLine("Press the enter key to exit"); Console.ReadLine(); and run the
             * program again. Now it will stop to wait for a keyboard input, and then exit.
             */

            Console.WriteLine("Press the enter key to exit");
            Console.ReadLine(); // The program pauses here, waiting for user input

            // Nothing else left to do, so the program exits
        }
    }
}