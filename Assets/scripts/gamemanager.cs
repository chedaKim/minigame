using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject Square;
    public GameObject gameoverTxt;
    public GameObject Replay;

    public Text timeTxt;
    float alive = 0.0f;

    public static gamemanager I;

    public Animator Anim;
    public GameObject Circle;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.3f);
        initGame();
    }

    void initGame()
    {

    }

    void makeSquare()
    {
        Instantiate(Square);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timeTxt.text = alive.ToString("N2");
        
    }

    public void gameover()
    {
        Anim.SetBool("isDie", true);
        gameoverTxt.SetActive(true);
        Invoke("dead", 0.05f);
        Replay.SetActive(true);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(Circle);
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
