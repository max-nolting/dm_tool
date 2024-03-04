using DmTool.DataAccess.Models.Enums;

namespace DmTool.DataAccess.Models;

public class Npc
{
    public string Name { get; set; }
    public HeritageEnum Heritage { get; set; } 
    public GenderEnum Gender { get; set; }
    public AlignmentEnum Alignment { get; set; }

    public Npc()
    {
        Name = "default";
        var Heritages = Enum.GetValues(typeof(HeritageEnum));
        var Genders = Enum.GetValues(typeof(GenderEnum));
        var Alignments = Enum.GetValues(typeof(AlignmentEnum));

        Heritage = (HeritageEnum)Heritages.GetValue(new Random().Next(0,Heritages.Length));
        Gender = (GenderEnum)Genders.GetValue(new Random().Next(0,Genders.Length));
        Alignment = (AlignmentEnum)Heritages.GetValue(new Random().Next(0, Alignments.Length));

    }
}
