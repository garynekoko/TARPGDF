using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedObject : MonoBehaviour
{
    private PlacedObjectTypeSO placedObjectTypeSO;
    private Vector2Int origin;
    private PlacedObjectTypeSO.Dir dir;
    //private WeaponController wp;
    //private GameObject m_WeaponController;
    // Start is called before the first frame update
    public static PlacedObject Create(Vector3 worldPosition, Vector2Int origin, PlacedObjectTypeSO.Dir dir, PlacedObjectTypeSO placedObjectTypeSO)
    {
        Transform placedObjectTransform = Instantiate(placedObjectTypeSO.prefab, worldPosition, Quaternion.Euler(0, placedObjectTypeSO.GetRotationAngle(dir), 0));

        PlacedObject placedObject = placedObjectTransform.GetComponent<PlacedObject>();
        placedObject.Setup(placedObjectTypeSO, origin, dir);

        return placedObject;
    }
    private void Setup(PlacedObjectTypeSO placedObjectTypeSO, Vector2Int origin, PlacedObjectTypeSO.Dir dir)
    {
        this.placedObjectTypeSO = placedObjectTypeSO;
        this.origin = origin;
        this.dir = dir;
    }
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    //public List<Vector2Int> GetGridPositionList()
    //{
    //    m_WeaponController = GameObject.Find("SdUnitychan");
    //    wp = m_WeaponController.GetComponent(typeof(WeaponController)) as WeaponController;
    //    return wp.GetGridPositionList(origin, dir);
    //}
    public List<Vector2Int> GetGridPositionList()
    {
        return placedObjectTypeSO.GetGridPositionList(origin, dir);
    }
    public override string ToString()
    {
        return placedObjectTypeSO.nameString;
    }





}
