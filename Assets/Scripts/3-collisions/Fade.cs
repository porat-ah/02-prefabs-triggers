using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
   private float alpha = 5f;
   SpriteRenderer objectSprite ;
    Color originalColor;

    void Start()
    {
        objectSprite = GetComponent<SpriteRenderer>();
        originalColor = objectSprite.color;
        setAlpha(0f);
    }
   public void setAlpha(float i)
   {
        Color newColor = originalColor;
        newColor.a =  i / alpha;
        objectSprite.color = newColor;
   }

}
