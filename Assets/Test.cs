using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   int Add(int a, int b, int c)
   {
       int d = a + b + c;
       return d;
   } 
    // Start is called before the first frame update
    void Start()
    {
        //戻り値cをnum にint 型として代入
        int num = Add(3,6,5);
        Debug.Log(num);
        　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
