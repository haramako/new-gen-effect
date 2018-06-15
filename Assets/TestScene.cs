using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour {

	public MotionManager MotionManager;

	public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
			MotionManager.PlayMotion(new MotionParam());
        }
    }

}
