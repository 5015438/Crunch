using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public int selectedcharacter = 0;
    public int selectedcharacter2 = 0;
    public potraitbiggee biggee;
    public potraitcinder cinder;
    public potraitjean jean;
    public eventsystem game;
    public potraitbiggee2 biggeep2;
    public potraitjean2 jeanp2;
  /*public potraitcinder2 cinder2;
    public eventsystem2 game;*/
    public int p1selected = 0;

    public GameObject allbuttons;
    public GameObject allbuttons2;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<eventsystem>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<eventsystem>();

        p1selected = jean.selected;
        p1selected = cinder.selected;
        p1selected = biggee.selected;

        if (jean.selectchara == 1)
        {
            if (p1selected == 1)
            {
                selectedcharacter = 1;
            }
        }

        if (cinder.selectchara == 3)
        {
            if (p1selected == 1)
            {
                selectedcharacter = 3;
            }
        }

        if (biggee.selectchara == 4)
        {
            if (p1selected == 1)
            {
                selectedcharacter = 4;
            }
        }

        /// Player two

        if (p1selected == 1)
        {
            allbuttons2.SetActive(true);
            allbuttons.SetActive(false);

        }
        if (jeanp2.selectchara == 1)
        {
            selectedcharacter2 = 1;
        }
        if (biggeep2.selectchara == 4)
        {
            selectedcharacter2 = 4;
        }

    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
