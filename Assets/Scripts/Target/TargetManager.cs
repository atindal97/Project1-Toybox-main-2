using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public MovingTarget prefab = null;

    public int totalTargets = 5;

    public Transform minX = null;
    public Transform maxX = null;
    public Transform minZ = null;
    public Transform maxZ = null;

    // Start is called before the first frame update
    void Start()
    {
        /*
        for(int i = 0; i < totalTargets; i++)
        {
            MovingTarget copy = Instantiate(prefab);
            copy.SetTargets(minX, maxX);
           float randomX = Random.Range(minX.position.x, maxX.position.x);
            copy.SetTargets(minZ, maxZ);
            float randomZ = Random.Range(minZ.position.z, maxZ.position.z);
            copy.transform.position = new Vector3(randomX, copy.transform.position.y, randomZ) ;

            copy.gameObject.SetActive(true);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
