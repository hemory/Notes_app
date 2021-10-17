using System;
using System.Collections.Generic;

namespace NotesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Note> notes = new List<Note>
            {
                new Note("Whats up?", "Greet"),
                new Note("Goodbye", "Farewell")
            };
            
            while (true)
            {
                Console.Write("(1)Add Note (2)Edit Note (3)Delete Note (4)View Notes: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        while (userChoice != "q")
                        {
                            Note note = new Note(null, null);
                            
                            Console.Write("Enter Title: ");
                            note.Title = Console.ReadLine();
                    
                            Console.Write("Enter Message: ");
                            note.Message = Console.ReadLine();
                    
                            notes.Add(note);

                            Console.Write("Press [Enter] to add a new note or [Q] to exit");
                            userChoice = Console.ReadLine().ToLower();
                        }
                        break;
                
                    case "2":

                        bool isSuccessful = false;
                        while (isSuccessful == false)
                        {
                            Console.Write("Enter Title of Message to Edit: ");
                            string messageTitle = Console.ReadLine();

                            Console.Write("Enter New Message: ");
                            string newMessage = Console.ReadLine();
                        
                             isSuccessful = NotesAction.EditNote(messageTitle,notes,newMessage);

                            if (isSuccessful)
                            {
                                Console.WriteLine("Message has been updated.");
                            }
                            else
                            {
                                Console.WriteLine("Unsuccessful, please try again.");
                            }
                        }
                        break;
                
                    case "3":
                        isSuccessful = false;
                        while (isSuccessful == false)
                        {
                            Console.Write("Enter Title of Note to Remove: ");
                            string noteToRemove = Console.ReadLine();

                            isSuccessful = NotesAction.RemoveNote(noteToRemove, notes);
                        
                            if (isSuccessful)
                            {
                                Console.WriteLine("Message has been removed.");
                            }
                            else
                            {
                                Console.WriteLine("Unsuccessful, please try again.");
                            }
                        }
                        break;
                    case "4":
                        foreach (var singleNote in notes)
                        {
                            Console.WriteLine(singleNote.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection");
                        break;
                }

                
            }



        }
    }
}