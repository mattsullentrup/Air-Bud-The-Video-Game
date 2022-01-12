using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 4); // destroy particle after 2 seconds
    }
}
