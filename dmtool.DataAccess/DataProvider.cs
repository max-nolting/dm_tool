using DmTool.DataAccess.Models;
using System.Numerics;

public class DataProvider
{
    private DataProvider()
    {
        _players = new List<Npc>();
    }

    private List<Npc> _players { get; set; }

    private static DataProvider _instance;
    public static DataProvider Instance
    {
        get
        {
            if (_instance == null)
                _instance = new DataProvider();

            return _instance;
        }
    }

    public Npc GetNpc()
    {
        return new Npc();
    }
}