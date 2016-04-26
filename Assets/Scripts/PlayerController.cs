using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float velocity;
	public Rigidbody2D rb;
	public Vector2 position;
	public float moveSpeed;
	public Vector2 screenSize;
	public List<GameObject> bullets;
	int bulletNum;
	public int bulletMax;
	public float shotTimer;

	public Transform shotSpawner;
	public GameObject shot;

	public float spawnTimer;
	public float attackTimer;

	public void Start()
	{
		Vector3 movement = new Vector3 (0.0f, 0.0f, 0.0f);
		rb = GetComponent<Rigidbody2D> ();
		position = rb.position;
		attackTimer = 1;
		bulletNum = 0;


	}

	public void FixedUpdate()
	{

		spawnTimer += Time.deltaTime;
		attackTimer += Time.deltaTime;

		if (Input.GetKey (KeyCode.W) ||Input.GetKey(KeyCode.UpArrow))
		{
			rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
			print ("Up");
		}
			 
			if (Input.GetKey (KeyCode.S)) {
				rb.velocity = new Vector2(rb.velocity.x, -moveSpeed);
				print ("Down");
			}
			

		// Move Right
		if(Input.GetKey(KeyCode.D)){
			rb.velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			print ("Right");
		}

		// Move Left
		if(Input.GetKey(KeyCode.A) ){
			rb.velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			print ("Left");
		}

		if (Input.GetKey (KeyCode.Space) && (attackTimer>shotTimer)) 
		{
			if (bulletNum < bulletMax) {
				bulletNum++;
				attackTimer = 0;
				Instantiate (shot, shotSpawner.position, shotSpawner.rotation);
				bullets.Add (shot);
			} else {
				StaticVars.bullets = new List<GameObject>();
				bulletNum++;
				attackTimer = 0;
				Instantiate (shot, shotSpawner.position, shotSpawner.rotation);
				bullets.Add (shot);
			}
			
		}

	}

}
