using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    bool birdAlive;


    public LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        birdAlive = true;
        logicScript = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logicScript.gameOver();
    }
}
