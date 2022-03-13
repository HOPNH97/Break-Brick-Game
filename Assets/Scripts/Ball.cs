using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float force = 100f;
    bool isPlaying = false;
    Vector3 firstPos;

    int count;

    GameController gameController;
    void Start()
    {
        firstPos = transform.localPosition;
        //Debug.LogFormat(firstPos.ToString());
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            return;
        }
        if (Input.GetButton("Fire1"))
        {
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().AddForce(force, 0, force);
            isPlaying = true;
        }
        count = GameObject.FindGameObjectsWithTag("Brick").Length;
        Debug.Log(count);
        if (count == 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    void ResetBall()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        transform.localPosition = new Vector3(0, 0, firstPos.z);
        isPlaying = false;
    }
    private void OnTriggerEnter()
    {
        //Destroy(this.gameObject);
        ResetBall();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            gameController.IncreasePoint();
            Destroy(collision.gameObject);
        }
    }
}
