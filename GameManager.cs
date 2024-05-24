using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Worm> worms = new List<Worm>();
    public Button button;
    public Image image;

    private void Start()
    {
        button.interactable = false;
        image.gameObject.SetActive(false);
    }

    public void EnemyDied()
    {
        worms.RemoveAll(w => !w); // Удалить нулевые ссылки на врагов
        if (worms.Count == 0)
        {
            // Все враги уничтожены
            button.interactable = true;
            image.gameObject.SetActive(true);
        }
    }
}