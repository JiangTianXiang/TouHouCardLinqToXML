using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class ShouShiShenShe
{
    const string DECK_NAME = "守矢神社";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "八坂神奈子"),
                new XElement("Amount", 1),
                new XElement("Faith", 6),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "嗔怒的巨蛇"),
                new XElement("Amount", 2),
                new XElement("Faith", 4),
                new XElement("Coin", 0),
                new XElement("Food", 2),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "东风谷早苗"),
                new XElement("Amount", 1),
                new XElement("Faith", 2),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "鸟居"),
                new XElement("Amount", 2),
                new XElement("Faith", 4),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "神奈子的御柱"),
                new XElement("Amount", 1),
                new XElement("Faith", 4),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "泄矢诹访子"),
                new XElement("Amount", 1),
                new XElement("Faith", 7),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 5)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "妖怪参拜客"),
                new XElement("Amount", 3),
                new XElement("Faith", 2),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "早苗毛玉"),
                new XElement("Amount", 4),
                new XElement("Faith", 2),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
