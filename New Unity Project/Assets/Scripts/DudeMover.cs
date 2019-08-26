using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeMover : MonoBehaviour
{
    public float speed;
    public float jumpForce = 10;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 pos = gameObject.transform.position;
        pos.x = pos.x + (speed * Time.deltaTime) * horizontal;
        gameObject.transform.position = pos;

        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump!");
            Rigidbody2D body = gameObject.GetComponent<Rigidbody2D>();
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            gameObject.transform.localScale = gameObject.transform.localScale * 2;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Destroy(gameObject);
        }
    }
}
