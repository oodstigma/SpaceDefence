using UnityEngine;
using System.Collections;

public class CreateMagnet : MonoBehaviour
{
    public GameObject magnet;

    private string childName;
    private GameObject child;

    public void AttachMag(bool[] sides, Collider2D beingHit)
    {
        Instantiate(magnet);
        foreach (bool side in sides)
        {
            if (!side)
            {
                switch (beingHit.name)
                {
                    case "Left":
                        childName = "Right";
                        break;
                    case "Right":
                        childName = "Left";
                        break;
                    case "Up":
                        childName = "Down";
                        break;
                    case "Down":
                        childName = "Up";
                        break;
                }
            }
        }
        child = magnet.transform.FindChild(childName).gameObject;
        child.GetComponent<BoxCollider2D>().enabled = false;
    }
}

