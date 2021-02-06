using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class ShouDao
{
    const string DECK_NAME = "兽道";

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
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "拦路小鬼"),
                new XElement("Amount", 5),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1),
                new XElement("CardEffect", 
                    new XElement(CardEffectsKey.CENTER_MONSTER, 
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN), 
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FAITH),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)),
                    new XElement(CardEffectsKey.MONSTER_EXILE, 
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN), 
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FAITH),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)))),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "毛玉"),
                new XElement("Amount", 5),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 3),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1),
                new XElement("CardEffect",
                    new XElement(CardEffectsKey.CENTER_MONSTER,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_COIN),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)),
                    new XElement(CardEffectsKey.MONSTER_EXILE,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_COIN),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)))),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "毛玉王"),
                new XElement("Amount", 1),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 7),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 4)),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "闲逛小鬼"),
                new XElement("Amount", 5),
                new XElement("Faith", 0),
                new XElement("Coin", 0),
                new XElement("Food", 3),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1),
                new XElement("CardEffect",
                    new XElement(CardEffectsKey.CENTER_MONSTER,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FAITH),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)),
                    new XElement(CardEffectsKey.MONSTER_EXILE,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FAITH),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)))),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "野狼"),
                new XElement("Amount", 5),
                new XElement("Faith", 0),
                new XElement("Coin", 3),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1),
                new XElement("CardEffect",
                    new XElement(CardEffectsKey.CENTER_MONSTER,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FOOD),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)),
                    new XElement(CardEffectsKey.MONSTER_EXILE,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FOOD),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)))),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "野路灵视"),
                new XElement("Amount", 5),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1),
                new XElement("CardEffect",
                    new XElement(CardEffectsKey.CENTER_MONSTER,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_COIN),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)),
                    new XElement(CardEffectsKey.MONSTER_EXILE,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_COIN),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)))),
            new XElement("Card", new XAttribute("Deck", DECK_NAME), new XAttribute("Name", "战死之灵"),
                new XElement("Amount", 5),
                new XElement("Faith", 3),
                new XElement("Coin", 0),
                new XElement("Food", 0),
                new XElement("Type", TYPE_MONSTER),
                new XElement("Faction", FACTION_NEUTRAL),
                new XElement("Point", 1),
                new XElement("CardEffect",
                    new XElement(CardEffectsKey.CENTER_MONSTER,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FOOD),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1)),
                    new XElement(CardEffectsKey.MONSTER_EXILE,
                                new XAttribute(CardEffectsKey.ACTION, CardEffectsKey.ACTION_GAIN),
                                new XAttribute(CardEffectsKey.RESOURCE, CardEffectsKey.RESOURCE_FOOD),
                                new XAttribute(CardEffectsKey.RESOURCE_COUNT, 1))))
            ));
        xmlDocument.Save($"{SAVE_LOCATION}{FILE_NAME}");
    }
}
