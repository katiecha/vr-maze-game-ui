using System.Collections;
using System.Colletions.Generic;
using UnityEngine;

// Needs to switch between sub-menus

public class MainMenu : MonoBehaviour {
    [SerializeField] protected List<GameObjects> subMenus;

    public void OpenSubMenu(int index) {
        foreach (GameObject sub in subMenus) {
            if (sub.activeSelf) {
                sub.SetActive(false);
            }
        }
        subMenus[index].setActive(true);
    }

}