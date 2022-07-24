using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rigidbody2D;

    public float jumpPower;

    public BirdJump(Rigidbody2D rigidbody2D)
    {
        _rigidbody2D = rigidbody2D;
    }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _rigidbody2D.velocity = Vector2.up * jumpPower; // (0,1)
        }
    }
}