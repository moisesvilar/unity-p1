using System.Collections;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {
	public float speed = 1f;
	public float minX;
	public float maxX;
	public float waitingTime = 2f;

	private GameObject _target;


	// Start is called before the first frame update
	void Start() {
		this.UpdateTarget();
		StartCoroutine("PatrolToTarget");
	}

	// Update is called once per frame
	void Update() {

	}


	private void UpdateTarget() {
		// If first time, create target in the left
		if (this._target == null) {
			this._target = new GameObject("Target");
			this._target.transform.position = new Vector2(this.minX, this.transform.position.y);
			this.transform.localScale = new Vector3(-1, 1, 1);
			return;
		}
		// If we are in the left, change target to the right
		if (this._target.transform.position.x == this.minX) {
			this._target.transform.position = new Vector2(this.maxX, this.transform.position.y);
			this.transform.localScale = new Vector3(1, 1, 1);
		}
		// If we are in the right, change target to the left
		else if (this._target.transform.position.x == this.maxX) {
			this._target.transform.position = new Vector2(this.minX, this.transform.position.y);
			this.transform.localScale = new Vector3(-1, 1, 1);
		}
	}

	private IEnumerator PatrolToTarget() {
		// Coroutine to move the enemy
		while (Vector2.Distance(this.transform.position, this._target.transform.position) > 0.05f) {
			// let's move to the target
			Vector2 direction = this._target.transform.position - this.transform.position;
			float xDirection = direction.x;
			this.transform.Translate(direction.normalized * speed * Time.deltaTime);
			// IMPORTANT
			yield return null;
		}

		// At this point, i've reached the target, let's set our position to the target's one
		Debug.Log("Target reached");
		this.transform.position = new Vector2(this._target.transform.position.x, this.transform.position.y);

		// And let's wait for a moment
		Debug.Log("Waiting for " + this.waitingTime + " seconds");
		yield return new WaitForSeconds(this.waitingTime); // IMPORTANT

		// once waited, let's restore the patrol behaviour
		Debug.Log("Waited enough, let's update the target and move again");
		this.UpdateTarget();
		StartCoroutine("PatrolToTarget");
	}
}
