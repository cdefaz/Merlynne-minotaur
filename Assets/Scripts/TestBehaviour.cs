using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Databank;


public class TestBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LevelDb mLevelDb = new LevelDb();

        mLevelDb.addData(new DataEntity("1", "test 1", "test1@uwaterloo.ca", "705123456"));
        mLevelDb.addData(new DataEntity("2", "test 2", "test2@uwaterloo.ca", "1234567890"));
        mLevelDb.addData(new DataEntity("5", "test 5", "test5@uwaterloo.ca", "705 896 7509"));
        mLevelDb.close();

        LevelDb mLevelDb1 = new LevelDb();
        System.Data.IDataReader reader = mLevelDb1.getAllData();

        int fieldCount = reader.FieldCount;
        List<DataEntity> myList = new List<DataEntity>();
        while(reader.Read())
        {
            DataEntity entity = new DataEntity(reader[0].ToString(),reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                reader[4].ToString(), reader[5].ToString());
            Debug.Log("id: " + entity._playerId);
            myList.Add(entity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
