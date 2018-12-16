using System;
using System.Collections;
using System.Text;

public class Robot
{
    // reset - tracks whether the name has been reset or not. 'first boot' is always treated as a reset state.
    // Have to have the string myName out of scope of 'Name', otherwise it gets reset every time Name is called.
    // Was stuck on this one for a while.
    int reset = 1;
    string myName = "";
    int robotCount = 0;
    ArrayList allRobots = new ArrayList();

    private

    public string Name
    {
        get
        {
            // Checks the state of the bot, if it's in reset state then grabs a new name,
            // and places it in the global variable myName. After setting the name, changes reset to 0,
            // to signal that it is no longer in a 'reset' state.
            // In short, if reset is 0, then it's not the first name call and thus shouldn't fetch a new name.
            if (reset == 1)
            {
                reset = 0;
                return myName = String.Copy(nameABot());
            }
            else
            {
                return myName;
            }
        }
    }

    

    public void Reset()
    {
        // Setting reset back to 1 means that 'Name' will have to fetch a new name.
        reset = 1;
    }
    private string nameABot()
    {
        // Easiest part of the exercise. Using ASCII table, fetches a character from A-Z and
        // adds it to the end of the robot's name. Does it twice for letters, thrice for numbers, to achieve
        // the desired 'combination'.
        StringBuilder robotName = new StringBuilder();
        Random _rndAlphaC = new Random();
        for (int i = 0; i < 2; i++)
        {
            robotName = robotName.Append((char)_rndAlphaC.Next(65, 90));
        }

        for (int i = 0; i < 3; i++)
        {
            robotName = robotName.Append(_rndAlphaC.Next(0, 9));
        }
        return robotName.ToString();
    }

}