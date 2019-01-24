using UnityEngine;

public class moveP2 : MonoBehaviour
{

    public Rigidbody rb;
	
    public float forwardForce = 8000f;
	public float sideForce = 120f;

    void FixedUpdate()
    {
		//note: the three variables of addForce do not directly refer to speed.
        rb.AddForce(0, 0, forwardForce, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //note: using fixedUpdate to read input could cause delay
            rb.AddForce(sideForce, 0, 0, ForceMode.VelocityChange);
			// Debug.Log(force);	
		}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce, 0, 0, ForceMode.VelocityChange);
			// Debug.Log(force);		
		}
    }

}
