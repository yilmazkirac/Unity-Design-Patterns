using UnityEngine;

public class Debugs : MonoBehaviour
{
    private void Start() {
     Debug.Log(Singleton.Instance.Text);
    }
}
