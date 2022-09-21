using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
				void OnCollisionEnter(Collision col) 
    {
			scoreUpdated.scoreCount = scoreUpdated.scoreCount + 1;
            Destroy(col.gameObject);
			spawnObjects.check = 1;
			
        
}
	}

