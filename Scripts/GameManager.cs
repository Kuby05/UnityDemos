using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerController controller;
    public coinMech coinmech;
    public bool isGameEnds = false;
    public Text scoretext;
    public int actualscore=0;
    public GameObject menu;
    public Text lastscorevar;
    private string sonpuan = "Skorunuz : ";
    void Start()
    {
        controller = FindObjectOfType<PlayerController>();
        coinmech = FindObjectOfType<coinMech>();
        
        
    }
    public void RespawnPlayer()
    {
        if (isGameEnds == false) { 
            isGameEnds = true;
        StartCoroutine(RespawnCoroutine());
        }
    }

    public IEnumerator RespawnCoroutine()
    {
        controller.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        //controller.transform.position = controller.spawnpoint;
       // controller.gameObject.SetActive(true);
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameEnds = false;

    }
    public void AddScore(int numberofscore)
    {
        actualscore += numberofscore;
        scoretext.text = actualscore.ToString();
        
    }
    public void LevelUp()
    {
        menu.SetActive(true);
        lastscorevar.text = sonpuan + scoretext.text;
        Invoke("NextScene", 2f);
        

    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    private void Update()
    {
        OpenMenu();
    }
    public void OpenMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        }
}
