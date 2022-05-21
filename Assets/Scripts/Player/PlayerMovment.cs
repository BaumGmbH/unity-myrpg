using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public new Rigidbody2D rigidbody;

    public float speed;
    public Vector2 moveToPos;

    // Update is called once per frame
    void Update()
    {
        moveToPos.x = transform.position.x + Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        moveToPos.y = transform.position.y + Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        rigidbody.MovePosition(moveToPos);
    }
}
