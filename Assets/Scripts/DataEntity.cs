using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEntity
{
    public string _name;
    public string _email;
    public string _phone;
    public string _playerId;
    public string _dialogue;
    public string _levelId;

    public DataEntity(string id, string name, string email, string phone, string dialogue, string levelId )
    {
        _playerId = id;
        _name = name;
        _email = email;
        _phone = phone;
        _dialogue = dialogue;
        _levelId = levelId;
    }

    public DataEntity(string id, string name, string email, string phone)
    {
        _playerId = id;
        _name = name;
        _email = email;
        _phone = phone;
        _dialogue="";
        _levelId= "";
    }

    public static DataEntity getFakeLevel()
    {
        return new DataEntity("0", "Test", "Test@uwaterloo.ca", "1234567890");
    }
}
