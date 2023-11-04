using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnColllisionEnter2D(Collision2D collision)
   {
        if (collision.gameObject.name == "Circle")
        {
            Debug.Log("enter");
        }
   }
   private void OnColllisionStayD(Collision2D collision)
   {
        if (collision.gameObject.name == "Circle")
        {
            Debug.Log("stay");
        }
   }
   private void OnColllisionExit2D(Collision2D collision)
   {
        if (collision.gameObject.name == "Circle")
        {
            Debug.Log("exit");
        }
   }
}
