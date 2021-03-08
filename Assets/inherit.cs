using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inherit : baseClass
{
    // Start is called before the first frame update
   

    public override void UseItem()
	{
		base.UseItem();
		Debug.Log("Put things here");
	}
 private void OnMouseDown()
	{
	     UseItem();
         
	}
	
}
