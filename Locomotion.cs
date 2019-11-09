using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
  public GameObject player;
  public GameObject camera;
  public float timeLeft = 4.0f;
  public bool up=false;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

      float yRot = camera.transform.rotation.eulerAngles.y/180*Mathf.PI;
      float dis = 0.005f;

      float deltaX = Mathf.Sin(yRot)*dis;
      float deltaZ = Mathf.Cos(yRot)*dis;
    
      if(up){
        player.transform.position = new Vector3(player.transform.position.x+deltaX,player.transform.position.y+yRot,player.transform.position.z+deltaZ);
        timeLeft -= Time.deltaTime;
        if(timeLeft<=0)
          up=false;
      }
      if(!up){
        player.transform.position = new Vector3(player.transform.position.x-deltaX,player.transform.position.y-yRot,player.transform.position.z-deltaZ);
        timeLeft += Time.deltaTime;
        if(timeLeft>=4)
          up=true;
      }
        
            
            

  
        



    }
}
