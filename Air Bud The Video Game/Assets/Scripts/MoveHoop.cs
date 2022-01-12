using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHoop : MonoBehaviour
{
    private GameManager gameManager;
    public float hoopSpeed;
    float startZ;
    public float distance = 14;
    float addZ;
    private Rigidbody hoopRigidbody;

    private void Start()
    {
        hoopRigidbody = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        startZ = hoopRigidbody.position.z;
        AddSpeed(0);
    }

    

    void FixedUpdate()
    {
        if (gameManager.isGameActive == true)
        {
            addZ = Mathf.PingPong(Time.time * hoopSpeed, distance);
            hoopRigidbody.MovePosition(new Vector3(hoopRigidbody.position.x, hoopRigidbody.position.y, startZ + addZ));
        }
    }

    public void AddSpeed(float speedToAdd)
    {
        hoopSpeed += speedToAdd;
    }
}
