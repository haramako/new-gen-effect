using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionParam 
{
	public GameObject[] Targets;
}

[ExecuteInEditMode]
public class MotionManager : MonoBehaviour {

	public GameObject MainChar;
	public GameObject BlendTarget1;
	public GameObject BlendTarget2;
	public float Blend;

	Animator anim_;

	public void PlayMotion(MotionParam p)
	{
		anim_ = MainChar.GetComponent<Animator>();

		anim_.SetTrigger("Attack");
	}

	void LateUpdate()
	{
		Vector3 pos = BlendTarget1.transform.position;
		pos = Vector3.Lerp(pos, BlendTarget2.transform.position, Blend);

		MainChar.transform.position = pos;
	}
}
