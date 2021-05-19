using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 35;
public GameObject bullet; //small sphere
public Transform barrel;
   


public AudioSource audioSource;
public AudioClip audioClip;

  public void Fire(){
   // GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation * Quaternion.Euler(90,0,0));

        // z is forward
   GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation); 
  // Debug.Log(barrel.position + ":" + barrel.rotation);
  
    spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
    
    //spawnedBullet.GetComponent<Rigidbody>().addForce(barrel.forward*speed, ForceMode.Impulse);
    // different force modes; mass of rigidbody; all force at once for impulse, verses over time like pushing ball uphilll;
    //forcemode. acceleration; velocityChange-instant not continuous, doesn't take mass into consideration 
    audioSource.PlayOneShot(audioClip);
     Destroy(spawnedBullet, 4);
       
  // 
}

   

}
