using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class Boss{
       private int hp = 100; //体力
       private int power = 25;  // 攻撃力

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
   }

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.attack();
        lastboss.defence(3);

        Boss midboss = new Boss();
        midboss.attack();
        midboss.defence(20);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
