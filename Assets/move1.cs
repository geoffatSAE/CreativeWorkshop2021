using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour {

	public Transform[] positions;

	public enum PositionsAt { one, two, three} ;
	PositionsAt positionsAt;

	public float timeToMove;

	bool calledMove;//, 


	// Use this for initialization
	void Start () {
		//iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(5, 0, 0), "islocal", true, "time", 1.0f, "easetype", "linear"));

		iTween.MoveTo (gameObject, new Vector3 (-5, 0, 0), 2.0f);
	}
	
	// Update is called once per frame
	void Update () {

		switch (positionsAt) {

		case PositionsAt.one:

			if (calledMove == false) {
				iTween.MoveTo (gameObject, positions [0].position, timeToMove);
				calledMove = true;
			}

			if (Vector3.Distance (transform.position, positions [0].position) < 0.1) {
				positionsAt = PositionsAt.two;
				calledMove = false;
			}


			break;

		case PositionsAt.two:
			if (calledMove == false) {
				iTween.MoveTo (gameObject, positions [1].position, timeToMove);
				calledMove = true;
			}

			if (Vector3.Distance (transform.position, positions [1].position) < 0.1) {
				positionsAt = PositionsAt.three;
				calledMove = false;

			}


			break;

		case PositionsAt.three:


			if (calledMove == false) {
				iTween.MoveTo (gameObject, positions [2].position, timeToMove);
				calledMove = true;
			}

			if (Vector3.Distance (transform.position, positions [2].position) < 0.1) {
				Debug.Log ("we have arrived");
					positionsAt = PositionsAt.one;
					calledMove = false;
				}


			break;


		}

	}
}
