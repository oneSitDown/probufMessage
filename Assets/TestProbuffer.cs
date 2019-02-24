//========================================================
//作者:#AuthorName#
//创建时间:#CreateTime#
//备注:
//========================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProtoBuf;
using System.IO;
using proto.Test;
public class TestProbuffer : MonoBehaviour {

    byte[] testByte;
    // Use this for initialization
    void Start () {
        ReqLogin reqLogin = new ReqLogin();
        reqLogin.account = "OneSitDown";
        reqLogin.password = "2222";
        testByte = Serialize(reqLogin);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            ReqLogin reqLogin = (ReqLogin)Deserialize<ReqLogin>(testByte);
            Debug.Log(reqLogin.account);
            Debug.Log(reqLogin.password);
        }
	}


    public byte[] Serialize(IExtensible msg)
    {
        byte[] result;
        using (var stream = new MemoryStream())
        {
            Serializer.Serialize(stream, msg);
            result = stream.ToArray();
        }
        return result;
    }

    public IExtensible Deserialize<IExtensible>(byte[] message)
    {
        IExtensible result;
        using (var stream = new MemoryStream(message))
        {
            result = Serializer.Deserialize<IExtensible>(stream);
        }
        return result;
    }
}
