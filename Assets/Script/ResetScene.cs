using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public List<GameObject> Targets;
    public GameObject youWinText;

    public void Update()
    {
        if (Targets.All(x => !x.activeInHierarchy))
        {
            youWinText.SetActive(true);
            StartCoroutine(Active());
        }
    }

    IEnumerator Active()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
