using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCSV : MonoBehaviour
{
    public static List<Row> rowList = new List<Row>();

    // Start is called before the first frame update
    public static void Load()
    {

        //Debug.Log("StartLoadCSV");

        TextAsset gpsdata = Resources.Load<TextAsset>("baseStation_SD");

        string[] data = gpsdata.text.Split(new char[] { '\n' });

        for (int i = 0; i < data.Length; i++)
        {
            string[] rawRow = data[i].Split(new char[] { ';' });

            if (rawRow[12] != "")
            {
                if (rawRow[12] != "Zem. šířka(Lat.)")
                {
                    Row r = new Row();

                    r.pkii = rawRow[1];
                    int.TryParse(rawRow[2], out r.messageid);
                    float.TryParse(rawRow[3], out r.temperature);
                    float.TryParse(rawRow[4], out r.pressure);
                    float.TryParse(rawRow[5], out r.humidity);
                    float.TryParse(rawRow[6], out r.height1);
                    float.TryParse(rawRow[7], out r.shunt);
                    float.TryParse(rawRow[8], out r.bus);
                    int.TryParse(rawRow[9], out r.current);
                    int.TryParse(rawRow[10], out r.load);
                    int.TryParse(rawRow[11], out r.rssi);
                    float.TryParse(rawRow[12], out r.latitude);
                    r.latitudem = r.latitude * 0.0111f;
                    float.TryParse(rawRow[13], out r.longitude);
                    r.longitudem = r.longitude * 0.0071f;
                    r.coordinates = rawRow[14];
                    int.TryParse(rawRow[15], out r.year);
                    int.TryParse(rawRow[16], out r.month);
                    int.TryParse(rawRow[17], out r.day);
                    r.time = rawRow[18];
                    int.TryParse(rawRow[19], out r.hours);
                    int.TryParse(rawRow[20], out r.minutes);
                    int.TryParse(rawRow[21], out r.siv);
                    int.TryParse(rawRow[22], out r.height2);
                    int.TryParse(rawRow[23], out r.temperaturew);
                    int.TryParse(rawRow[24], out r.humidityw);
                    int.TryParse(rawRow[25], out r.heightw);
                    float.TryParse(rawRow[26], out r.stationTemperature);
                    float.TryParse(rawRow[27], out r.stationPressure);
                    float.TryParse(rawRow[28], out r.stationHumidity);
                    float.TryParse(rawRow[29], out r.stationHeight);
                    rowList.Add(r);
                }
            }
        }
        foreach (Row r in rowList)
        {

        }
        //Debug.Log("EndLoadCSV");
    }

    void ParseCoordinate() {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
