using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    public Camera player1Camera;
    public Camera player2Camera;
    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("0"))
        {
            mainCamera.enabled = true;
            player1Camera.enabled = false;
            player2Camera.enabled = false;
			// Debug.Log("mainCamera is on");
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            mainCamera.enabled = false;
            player1Camera.enabled = true;
            player2Camera.enabled = false;
			// Debug.Log("player1camera is on");
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            mainCamera.enabled = false;
            player1Camera.enabled = false;
            player2Camera.enabled = true;
			// Debug.Log("player2camera is on");
        }


    }
}
