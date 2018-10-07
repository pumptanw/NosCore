﻿using NosCore.Data;
using NosCore.GameObject.Networking;
using NosCore.Shared.Enumerations.Items;
using System.Collections.Generic;

namespace NosCore.GameObject.Item
{
    public class ItemInstance : ItemInstanceDTO
    {
        public bool IsBound => BoundCharacterId.HasValue && Item.ItemType != ItemType.Armor && Item.ItemType != ItemType.Weapon;

        public Item Item;
        public ItemInstance(Item item)
        {
            Item = item;
            ItemVNum = item.VNum;
        }
        public ItemInstance()
        {
        }

        public ItemInstance Clone()
        {
            return (ItemInstance)MemberwiseClone();
        }
    }
}