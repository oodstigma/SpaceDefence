using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour
{
    public bool[] sides = new bool[] { true, true, true, true };
    private GameObject parent;

    private float magnetizeX;
    private float magnetizeY;
    private float nOffset = -1f;
    private float pOffset = 1f;

    

    void Start()
    {
        parent = gameObject.transform.parent.gameObject.transform.parent.gameObject;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GetPosition();
        SetPosition(other);
        DisableCollider();
        CreateMagnet WTF = new CreateMagnet();
        WTF.AttachMag(sides, other);
    }

    private void GetPosition()
    {
        Debug.Log("GetPosition");
        switch (this.name)
        {
            case "Left":
                magnetizeX = nOffset;
                magnetizeY = 0f;
                sides[0] = false;
                break;
            case "Down":
                magnetizeX = 0f;
                magnetizeY = nOffset;
                sides[1] = false;
                break;
            case "Right":
                magnetizeX = pOffset;
                magnetizeY = 0f;
                sides[2] = false;
                break;
            case "Up":
                magnetizeX = 0f;
                magnetizeY = pOffset;
                sides[3] = false;
                break;
        }
    }

    private void DisableCollider()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    private void SetPosition(Collider2D other)
    {
        other.transform.parent = parent.gameObject.transform;
        Vector2 newPos = new Vector2(magnetizeX, magnetizeY);
        other.transform.localPosition = Vector2.zero;
        other.transform.localPosition = newPos;
    }
}


