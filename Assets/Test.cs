using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   int Add(int a, int b)
   {
       int ret;
       ret=a+b;
       return ret;
   } 
    // Start is called before the first frame update
    void Start()
    {
        int answer;
        answer= Add(5,7);
        Debug.Log(answer);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
