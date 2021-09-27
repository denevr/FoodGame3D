using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseController : MonoBehaviour
{
    private float rotationOffset;
    private Rigidbody _body;
    private float speed = 750;
    private Vector3 mousePositionOffset;
    private float selectionDistance = 0.0f;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.rotation.SetLookRotation(_body.velocity);
    }

    void FixedUpdate()
    {
        mousePositionOffset = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, selectionDistance));
        _body.velocity = (mousePositionOffset - _body.transform.position) * speed * Time.deltaTime;
    }
}
