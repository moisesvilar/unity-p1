using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject shooter;
    private Transform _firePoint;

    private void Awake() {
        this._firePoint = this.transform.Find("FirePoint");
    }

    // Start is called before the first frame update
    void Start() {
        Invoke("Shoot", 1f);
        Invoke("Shoot", 2f);
        Invoke("Shoot", 3f);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void Shoot() {
        if (this.bulletPrefab != null && this.shooter != null && this._firePoint != null) {
            GameObject myBullet = Instantiate(this.bulletPrefab, this._firePoint.position, Quaternion.identity) as GameObject;
            Bullet bulletComponent = myBullet.GetComponent<Bullet>();
            if (this.shooter.transform.localScale.x < 0f) {
                bulletComponent.direction = Vector2.left;
            }
            else {
                bulletComponent.direction = Vector2.right;
            }
        }
    }
}
