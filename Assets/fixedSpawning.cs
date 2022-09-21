using UnityEngine;
public class fixedSpawning : MonoBehaviour {
	 public GameObject sphereSmall;
	 public GameObject Cube;
	 public float distanceFromPlayer = 1.53f;
	 public float heightOfSpawn = 8.2f;
	
	 void Update () {
		 Vector3 spawningTheSphere;
		 spawningTheSphere.z = 1.53f;
		 spawningTheSphere.y = 8.2f;
		 if (Input.GetKeyDown(KeyCode.Space)){
			 spawningTheSphere.x = Random.Range(-5.0f, 5.0f);
			 Instantiate(sphereSmall, spawningTheSphere, Quaternion.identity);
		 }
	 }
}