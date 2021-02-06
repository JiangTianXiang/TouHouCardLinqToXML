using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class BaiYuLou
{
    const string DECK_NAME = "白玉楼";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "白楼剑"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "魂魄妖梦"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 2),
                new XElement("Food", 1),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "楼观剑"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 4),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "迷途之灵"),
                new XElement("Amount", 3),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "庭院"),
                new XElement("Amount", 2),
                new XElement("Faith", 0),
                new XElement("Coin", 4),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "西行寺幽幽子"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 5),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "西行妖"),
                new XElement("Amount", 1),
                new XElement("Faith", 6),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "幽幽子的折扇"),
                new XElement("Amount", 1),
                new XElement("Faith", 3),
                new XElement("Coin", 2),
                new XElement("Food", 2),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "转世之灵"),
                new XElement("Amount", 3),
                new XElement("Faith", 1),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
