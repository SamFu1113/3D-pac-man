using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTime : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(logTime());
    }
    public ParticleSystem p;
    private IEnumerator logTime()
    {
        int step = 0;
        while (step < 1000)
        {
            print(Time.frameCount);
            //Debug.Log(Time.frameCount);
            step++;
            int n=10;
            //yield return new WaitForSeconds(n);
            

            yield return new WaitForSecondsRealtime(n);
            if(p.isPlaying){
                p.Stop();
            }
            

        }
    }
}
