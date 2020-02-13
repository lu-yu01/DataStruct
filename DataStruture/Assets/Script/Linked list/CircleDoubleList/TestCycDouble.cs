using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DataStruct;
public class TestCycDouble : MonoBehaviour {

	// Use this for initialization
    private Button Prebtn;
    private Button NextBtn;
    private Node<int> node;

    void Start ()
	{
	    Prebtn = transform.Find("Previous").GetComponent<Button>();
	    NextBtn = transform.Find("Next").GetComponent<Button>();
	    Prebtn.onClick.AddListener(OnPrebtnListen);
	    NextBtn.onClick.AddListener(NextBtnListen);

	    CircleLink<int> circlelink = new CircleLink<int>();
	    for (int i = 0; i < 10; i++)
	    {
	        circlelink.AddElem(i*2);
        }
	    node =  circlelink.GetNode(1);
	    Debug.Log("" + node.Data);
    }

    public void OnPrebtnListen()
    {
        node = node.PreNode;
        Debug.Log("" + node.Data);
    }
    public void NextBtnListen()
    {
        node = node.NextNode;
        Debug.Log("" + node.Data);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
