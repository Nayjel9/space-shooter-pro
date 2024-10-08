using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int _enemyspeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _enemyspeed * Time.deltaTime);

        if (transform.position.y <= -5.4f)
        {
            float randomX = Random.Range(-9.46f, 9.46f);
            transform.position = new Vector3(randomX, 7f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                player.Damage();
            }
            Destroy(this.gameObject);
        }

        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
