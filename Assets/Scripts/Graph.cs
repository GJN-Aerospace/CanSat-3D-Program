using UnityEngine;

public class Graph : MonoBehaviour {

    public Transform pointprefab;

    void Awake() {

        LoadCSV.Load();

        float startx = LoadCSV.rowList[0].longitudem;
        float startz = LoadCSV.rowList[0].latitudem;
        int lastline = LoadCSV.rowList.Count - 1;
        float endy = LoadCSV.rowList[lastline].height1;


        Vector3 scale = Vector3.one * 10f;
        Vector3 position;
        foreach (Row r in LoadCSV.rowList) {
            Transform point = Instantiate(pointprefab);
            position.x = r.longitudem - startx;
            position.z = r.latitudem - startz;
            position.y = r.height1 - endy;
            point.localPosition = position;
            point.localScale = scale;

            //Debug.Log(r.longitudem - startx);

        }
    }
}
