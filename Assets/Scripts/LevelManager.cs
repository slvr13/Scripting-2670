using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

		public GameObject enemies;
		public Vector3 spawnValues;
		public float spawnTime;
		public int spawnMax;

		public GameObject[] enemyTypes;

		public enum enemyColor {Red, Green, Blue};
		//enemyColor  enemySpawnType;

		public void Start ()
		{
			StartCoroutine(WaitAndSpawn(0));
			
			
		}

	public void FixedUpdate ()
	{
		if (StaticVars.spawnCount < spawnMax) {
			StartCoroutine (WaitAndSpawn (spawnTime));
		}

	}

	IEnumerator WaitAndSpawn(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		print("WaitAndSpawn " + Time.time);
		int tempSpawnInt = Random.Range (1, 3);
			switch (tempSpawnInt)
		{
		case 1:
			//enemySpawnType = enemyColor.Red;
			enemies = enemyTypes [0];
			break;

			case 2:
			//enemySpawnType = enemyColor.Blue;
			enemies = enemyTypes [1];
			break;

			case 3:
			//enemySpawnType = enemyColor.Green;
			enemies = enemyTypes [2];
			break;
		}


		SpawnWaves ();
	}

		void SpawnWaves ()
		{
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (enemies, spawnPosition, spawnRotation);
			StaticVars.spawnCount++;
		}
}
