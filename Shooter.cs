using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Shooter : MonoBehaviour {

	// Reference to projectile prefab to shoot
	public GameObject projectile;
	public float power = 10.0f;

	public List<GameObject> bulletPool = new List<GameObject>();
	
	// Reference to AudioClip to play
	public AudioClip shootSFX;
	
	// Update is called once per frame
	void Update () {
		// Detect if fire button is pressed
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
		{	
			// if projectile is specified
			if (projectile)
			{
				

				if (bulletPool.Count==0)
                {
					// Instantiante projectile at the camera + 1 meter forward with camera rotation
					GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward,
						transform.rotation) as GameObject;

					// Apply force to the newProjectile's Rigidbody component if it has one
					newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * power,
						ForceMode.VelocityChange);
					// dynamically create a new gameObject with an AudioSource
					// this automatically destroys itself once the audio is done
					AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);
					
				
				}
                else
                {
					bulletPool[0].transform.position = transform.position + transform.forward;

					bulletPool[0].SetActive(true);//onEnable repeat again
					bulletPool[0].GetComponent<Rigidbody>().AddForce(transform.forward * power,
						ForceMode.VelocityChange);

					AudioSource.PlayClipAtPoint(shootSFX, bulletPool[0].transform.position);

					bulletPool.Remove(bulletPool[0]);//it will adding end again
					
				}


			}

		}
	}
}
