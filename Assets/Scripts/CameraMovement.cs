using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform objetivo;
    public float suave;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != objetivo.position)
        {
            Vector3 posicionObjetivo = new Vector3(objetivo.position.x, objetivo.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suave);
        }
    }
}
