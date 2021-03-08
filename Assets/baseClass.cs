using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseClass : MonoBehaviour
{
    public Text playerMessage;
    public Text Stats;
    private int Intake;
    private int Karma;
    public string Name;
    public int Calories;
	public int Karmas;
    public bool Alive; //Immortality
    public string Message;

    private void Awake()
    {
        Intake = 0;
        Karma = 0;
    }
    public void WriteMessage(string words)
    {
        playerMessage.text = words;
    }

    public void UpdateStats(int cals, int karm)
    {
        Intake += cals;
        Karma += karm;
        Stats.text = "Your caloric intake is " + Intake + " and your karma is " + Karma;
        if((Intake < -30)||(Karma < -20))
        {
            Stats.text = "You Died!";
        }
    }
    
    public virtual void UseItem()
	{
		//two lines below find a script called TellPlayer and call functions in it
		FindObjectOfType<baseClass>().WriteMessage(Message);
		FindObjectOfType<baseClass>().UpdateStats(Calories, Karmas);

	}
   
}
