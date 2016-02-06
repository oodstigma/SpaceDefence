using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour
{

    public GameObject parent;

   private float magnetizeX;
    private float magnetizeY;

    /*void Start()
    {
        parent = GetComponentInParent<GameObject>();
        Debug.Log(parent.name);
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        GetPosition(other);
        Debug.Log(magnetizeX.ToString());
        Debug.Log(magnetizeY.ToString());
        other.transform.parent = parent.gameObject.transform;
        Vector2 newPos = new Vector2(magnetizeX + parent.transform.position.x, magnetizeY + parent.transform.position.y);
        other.transform.position = newPos;
       
    }

    public void GetPosition(Collider2D other)
    {
        Debug.Log("GetPosition");
        switch (other.name)
        { 
            case "Left":
                magnetizeX = -1.5f;
                magnetizeY = 0f;
                Debug.Log("Left");
                return;
            case "Down":
                magnetizeX = 0f;
                magnetizeY = -1.5f;
                Debug.Log("down");
                return;
            case "Right":
                magnetizeX = 1.5f;
                magnetizeY = 0f;
                Debug.Log("right");
                return;
            case "Up":
                magnetizeX = 0f;
                magnetizeY = 1.5f;
                Debug.Log("up");
                return;
        }
    }

}


