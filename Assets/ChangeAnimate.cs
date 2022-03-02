using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
   public void getAnimatorHipHop(){
       this.GetComponent<Animator>().Play("Bboy Hip Hop Move");
   }

   public void getAnimatorSurprised(){
       this.GetComponent<Animator>().Play("Surprised");
   }

   public void getAnimatorRun(){
       this.GetComponent<Animator>().Play("Running Backward");
   }

   
}
