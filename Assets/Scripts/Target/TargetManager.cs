using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public MovingTargetZ prefab = null;

    public int totalTargets = 5;

    public Transform minX = null;
    public Transform maxX = null;

    

    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < totalTargets; i++)
        {
            MovingTargetZ copy = Instantiate(prefab);
            copy.SetTargets(minX, maxX);
           float randomX = Random.Range(minX.position.x, maxX.position.x);
            float randomZ = Random.Range(minX.position.z, maxX.position.z);
            copy.transform.position = new Vector3(randomX, copy.transform.position.y, randomZ) ;

            copy.gameObject.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
