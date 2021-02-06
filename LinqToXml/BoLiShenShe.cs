using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class BoLiShenShe
{
    const string DECK_NAME = "博丽神社";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "博丽灵梦"),
                new XElement("Amount", 1),
                new XElement("Faith", 6),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "茨木华扇"),
                new XElement("Amount", 1),
                new XElement("Faith", 4),
                new XElement("Coin", 0),
                new XElement("Food", 1),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "萃香的酒壶"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 4),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "高丽野阿吽"),
                new XElement("Amount", 1),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "雷兽务光"),
                new XElement("Amount", 3),
                new XElement("Faith", 2),
                new XElement("Coin", 0),
                new XElement("Food", 2),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "青龙黄帝"),
                new XElement("Amount", 2),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 3),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "赛钱箱"),
                new XElement("Amount", 2),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "伊吹萃香"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 6),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "依神女苑"),
                new XElement("Amount", 1),
                new XElement("Faith", 1),
                new XElement("Coin", 4),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "依神紫苑"),
                new XElement("Amount", 1),
                new XElement("Faith", 4),
                new XElement("Coin", 1),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
