using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetechCollision : MonoBehaviour
{
    public GameObject cube;
    public GameObject trap;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Trap"))
        {
            Debug.Log("Player collided with any Trap");
        }

       if(hit.gameObject.CompareTag("Panel"))
        {
            cube.SetActive(true);
            trap.SetActive(false);
        }
       
    }
}
