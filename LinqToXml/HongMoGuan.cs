using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class HongMoGuan
{
    const string DECK_NAME = "红魔馆";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "芙兰朵露·斯卡蕾特"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 4),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "冈格尼尔"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 5),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "红美铃"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 1),
                new XElement("Food", 2),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "蕾米莉亚·斯卡蕾特"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 4),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "帕秋莉·诺雷姬"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 7),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "十六夜咲夜"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 2),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "贪吃老鼠"),
                new XElement("Amount", 3),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 3),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "图书馆"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 6),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                //TODO: CHANGE THIS!
                new XElement("Point", 10)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "小恶魔"),
                new XElement("Amount", 3),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "洋馆"),
                new XElement("Amount", 2),
                new XElement("Faith", 0),
                new XElement("Coin", 5),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
