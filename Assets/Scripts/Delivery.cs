using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   Color hasPackageColour = new Color(1,0,0,1);
   Color noPackageColour = new Color(1,1,1,1);
   bool holdingPackage = false;
   float destroyDelay = 0.5f;

   SpriteRenderer spriteRenderer;

   void Start() {
      spriteRenderer = GetComponent<SpriteRenderer>();
   }
   private void OnCollisionEnter2D(Collision2D other) {
       Debug.Log("bumped into something");
   }

   private void OnTriggerEnter2D(Collider2D other) {
      // Debug.Log(other.name+"\t"+other.tag);
      if (other.tag == "Package" && !holdingPackage) {
         Debug.Log("this is a package you just hit");
         holdingPackage = true;
         spriteRenderer.color = hasPackageColour;
         Destroy(other.gameObject, destroyDelay);
      } else if (other.tag == "Customer" && holdingPackage) {
         Debug.Log("delivered package to customer");
         holdingPackage = false;
         spriteRenderer.color = noPackageColour;
      } else if (other.tag == "Customer" && !holdingPackage) {
         Debug.Log("came to a customer and you don't have a package");
      }
   }
}
