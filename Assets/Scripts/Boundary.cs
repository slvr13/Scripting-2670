using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "PlayerBullet") {
			print ("Bullet dead");
		}
	}

	void OnTrigger(Collider other)
	{
		print ("Touching Box");
	}

}
