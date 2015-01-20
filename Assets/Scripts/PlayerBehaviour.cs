using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	public delegate void UpdateHealth ( int newHealth );
	public static event UpdateHealth onUpdateHealth;

	public string levelName = "GameOverScene";
	private int damage = 2;
	public int health = 100;
	public int blueKey = 0;
	public int pinkKey = 0;
	public Transform walkingTransform;

	private int score;
	private Animator anim;
	private Animator walkingAnim;
	private AudioSource walkingSound;

	void Start () {
		anim = GetComponent<Animator> ();
		walkingAnim = walkingTransform.GetComponent<Animator> ();
		walkingSound = walkingTransform.GetComponent<AudioSource> ();

		if (onUpdateHealth != null) {
						onUpdateHealth (health);
				}
	}
	

	void Update () {
		if (Input.GetMouseButton (0)) {
						anim.SetBool ("isFiring", true);
				} else {
						anim.SetBool ("isFiring", false);
				}

		if (rigidbody2D.velocity != Vector2.zero) {
						walkingAnim.SetBool ("isWalking", true);

						if (!walkingSound.isPlaying) {
								walkingSound.Play ();
								walkingSound.loop = true;
						}

				} else {
			walkingAnim.SetBool( "isWalking", false );

			if(walkingSound.isPlaying ){
				walkingSound.Stop();
				walkingSound.loop = false;
			}
	}
}
	public void TakeDamage( int damage ) {
		health -= damage;

		if( onUpdateHealth != null )
			onUpdateHealth( health );

		if(health <=0 ) {
			Application.LoadLevel (levelName);
			Die();
		}
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.CompareTag ("BlueKey")) {
			other.transform.SendMessage ("TakeDamage", damage);
			blueKey += 1;
		}
		if (other.gameObject.CompareTag ("PinkKey")) {
			other.transform.SendMessage ("TakeDamage", damage);
			pinkKey += 1;
		}

		if (other.gameObject.CompareTag ("BlueDoors")) {
			if (blueKey > 0)
			{
			other.transform.SendMessage ("TakeDamage", damage);
				blueKey -= 1;
			}
		}

		if (other.gameObject.CompareTag ("PinkDoors")) {
			other.transform.SendMessage ("TakeDamage", damage);
		}
		
	}

	void Die() {

	}

}
