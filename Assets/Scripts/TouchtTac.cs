using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchtTac : MonoBehaviour
{
    private float controlX=0.0f, controlY=-6.0f;
    private Rigidbody2D rb;
    Animator animator;
    SpriteRenderer puntico;
    CircleCollider2D colisionador;
    public LayerMask obstacleMask;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        colisionador = GetComponent<CircleCollider2D>();
        puntico = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    controlX = touchPos.x - transform.position.x;
                    controlY = touchPos.y - transform.position.y;
                    
                    break;
                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(touchPos.x - controlX, touchPos.y - controlY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity = Vector2.zero;
                    break;
            }
            UpdateVelObs();
        }

     
    }
    public void UpdateVelObs()
    {
        if (transform.position.y >= 5)
        {
            Globle.velPos = Globle.velIni + 0.26f;
            Globle.velMultiplier = 4;
        }
        else
        {
            if (transform.position.y < 5 && transform.position.y >= 0)
            {
                Globle.velPos = Globle.velIni + 0.22f;
                Globle.velMultiplier = 3;
            }
            else
            {
                if (transform.position.y < 0 && transform.position.y >= -5)
                {
                    Globle.velPos = Globle.velIni + 0.18f;
                    Globle.velMultiplier = 2;
                }
                else
                {
                    if (transform.position.y <= -5)
                    {
                        Globle.velPos = Globle.velIni + 0.14f;
                        Globle.velMultiplier = 1;
                    }
                }
            }
        }

    }
    public void restartGame()
    {
        SceneManager.LoadScene("Play");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            colisionador.enabled = false;
            Globle.isAlive = false;
            animator.SetBool("isDead", true);
            StartCoroutine(Wait());

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        //SceneManager.LoadScene("DeadScene");
        puntico.enabled = false;
        Globle.gameover = true;

    }
}
