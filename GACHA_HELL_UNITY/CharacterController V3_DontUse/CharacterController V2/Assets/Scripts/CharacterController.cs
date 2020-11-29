using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float thrust = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        rb2D.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);
            this.GetComponent<Animator>().SetTrigger("Running Animation");
        }

    }
}
