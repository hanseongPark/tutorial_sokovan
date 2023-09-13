using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<ItemBox> itemBoxes;
    public bool isGameOver;

    public GameObject winUI;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }

        if (isGameOver == true)
        {
            return;
        }

        int count = 0;
        foreach(var box in itemBoxes)
        {
            if (box.isOveraped == true)
            {
                count++;
            }
        }

        if (count >= 3)
        {
            Debug.Log("½Â¸®");
            isGameOver = true;
            winUI.SetActive(true);
        }
    }
}
