using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inherit2 : baseClass
{
    
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
