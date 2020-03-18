using UnityEngine;
using System.Collections;

public class SR3 : MonoBehaviour {

	public Vector3 pos;
	public int index;
	public string color;
	public Vector3 initialPos;
	void Start () {
		initialPos=transform.position;
		pos=initialPos;
		index=-1;
		color="Red";
	}
	
	void Update () {
		this.GetComponent<Rigidbody>().MovePosition(pos);
	}
	
	public void ChangePosition(Vector3 p){
		var y = this.transform.position.y ;
		pos=p;
		pos.y=y;
	}
}
