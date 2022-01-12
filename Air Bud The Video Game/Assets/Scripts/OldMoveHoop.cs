using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMoveHoop : MonoBehaviour
{
    Vector3 back = new Vector3(0, -7.78f, -7); //assign it whatever value you want one edge of the movement to be
    Vector3 forth = new Vector3(0, -7.78f, 7); //again, assign whatever the other edge is supposed to be
    float phase = 0;
    public float hoopSpeed; //adjust to anything that results in the speed u want
    float phaseDirection = 1; //this is just to make the code less "ify" =D
    private Rigidbody hoopRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        hoopRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hoopRigidbody.MovePosition(Vector3.Lerp(back, forth, phase)); //phase determines (in percent, basically) where on the line between the points "back" and "forth" you want the enemy to be placed, so if we gradually increase/decrease the variable, it makes the enemy move between those two points.
        phase += Time.deltaTime * hoopSpeed * phaseDirection; //subtracts from 1 to zero when phaseDirection is negative, adds from zero to one when phaseDirection is positive.
        if (phase >= 1 || phase <= 0) phaseDirection *= -1; //flip the sign to flip direction
    }
}
