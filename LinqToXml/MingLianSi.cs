using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class MingLianSi
{
    const string DECK_NAME = "命莲寺";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "村纱水蜜"),
                new XElement("Amount", 1),
                new XElement("Faith", 2),
                new XElement("Coin", 4),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "多多良小伞"),
                new XElement("Amount", 1),
                new XElement("Faith", 1),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "激光宝塔"),
                new XElement("Amount", 1),
                new XElement("Faith", 2),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "金属探测器"),
                new XElement("Amount", 2),
                new XElement("Faith", 1),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "魔界卷轴"),
                new XElement("Amount", 1),
                new XElement("Faith", 3),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "娜兹玲"),
                new XElement("Amount", 1),
                new XElement("Faith", 2),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "圣白莲"),
                new XElement("Amount", 1),
                new XElement("Faith", 8),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 5)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "妖怪僧侣"),
                new XElement("Amount", 3),
                new XElement("Faith", 5),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "业障化身"),
                new XElement("Amount", 1),
                new XElement("Faith", 6),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "寅丸星"),
                new XElement("Amount", 1),
                new XElement("Faith", 2),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "幽谷响子"),
                new XElement("Amount", 1),
                new XElement("Faith", 2),
                new XElement("Coin", 2),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "云居一轮与云山"),
                new XElement("Amount", 3),
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
