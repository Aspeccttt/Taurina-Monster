using UnityEngine;
using UnityEngine.SceneManagement;

public class Safe_House_Entrance : MonoBehaviour
{
    SceneManager Scene;
    // Start is called before the first frame update
    [Tooltip ("Text in the Canvas")]
    public TMPro.TextMeshProUGUI Text;
    bool canExit = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (canExit && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Collision");
            Text.text = "Press Space to Enter";
            canExit = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {

        if (other.transform.tag == "Player")
        {
            Debug.Log("Exitted");
            Text.text = "";
            canExit = false;
        }
    }


    //Debug.Log("Collided");

    //   if (collision.transform.tag == "Player")
    // {
    //       Debug.Log("Collided");
    //       Debug.Log("Collision");
    //       Text.text = "Press Space to Exit";
    //}
    //}

}
