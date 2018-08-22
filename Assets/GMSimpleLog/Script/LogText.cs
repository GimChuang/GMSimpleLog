using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogText : MonoBehaviour {

    Text txt;

    void Awake()
    {
        txt = GetComponentInChildren<Text>();
    }

    void Start ()
    {
		
	}
	
	public void SetUp(Color _color, string _string)
    {
        txt.color = _color;
        txt.text = _string;
    }
}
