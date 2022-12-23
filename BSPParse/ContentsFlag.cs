﻿using System;

namespace ResurrectedEternal.BSPParse
{
    [Flags]
    public enum ContentsFlag : uint
    {
        CONTENTS_EMPTY = 0,
        CONTENTS_SOLID = 0x1,
        CONTENTS_WINDOW = 0x2,
        CONTENTS_AUX = 0x4,
        CONTENTS_GRATE = 0x8,
        CONTENTS_SLIME = 0x10,
        CONTENTS_WATER = 0x20,
        CONTENTS_MIST = 0x40,
        CONTENTS_OPAQUE = 0x80,
        CONTENTS_TESTFOGVOLUME = 0x100,
        CONTENTS_UNUSED = 0x200,
        CONTENTS_UNUSED6 = 0x400,
        CONTENTS_TEAM1 = 0x800,
        CONTENTS_TEAM2 = 0x1000,
        CONTENTS_IGNORE_NODRAW_OPAQUE = 0x2000,
        CONTENTS_MOVEABLE = 0x4000,
        CONTENTS_AREAPORTAL = 0x8000,
        CONTENTS_PLAYERCLIP = 0x10000,
        CONTENTS_MONSTERCLIP = 0x20000,
        CONTENTS_CURRENT_0 = 0x40000,
        CONTENTS_CURRENT_90 = 0x80000,
        CONTENTS_CURRENT_180 = 0x100000,
        CONTENTS_CURRENT_270 = 0x200000,
        CONTENTS_CURRENT_UP = 0x400000,
        CONTENTS_CURRENT_DOWN = 0x800000,
        CONTENTS_ORIGIN = 0x1000000,
        CONTENTS_MONSTER = 0x2000000,
        CONTENTS_DEBRIS = 0x4000000,
        CONTENTS_DETAIL = 0x8000000,
        CONTENTS_TRANSLUCENT = 0x10000000,
        CONTENTS_LADDER = 0x20000000,
        CONTENTS_HITBOX = 0x40000000
    }
}