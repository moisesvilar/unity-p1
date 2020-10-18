using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour {

    public GameObject prefab;
    public Transform point;
    public float livingTime;
    public void Instantiate() {
        GameObject instantiatedObject = Object.Instantiate(this.prefab, this.point.position, Quaternion.identity) as GameObject;
        if (this.livingTime > 0f) {
            Object.Destroy(instantiatedObject, livingTime);
        }
    }
}
