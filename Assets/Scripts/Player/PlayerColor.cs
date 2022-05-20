using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public SkinnedMeshRenderer[] playerSkinnedRenderer;
    [Space]

    public Color colorRed;
    public Color colorBlue;
    public Color colorYellow;
    public Color colorGreen;
    public Color currentColor;

    [SerializeField] private string _currentColor;
    // Start is called before the first frame update
    void Start()
    {
        currentColor = colorRed;
        _currentColor = "Red";
        for(int i=0; i < playerSkinnedRenderer.Length; i++)
        {
            playerSkinnedRenderer[i].material.color = currentColor;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SetPlayerColor();
        }
        
    }

    void SetPlayerColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = colorRed;
                _currentColor = "Red";
                for (int i = 0; i < playerSkinnedRenderer.Length; i++)
                {
                    playerSkinnedRenderer[i].material.color = currentColor;
                }   
                break;
            case 1:
                currentColor = colorYellow;
                _currentColor = "Yellow";
                for (int i = 0; i < playerSkinnedRenderer.Length; i++)
                {
                    playerSkinnedRenderer[i].material.color = colorYellow;
                } 
                break;
            case 2:
                currentColor = colorBlue;
                _currentColor = "Blue";
                for (int i = 0; i < playerSkinnedRenderer.Length; i++)
                {
                    playerSkinnedRenderer[i].material.color = colorBlue;
                } 
                break;
            case 3:
                currentColor = colorGreen;
                _currentColor = "Green";
                for (int i = 0; i < playerSkinnedRenderer.Length; i++)
                {
                    playerSkinnedRenderer[i].material.color = colorGreen;
                } 
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Untagged")
        {
            Debug.Log("Continue");
        }
        else if (other.gameObject.tag != _currentColor)
        {
            Debug.Log("Game is over");
        }
    }
}
