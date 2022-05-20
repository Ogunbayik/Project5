using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawWheel : MonoBehaviour
{
    public Transform midPoint;
    [Space]
    [Header("Whell Return Settings")]
    [SerializeField] private float returnTime;
    [SerializeField] private float returnLoop;
    [Space]

    [Header("Wheel Settings")]
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] Vector3 rotateAxis;
    [Range(100f,200f)]
    [SerializeField] private float rotateSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = 150f;
        returnLoop = returnTime;
    }

    // Update is called once per frame
    void Update()
    {
        WheelMovesAndRotate();
        transform.position += direction * speed *Time.deltaTime;

        returnTime -= Time.deltaTime;
        if(returnTime <= 0)
        {
            speed *= -1;
            returnTime = returnLoop;
        }
    }

    void WheelMovesAndRotate()
    {
        transform.RotateAround(midPoint.transform.position, rotateAxis, rotateSpeed * Time.deltaTime);
    }


}
