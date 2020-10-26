using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using System.Linq;
using System.Text;

public class LevelDb : SQLiteHelper
{
    private const String Tag = "Riz: LevelDb:\t";

    private const String TABLE_NAME = "LevelInfo";
    private const String KEY_ID = "Player_id";
    private const String KEY_EMAIL = "Email";
    private const String KEY_NAME = "Name";
    private const String KEY_PHONE = "Phone";
    private const String KEY_DIALOGUE = "Dialogue";

    private const String KEY_LEVEL = "Level_id";
    private String[] COLUMNS = new string[] {KEY_ID, KEY_NAME, KEY_EMAIL, KEY_PHONE, KEY_LEVEL, KEY_DIALOGUE};

    public LevelDb() : base()
    {
        IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ( "+ 
            KEY_ID + " TEXT, " +
            KEY_NAME + " TEXT, " +
            KEY_EMAIL + " TEXT, " +
            KEY_PHONE + " TEXT, " +
            KEY_LEVEL + " TEXT, " +
            KEY_DIALOGUE + " TEXT )";
        dbcmd.ExecuteNonQuery();
    }

    public void addData(DataEntity Level)
    {
        IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText = "INSERT INTO "+ TABLE_NAME + " ( " + KEY_ID + ", "
            + KEY_NAME + ", "
            + KEY_EMAIL + ", "
            + KEY_PHONE + ", "
            + KEY_LEVEL + ", "
            + KEY_DIALOGUE + " ) "

            + "VALUES ( '"
            + Level._playerId + "', '"
            + Level._name + "', '"
            + Level._email + "', '"
            + Level._phone + "', '"
            + Level._levelId + "', '"
            + Level._dialogue + "' )";
        dbcmd.ExecuteNonQuery();
    }

    public override IDataReader getDataById(int id)
    {
        return base.getDataById(id);
    }

    public override IDataReader getDataByString(string str)
    {
        Debug.Log(Tag + "Getting Level Data: " + str);
        IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText = "SELECT * FROM " + TABLE_NAME + " WHERE " + KEY_ID + " = '"+ str +"'";
        return dbcmd.ExecuteReader();
    }

    public override void deleteDataByString(string id)
    {
        Debug.Log(Tag + "Deleting Level Data:" + id);
        IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText = "DELETE FROM " + TABLE_NAME + " WHERE "+ KEY_ID + " = '"+ id + "'";
        dbcmd.ExecuteNonQuery();
    }


    public override void deleteDataById(int id)
    {
        base.deleteDataById(id);
    }

    public override void deleteAllData()
    {
        Debug.Log(Tag + "Deleting Table");
        base.deleteAllData(TABLE_NAME);
    }

    public override IDataReader getAllData()
    {
        return base.getAllData(TABLE_NAME);
    }
}
