using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;
    public float livingTime = 3f;
    public Color initialColor = Color.white;
    public Color finalColor;

    private SpriteRenderer _renderer;
    private float _startingTime;

    void Awake() {
        this._renderer = this.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this._startingTime = Time.time;
        Destroy(this.gameObject, this.livingTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = this.direction.normalized * this.speed * Time.deltaTime;
        // this.transform.position = new Vector2(this.transform.position.x + movement.x, this.transform.position.y + movement.y);
        this.transform.Translate(movement);

        float _timeSinceStarted = Time.time - this._startingTime;
        float _percentageCompleted = _timeSinceStarted / this.livingTime;
        this._renderer.color = Color.Lerp(this.initialColor, this.finalColor, _percentageCompleted);
    }
}
