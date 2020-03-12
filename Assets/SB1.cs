using UnityEngine;
using System.Collections;

public class SB1 : MonoBehaviour {
	
	public Vector3 initialPos;
	public Vector3 pos;
	public int index;
	public string color;
	
	void Start () {
		initialPos=GameObject.Find("ib1").transform.position;
		pos=initialPos;
		index=-1;
		color="Blue";
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
