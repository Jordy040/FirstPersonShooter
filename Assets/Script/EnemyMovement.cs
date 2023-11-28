using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymovement : MonoBehaviour
{
    public NavMeshAgent badguy;

    public float squareofmovement = 20f;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

    private float xposition;
    private float yposition;
    private float zposition;

    public float closeEnough = 3f;
    // Start is called before the first frame update
    void Start()
    {
        xMin = zMin -squareofmovement;
        xMax = zMax = squareofmovement;
        
        newlocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xposition, yposition, zposition)) <= closeEnough)
        {
            newlocation();
        }                    
    }

    public void newlocation()
    {
        xposition = Random.Range(xMin, xMax);
        yposition = transform.position.y;
        zposition = Random.Range(zMin, zMax);

        badguy.SetDestination(new Vector3(xposition, yposition, zposition));
    }
}
