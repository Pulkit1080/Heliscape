using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Play;
    public GameObject Quit;
    public GameObject Player;
    public GameObject Retry;
    public GameObject Quit2;
    public GameObject player = GameObject.FindGameObjectWithTag("Player");
    public GameObject Controls;
    public void play()
    {
        Debug.Log("Start");
        Play.SetActive(false);
        Quit.SetActive(false);
        Player.SetActive(true);
        Controls.SetActive(false);
    }

    private void Update()
    {
        PlayerCheck();

    }
    void PlayerCheck()
    {
        if (Player == null)
        {
            Retry.SetActive(true);
            Quit2.SetActive(true);
        }
    }
}
