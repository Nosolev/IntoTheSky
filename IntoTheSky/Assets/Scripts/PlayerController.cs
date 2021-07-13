using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float upSpeed;
    [SerializeField] private float step;
    private Vector3 nextPosition;
    private Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        nextPosition = transform.position;
    }
    void Update()
    {
        MoveUp();
    }
    private void MoveUp()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            nextPosition += new Vector3(0, step, 0);
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, upSpeed * Time.deltaTime);
    }
}
