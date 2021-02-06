using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class MoFaZhiSen
{
    const string DECK_NAME = "魔法之森";

    const string TYPE_BUILDING = "building";
    const string TYPE_MONSTER = "monster";
    const string TYPE_CHARACTER = "character";

    const string FACTION_FAITH = "faith";
    const string FACTION_NEUTRAL = "neutral";

    const string SAVE_LOCATION = @"D:\UnityProject\UnityPractice\TouHouCard\DragAndDrop\Assets\Resources\XML\";
    readonly string FILE_NAME = $"{DECK_NAME}.xml";
    public void GenerateDeck()
    {
        XDocument xmlDocument = new XDocument(
        new XDeclaration("1.0", "utf-8", "yes"),
        new XComment($"{DECK_NAME} information"),
        new XElement("Cards",
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "爱丽丝·玛格特罗依德"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 6),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "八卦炉"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 5),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "恶作剧妖精"),
                new XElement("Amount", 4),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 2),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "歌莉娅人形"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 6),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "魔法使"),
                new XElement("Amount", 2),
                new XElement("Faith", 0),
                new XElement("Coin", 5),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "蓬莱人形"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "森林木屋"),
                new XElement("Amount", 2),
                new XElement("Faith", 0),
                new XElement("Coin", 4),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "上海人形"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "矢田寺成美"),
                new XElement("Amount", 1),
                new XElement("Faith", 4),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "雾雨魔理沙"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 2),
                new XElement("Food", 1),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
