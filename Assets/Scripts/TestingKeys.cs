using UnityEngine;

public class TestingKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /**
         * MOUSE
         * 0: click izquierdo
         * 1: click derecho
         * 2: click central
         */
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Right click pressed");
        }
        if (Input.GetMouseButton(0)) {
            Debug.Log("Right click is pressing");
        }
        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("Right click released");
        }

        /**
         * KEYBOARD
         */
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space pressed");
        }
        if (Input.GetButtonDown("Jump")) {
            Debug.Log("Wop!");
        }

        /**
         * AXIS
         */
        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 a 1
        if (horizontal < 0f || horizontal > 0f) {
            Debug.Log("Horizontal Axis is " + horizontal);
        }
        if (vertical < 0f || vertical > 0f) {
            Debug.Log("Vertical Axis is " + vertical);
        }
    }
}
