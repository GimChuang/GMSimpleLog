using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GMLogSystem;

public class Test : MonoBehaviour {

    public LogTextObjectPool thePool;

    public int increase;

    void Awake()
    {
        // This method must be called in Awake()
        LogTextSpawner.SetUpSpawner(thePool);
    }

    void Start () {
		
	}
	
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            increase++;
            LogTextSpawner.Log("Hi " + increase.ToString());
        }
        else if (Input.GetMouseButtonDown(1))
        {
            increase++;
            LogTextSpawner.LogWarning("Warn " + increase.ToString());
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            increase++;
            LogTextSpawner.LogError("Error " + increase.ToString());
        }
    }
}
