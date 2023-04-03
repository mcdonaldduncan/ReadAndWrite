// See https://aka.ms/new-console-template for more information
using ReadAndWrite;

Console.WriteLine("Hello, World!");


Game game = new Game();

game.Initialize();
game.Display();

Console.ReadLine();


/*
 * Please Read!
 * 
 * This is an example of how to read files using a StreamReader in context of a game/inventory
 * Writing files is not included currently but will be added down the line, very similar to read process using StreamWriter
 * 
 * There are a few issues with this example project and it would need some improvements for actual use.
 * 
 * A couple major flaws that could/should be improved are:
 * 
 * Error reporting, right now we catch exceptions and make sure we don't crash for the most part but 
 * we do not communicate those errors to the user or developer, a very improtant step would be to add error reporting
 * 
 * Lots of hard coded values, when we build items, we hard coded the array indexes, 
 * this results in fragile and difficult to mantain code, other examples exist in the project
 * 
 * If you are serious about developing software professionally these could be great challenges to try out
 * that actually translate into code you will write in the real world
 * 
 * 
 * Author: Duncan McDonald
 * 
 * Academic integrity is giving credit to the ideas, research, and creations of others; and part of one’s education is learning how to give this credit. 
 * When a writer inserts a citation into their work, they are not only being honest about the source of their knowledge, 
 * but also making visible the ways in which their work depends on the support of others,
 * whether they are students or faculty members or thinkers and writers from distant times and places. 
 * 
 */