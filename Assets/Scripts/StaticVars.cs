using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StaticVars : MonoBehaviour {

	public static List<GameObject> bullets;
	public static int spawnCount;
	public static int points;

	//public static List<Enemy> deadEnemies;

	// Use this for initialization
	void Start () {
		bullets = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
