using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject banana;// 発射する弾
    public float bulletSpeed = 500;// 弾のスピード
    private Vector3 force;// 弾を飛ばす力の変数
    private Vector3 force2;
    AudioSource audioSource;
    public AudioClip SE1;

    public Animator GorillaAnim;
    //public static float PerlinNoise(float x, float y);

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))// もし、左クリックされたら、
        // if(Input.GetKey(KeyCode.Space))
        {
            GorillaAnim.SetBool("Shot",true);
            audioSource.PlayOneShot(SE1);
            GameObject bullets = Instantiate(banana) as GameObject;// bulletを作成し、作成したものはbulletsとする
            bullets.transform.position = this.transform.position;// bulletsをプレイヤーの場所に移動させる
            force = this.gameObject.transform.forward * bulletSpeed;// forceに前方への力を代入する
            force2 = this.gameObject.transform.up * bulletSpeed * 0.1f;
            bullets.GetComponent<Rigidbody>().AddForce(force);// bulletsにforceの分だけ力をかける
            bullets.GetComponent<Rigidbody>().AddForce(force2);
            Destroy(bullets.gameObject, 4);// 作成されてから4秒後に消す
        }
    }
}
