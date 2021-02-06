using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class DiLingDian
{
    const string DECK_NAME = "地灵殿";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "恶鬼"),
                new XElement("Amount", 2),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 5),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "古明地觉"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 1),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "古明地恋"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 5),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "核熔炉"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 8),
                new XElement("Food", 0),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 6)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "火焰猫燐"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 3),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 2)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "灵乌路空"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 6),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "染火的怨灵"),
                new XElement("Amount", 4),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_FAITH),
                new XElement("Point", 1)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "温泉"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 5),
                new XElement("Food", 2),
                new XElement("Type", TYPE_BUILDING),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 5)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "怨灵"),
                new XElement("Amount", 3),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_CHARACTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 3))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
