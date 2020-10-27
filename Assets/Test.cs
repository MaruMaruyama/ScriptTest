using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
   {
       private int hp = 100; //体力
       private int power = 25;  // 攻撃力
       private int mp = 53; //MPの初期化と値の代入

       //攻撃用の関数
       public void attack()
       {
           Debug.Log(this.power + "のダメージを与えた");
       }

       //防御用の関数
       public void defence(int damage)
       {
           Debug.Log( damage+"のダメージを受けた");
           this.hp -= damage;
       }
        //発展課題で使用するMagic関数
       public void Magic(int numMp)
       {
            if(this.mp >= numMp){
               this.mp -= numMp;
               Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
　           }else{
               Debug.Log("MPが足りないため魔法が使えない。");
             }  
        }
   }
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //課題1　増加
        int[] array = {20,30,50,90,40};
        for (int i = 0; i < array.Length; i++){
            Debug.Log( array[i]);
        }
        //課題1　減少
        for (int i = array.Length - 1; i >= 0; i--){
            Debug.Log(array[i]);
        }
        //発展課題用 testboss インスタンスにボスクラスを入れています
        Boss testboss = new Boss();
        // 消費 MP を引数に入れています。11 回目にMPが足りなくなるのを確認
        for(int l = 0 ; l < 11 ; l++){
            testboss.Magic(5);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

