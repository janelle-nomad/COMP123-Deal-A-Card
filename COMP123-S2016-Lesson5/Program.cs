﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Janelle Heron
 * 300839820    
 * "Deal a Card" Assignment 
 * <summary>
 * This is program simulates shuffling a deck
 * </summary>
 * Version 1.1: Fixed spelling mistakes  
 */
namespace COMP123_S2016_Lesson5
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         * @returns {void}
         */
        public static void Main(string[] args)
        {
            Deck deck = new Deck(); // create a deck of cards
            deck.Display(); // display the initial state of the deck

            deck.Shuffle(); // shuffle the deck
            /* The shuffle method, takes the card that's picked and removes it from the deck*/

            deck.Display(); // display the deck after shuffling

        } // end Main

    } // end Program

} // end namespace
