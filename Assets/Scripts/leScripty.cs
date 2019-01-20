using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //player cosas

public class leScripty : MonoBehaviour
{
    public Vector3 myTranslate;
    public float leFloat;
    public float maximo = 0.05f;
    private Rigidbody rb;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((transform != null) && Input.GetKey("right"))
        {
            transform.Rotate(0, (float).75, 0);
        }

        if ((transform != null) && Input.GetKey("left"))
        {
            transform.Rotate(0, (float)-.75, 0);
        }

        if ((transform != null) && Input.GetKey("up"))
        {
            leFloat = Input.GetAxis("Vertical");
            myTranslate = new Vector3(0, 0, leFloat);
            // i divided maximo by 3 to slow movement of juegador
            transform.Translate(myTranslate*(maximo/3));

            Vector3 movement = new Vector3(0.0f, leFloat, 0.0f);

            rb.AddForce(movement);
        }
    }

    public void loadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("TRUCKER"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
