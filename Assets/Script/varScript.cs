using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class varScript : MonoBehaviour
{

    /*
     註解說明:

    
        // ---->    單行註解


        /* * /-----> 在範圍內註解


        /// ------>     給類別或方法 下註解  滑鼠移到類別 或方法時 會出現 註解內容
     
     
     */
    //---------------------------------------------------------------------

    /// <summary>
    /// 整數 ,超出最大範圍時 會重負值 加回來  （-2147483647~2147483647）
    /// </summary>
    public int i;

    /// <summary>
    /// 
    /// </summary>
    public long l;


    /// <summary>
    /// 小數 給值需加上f
    /// </summary>
    public float f;

    /// <summary>
    /// 字串 給值需加上 “”
    /// </summary>
    public string s;

    /// <summary>
    /// 布林 象徵 True or False 兩種狀態
    /// </summary>
    public bool b;


    /*
     程式碼第一次執行的地方 (只會執行一次)
     */
    void Start()
    {


        Debug.Log("Start");

        i = 10;

        Debug.Log(int.MaxValue);

        f = 0.87f;
        b = true;
        s = "哈哈";


        Debug.Log($" i:{i},f:{f},s:{s},b:{b}");

    }

    // Start執行完成之後 ,Update重複循環執行 (每禎執行一次)
    void Update()
    {
        Debug.Log("Update");
    }



}
