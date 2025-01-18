﻿using Flashcards.Data;
using Flashcards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.UserInterface
{
    internal class StacksMenu
    {
        public static void DisplayManageStacksMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Manage Stacks Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            var stacksList = ManageStacks.GetListOfStacks();
            List<int> validStackIds = new List<int>(); // list containing ids of stacks that currently exist

            // get all the stacks and print the id and stack name 
            foreach (Stack stack in stacksList)
            {
                validStackIds.Add(stack.StackId);
                Console.WriteLine($"{stack.StackId}.{stack.StackName}");
            }
            Console.WriteLine("c.Create a Stack");
            Console.WriteLine("d.Delete a Stack");
            Console.WriteLine("0.Main Menu");
            Console.WriteLine("");
            Console.WriteLine("Choose a stack of flashcards to interact with. " +
                "You can also choose to create or delete a stack." +
                " Enter 0 to go back to the main menu.");

            // not working properly - fix *****************

            string? userChoice = Console.ReadLine();
            if (userChoice == "c")
            {
                // create a stack
            }
            else if (userChoice == "d")
            {
                // delete a stack
            }
            // this means a user entered a stack id otherwise show error
            else
            {
                int userChoiceAsInteger = 0;
                if (!int.TryParse(userChoice, out userChoiceAsInteger))
                {
                    Console.WriteLine("You entered invalid input. Please try again");
                }
                else // user input successfully converted to int. Now check if it is a valid stack id
                {
                    if (!validStackIds.Contains(userChoiceAsInteger))
                    {
                        Console.WriteLine("You entered invalid input. Please try again");
                    }
                    else // user entered valid stack id
                    {
                        StackMenu.DisplayStackMenu(userChoiceAsInteger);
                    }
                }

            }
           

        }
    }
}
