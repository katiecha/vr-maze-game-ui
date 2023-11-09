using System.Collections;
using System.Colletions.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    [SerializeField] protected List<GameObjects> subMenus;

    // should switch between sections of the main menu

    public void OpenSubMenu(int index) {
        foreach (GameObject sub in subMenus) {
            if (sub.activeSelf) {
                sub.SetActive(false);
            }
        }
        subMenus[index].setActive(true);
    }

}