using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int lap = 0;
    float curLapProgress = 0f;
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeydown(KeyCode.Space))
        { 
            GainProgress(speed);
        } 
 
 }

public void Gainporgress (float progress)
  (
   {
        curLapProgress += progress;
        Debug.log("Gained " + Progress + " progress");
        Debug.Log("Total current progress is now: " + curLapProgress);
        CheckProgress(curLapProgress);
    }
     
    Pubic void CheckProgress(float progress)
    (
        if(progress >=)

        //completed a lap!
        LapCompleted();
        DEbug. Log("Reached the required amount of progress")  
    )  

  )  


Public void LapCompleted()

     (
        //update laps
        laps++; //or laps += 1;
        //update curprogress
        curLapProgress = 0f;
        //update reqProgress
        reqProgress += 1.15f
        //update speed - speed += 1.4f
        Debug.Log("Completed " + laps +" laps ");


     )


}