using UnityEngine;
using System.Collections;

public class SB : MonoBehaviour {
	
	public Vector3 initialPos;
	public Vector3 pos;
	public int index;
	public bool isPug;
	public GameObject gameObj;
	public string color;
	
	void Start () {
		index=-1;
		isPug=false;
	}
	
	void Update () {
		
		GetComponent<Rigidbody>().freezeRotation = true;
		//pos.y=(float)0.05;
		Vector3 currentPosition = transform.position;
		Vector3 newPosition = Vector3.Lerp(currentPosition, pos, 0.5f);
		//this.GetComponent<Rigidbody>().MovePosition(pos);
		transform.position = newPosition;
	}
	
	public void ChangePosition(Vector3 p){
		pos=p;
	}
	
	public void ResetPosition(){
		index=-1;
		pos=initialPos;
	}
}
