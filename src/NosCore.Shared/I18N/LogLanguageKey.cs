﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NosCore.Shared.Logger
{
    public enum LogLanguageKey
    {
        UNREGISTRED_FROM_MASTER,
        REGISTRED_ON_MASTER,
        UNRECOGNIZED_MASTER_PACKET,
        AUTHENTICATED_SUCCESS,
        AUTHENTICATED_ERROR,
        DATABASE_INITIALIZED,
        DATABASE_NOT_UPTODATE,
        CLIENT_DISCONNECTED,
        CHARACTER_NOT_INIT,
        ERROR_CHANGE_MAP,
        AUTH_INCORRECT,
        AUTH_ERROR,
        FORCED_DISCONNECTION,
        CLIENT_CONNECTED,
        REGISTRED_FROM_MASTER,
        CLIENT_ARRIVED,
        CORRUPTED_KEEPALIVE,
        INVALID_PASSWORD,
        INVALID_ACCOUNT,
        ACCOUNT_ARRIVED,
        SUCCESSFULLY_LOADED,
        MASTER_SERVER_RETRY,
        LISTENING_PORT,
        MASTER_SERVER_LISTENING,
        ENTER_PATH,
        PARSE_ALL,
        PARSE_MAPS,
        PARSE_MAPTYPES,
        PARSE_ACCOUNTS,
        PARSE_PORTALS,
        PARSE_TIMESPACES,
        PARSE_ITEMS,
        PARSE_NPCMONSTERS,
        PARSE_NPCMONSTERDATA,
        PARSE_CARDS,
        PARSE_SKILLS,
        PARSE_MAPNPCS,
        PARSE_MONSTERS,
        PARSE_SHOPS,
        PARSE_TELEPORTERS,
        PARSE_SHOPITEMS,
        PARSE_SHOPSKILLS,
        PARSE_RECIPES,
        PARSE_QUESTS,
        DONE,
        AT_LEAST_ONE_FILE_MISSING,
        CARDS_PARSED,
        ITEMS_PARSED,
        MAPS_LOADED,
        NO_MAP,
        MAPMONSTERS_LOADED,
        CORRUPT_PACKET,
        HANDLER_ERROR,
        HANDLER_NOT_FOUND,
        SELECT_MAPID,
        WRONG_SELECTED_MAPID
    }
}