using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;
public class DotMovement : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    Rigidbody2D rigidBody;
    Animator animator;
    SpriteRenderer puntico;
    CircleCollider2D colisionador;
    public LayerMask obstacleMask;
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        colisionador = GetComponent<CircleCollider2D>();
        puntico = GetComponent<SpriteRenderer>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = z;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        UpdateVelObs();
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
