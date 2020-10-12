using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = this.direction.normalized * this.speed * Time.deltaTime;
        // this.transform.position = new Vector2(this.transform.position.x + movement.x, this.transform.position.y + movement.y);
        this.transform.Translate(movement);
    }
}
