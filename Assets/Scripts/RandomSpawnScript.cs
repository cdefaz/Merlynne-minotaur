using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour {

    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5
        ;

    public float spawnRate = 2f;

    float nextSpawn = 10f;

    int whatToSpawn;
    
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1,6);
            Debug.Log (whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
                    var myNewSmoke = Instantiate(prefab1, transform.position, Quaternion.identity);
                    myNewSmoke.transform.parent = gameObject.transform;
                    break;

                case 2:
                    var myNewSmoke2 = Instantiate(prefab2, transform.position, Quaternion.identity);
                    myNewSmoke2.transform.parent = gameObject.transform;
                    break;

                case 3:
                    var myNewSmoke3 = Instantiate(prefab3, transform.position, Quaternion.identity);
                    myNewSmoke3.transform.parent = gameObject.transform;
                    break;

                case 4:
                    var myNewSmoke4 = Instantiate(prefab4, transform.position, Quaternion.identity);
                    myNewSmoke4.transform.parent = gameObject.transform;
                    break;

                case 5:
                    var myNewSmoke5 = Instantiate(prefab5, transform.position, Quaternion.identity);
                    myNewSmoke5.transform.parent = gameObject.transform;
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
		
	}
}
