using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyAttack : MonoBehaviour
{
    private Enemymovement enemyMovementScript;
    private Transform player;

    public float attackRange = 6f;

    public Material enemyDefault;
    public Material enemyAlert;
    public Renderer ren;

    private bool foundPlayer;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyMovementScript = GetComponent<Enemymovement>();
        ren = GetComponent<Renderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,player.position) <= attackRange)
        {
            ren.sharedMaterial = enemyAlert; // change material
            enemyMovementScript.badguy.SetDestination(player.position); //set destination to player position
            foundPlayer = true; // enable bool for chasing
        } else if (foundPlayer)
        {
            ren.sharedMaterial = enemyDefault; // set material back to default
            enemyMovementScript.newlocation(); // call new location function
            foundPlayer = false; // set bool back to false
        }
       
    }
}
