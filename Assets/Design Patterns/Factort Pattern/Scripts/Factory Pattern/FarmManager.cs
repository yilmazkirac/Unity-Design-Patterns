using UnityEngine;

public class FarmManager : MonoBehaviour
{
    [SerializeField] private Factory[] factories;
    [SerializeField] private LayerMask layerToClick;
    [SerializeField] private Vector3 offset;

    private Factory factory;

    private void Update()
    {
        SpawnAnimalOnClick();
    }
    private void SpawnAnimalOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            factory = factories[Random.Range(0, factories.Length)];
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layerToClick) && factory != null)
            {
                factory.CreateAnimal(hit.point + offset);
            }
        }
    }
}
