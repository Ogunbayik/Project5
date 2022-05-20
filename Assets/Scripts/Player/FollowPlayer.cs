using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offsetPosition;
    [SerializeField] private Vector3 offsetRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        offsetPosition = new Vector3(0, 0, 0);
        offsetRotation = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offsetPosition;
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(offsetRotation);
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-offsetRotation);
        }
    }
}
