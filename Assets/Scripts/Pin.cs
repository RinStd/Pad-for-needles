using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float moveSpeed = 30f;
    public Rigidbody2D _rb;
    public bool isPinned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            _rb.MovePosition(_rb.position + Vector2.up * moveSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            collision.GetComponent<Rotator>().rotateDirection *= -1f;
            collision.GetComponent<Rotator>().rotateSpeed += 2f;
            Score.countPin++;
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
