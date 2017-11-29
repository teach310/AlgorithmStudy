using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState{
	void OnUpdate ();
}

public class Smile : IState{
	public void OnUpdate ()
	{
		if(Input.GetKeyDown(KeyCode.T))
			Debug.Log ("にこにこ！");
	}
}

public class Angry : IState{
	public void OnUpdate(){
		if (Input.GetKeyDown (KeyCode.T))
			Debug.Log ("激おこ!!");
	}
}


public class Sad : IState{
	public void OnUpdate(){
		if (Input.GetKeyDown (KeyCode.T))
			Debug.Log ("泣いた．");
	}
}

public class CubyBehaviour : MonoBehaviour {

	List<IState> stateList = new List<IState>();
	IState currentState;

	void Awake(){
		stateList.Add (new Smile ());
		stateList.Add (new Angry ());
		stateList.Add (new Sad ());
	}

	void Update(){
	}


	void NextState(){
		//currentState
	}


}
