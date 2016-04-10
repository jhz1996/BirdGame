

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class playerCam : MonoBehaviour
{
    private static playerCam mInstance;
    public static playerCam Instance
    {
        get { return mInstance; }

    }
    public SpriteRenderer targetSprite;
    // Use this for initialization
    void Start()
    {
        if (mInstance == null)
        {
            mInstance = this;
        }
    }

    // Update is called once per frame
    public void targetChosen(bool chosen)
    {
        if (chosen == true)
        {
            targetSprite.color = Color.white;

        }
        else
        {
            targetSprite.color = Color.red;

        }
    }
}

