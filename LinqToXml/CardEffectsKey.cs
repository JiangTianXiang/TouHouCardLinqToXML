using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CardEffectsKey
{
    public const string HAND_PLAY = "HandToPlayedEffects";
    public const string CENTER_DISCARD = "CenterToDiscardEffects";
    public const string CENTER_MONSTER = "CenterToMonsterEffects";
    public const string MONSTER_EXILE = "MonsterToExileEffects";

    public const string RESOURCE = "resource";
    public const string RESOURCE_CARD = "card";
    public const string RESOURCE_FAITH = "faith";
    public const string RESOURCE_FOOD = "food";
    public const string RESOURCE_COIN = "coin";
    public const string RESOURCE_SPECIAL = "special";

    public const string ACTION = "action";
    public const string ACTION_GAIN = "gain";
    public const string ACTION_DRAW = "draw";

    public const string RESOURCE_COUNT = "count";
}
