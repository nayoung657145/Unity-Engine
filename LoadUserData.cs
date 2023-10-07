using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadUserData : MonoBehaviour
{
    IEnumerator Start()
	{
		WWW itemsData = new WWW ("http://localhost/readUserData.php");
		yield return itemsData;
		string itemDataString = itemsData.text;
		print (itemDataString);
	}
}
