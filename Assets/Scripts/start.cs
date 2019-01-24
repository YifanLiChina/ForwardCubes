using UnityEngine;

public class start : MonoBehaviour {

	public Rigidbody rb;
	public float sideForce;

	// Use this for initialization
	void Start () {
		rb.AddForce(sideForce, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
