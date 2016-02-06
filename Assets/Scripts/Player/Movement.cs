using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 10f;

    private Vector3 mvVector3;
    private Rigidbody2D playerRigidbody;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        mvVector3.Set(h, v, 0f);


        mvVector3 = mvVector3.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + mvVector3);
    }
}
