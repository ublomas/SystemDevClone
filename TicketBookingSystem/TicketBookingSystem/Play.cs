/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Play

{
   string title;
    string genre;
    string description; // include duration of play
    string date;
    string time;
    string ticketType;
    //have to use datetime function to switch from a string into a formatted datetime
    string ticketsAvailable;
    int ticketQuantity;

    // Might not need any full class variables if arguments are given in by the main. As this class doesn't create any objects with these varialbes, only pushes them between the code and database.
    


    //Unsure on what functionality can be implemented without a linked database being created before hand

    //public addPlay(string addTitle, string addDate)
    {
        //pseudocode
        ADD to database IN table Plays(addTitle, addDate, * Other variables*
    }

    public editPlay(string editTitle, string editDate)
    {
        //Unsure on how the edit will work. Will we force the user into editting the entire file or just certain lines.	
        //For example will this pull up the entire row for a certain play and the user edits it all and re inputs it.
        //Or will the user be able to simply specify what fields they want to alter within the ui and it becomes a replace rather than reinsert.
    }

    public deletePlay(string deleteTitle, string deleteDate)
    {
        DELETE ALL IN table Plays where Title = edit Title && where Date = editDate
		//May need more identifiers to prevent clashes
    }

    public displayReview(string readTitle, string readDate)
    {
        SELECT Reviews

        When Title = readTitle

        When Date = readDate

    from Plays

    //^^ closer to real sql rather than pseudo
    }


    //Using both the title and its date as an identifier 

}
*/