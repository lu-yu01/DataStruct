using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region [敏感字符类]
public class SensitiveWorld : Dictionary<char, SensitiveWorld>
{
    public bool isLast = false;
    public SensitiveWorld AddNode(char word)
    {
        SensitiveWorld node;
        if (!TryGetValue(word, out node))
        {
            node = new SensitiveWorld();
            Add(word, node);
        }
        return node;
    }

    public SensitiveWorld GetNode(char word)
    {
        SensitiveWorld node;
        TryGetValue(word, out node);
        return node;
    }
}
#endregion

/// <summary>
/// 敏感字符串判断   博客原网址: https://connect.unity.com/p/shu-9xiwo
/// </summary>
public class SensitiveTest : MonoBehaviour {

    static SensitiveWorld sensitiveNodes = new SensitiveWorld();

    public static void InitSensitiveWorld(string world)
    {
        if (string.IsNullOrEmpty(world))
            return;
        Debug.Log("world0:" + world[0]);
        SensitiveWorld node = sensitiveNodes.AddNode(world[0]);   // key  对应的 value(node)
        for (int i = 1; i < world.Length; i++)
        {
            Debug.Log("world[i]:" + world[i]);
            node = node.AddNode(world[i]);
        }

        node.isLast = true;
    }

    public static bool CheckSensitiveWorld(string txt)
    {
        SensitiveWorld node = null;
        for (int i = 0; i < txt.Length; i++)
        {
            Debug.Log(i +":" + txt[i]);
            node = node == null ? sensitiveNodes.GetNode(txt[i]) : node.GetNode(txt[i]);   // 三目运算符  node =  a==b ?c:d  // true c    false d
            if (node != null && node.isLast)
            {
                Debug.LogFormat("node:{0} isLast:{1}", node, node.isLast);
                return true;
            }
           
        }
        return false;
    }

   
    void Start () {
        string[] sensitive = new string[] { "卧槽", "family", "cack", "deady", "recount" };
        string txt = "我卧槽你";
        for (int i = 0; i < sensitive.Length; i++)
        {
            InitSensitiveWorld(sensitive[i]);
        }

        if (CheckSensitiveWorld(txt))
            Debug.Log("{0}包含敏感词" + txt);
        else
            Debug.Log("{0}不包含敏感词"+ txt);
    }
	

}
