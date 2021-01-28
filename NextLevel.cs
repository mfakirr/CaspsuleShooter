using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

    private void OnTriggerEnter(Collider newCollision)
    {
		if (newCollision.gameObject.tag == "Bullet")
		{
			// call the NextLevel function in the game manager
			GameManager.gm.NextLevel();
		}
	}
 
}
