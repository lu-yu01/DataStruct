using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour
{
   
    void Start()
    {

        Stack st = new Stack();
        st.Push('A');
        st.Push('M');
        st.Push('G');
        st.Push('W');
        st.Push('V');
        st.Push('H');
        st.Pop();
        st.Pop();
        foreach (var s in st)
        {
            Debug.Log("st==" + s);
        }

  

    }



    
    void Update()
    {
        
    }
}
