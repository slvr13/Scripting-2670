using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float speed;
	public Rigidbody2D rb;
	public float bulletTime;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.forward * speed;

	}
	
	void FixedUpdate () {

		rb.velocity = new Vector2(rb.velocity.x, speed);
		bulletTime += Time.deltaTime;
		if (bulletTime > 2) {
			Destroy (this.gameObject);
		}
			
	}

	void OnTriggerEnter(Collider other)
	{
		//if (other.gameObject.tag == "PlayerLaser") {
		StaticVars.spawnCount--;
		//StaticVars.points = StaticVars.points + enemyValue;
		print ("Anything");
		print (StaticVars.points);
		//}
	}
		
}
