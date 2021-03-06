#pragma warning disable
using System.Collections.Generic;
using XPT.Games.Generic.Entities;
using XPT.Games.Generic.Maps;
using XPT.Games.Yserbius;
using XPT.Games.Yserbius.Entities;

namespace XPT.Games.Yserbius.Maps {
    class YserMap15 : YsMap {
        public override int MapIndex => 15;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap15() {
            MapEvent01 = FnTOCORDOR_01;
            MapEvent02 = FnTELEPORT_02;
            MapEvent03 = FnTELEPORT_03;
            MapEvent04 = FnHIDNDOOR_04;
            MapEvent05 = FnLKPKDOOR_05;
            MapEvent06 = FnCRWNNICH_06;
            MapEvent07 = FnCRWNDOOR_07;
            MapEvent08 = FnROBENICH_08;
            MapEvent09 = FnROBEDOOR_09;
            MapEvent0A = FnSCEPNICH_0A;
            MapEvent0C = FnGOLDAENC_0C;
            MapEvent0D = FnGOLDBENC_0D;
            MapEvent0E = FnSPCMONSA_0E;
            MapEvent0F = FnSPCMONSB_0F;
            MapEvent10 = FnSPCMONSC_10;
            MapEvent11 = FnPAYOFENC_11;
            MapEvent12 = FnITEMAENC_12;
            MapEvent13 = FnITEMBENC_13;
            MapEvent14 = FnBADMNSTR_14;
            MapEvent15 = FnTERMNSTR_15;
            MapEvent16 = FnGATEMESS_16;
            MapEvent17 = FnTELEMESA_17;
            MapEvent18 = FnTELEMESB_18;
            MapEvent19 = FnNPCCHATA_19;
            MapEvent1A = FnNPCCHATB_1A;
            MapEvent1B = FnNPCCHATC_1B;
            MapEvent1C = FnNPCCHATD_1C;
            MapEvent1D = FnNPCCHATE_1D;
            MapEvent1E = FnMINOTAUR_1E;
        }
        
        // === Strings ================================================
        private const string String03FC = "A note reads -";
        private const string String040B = "'Only heroes of the thirtieth level or higher may pass this door.'";
        private const string String044E = "The Sunbeam Key reveals a hidden door to the Dwarf Kingdom!";
        private const string String048A = "You skillfully pick the door lock.";
        private const string String04AD = "The door is locked.";
        private const string String04C1 = "Invisible hands take Cleowyn's Crown and place it in a niche in the wall.";
        private const string String050B = "The niche disappears.";
        private const string String0521 = "You hear a rumbling sound in the distance";
        private const string String054B = "There is a niche in the wall which seems designed to hold a crown.";
        private const string String058E = "Returning the Crown of Cleowyn reveals a secret door in the west wall!";
        private const string String05D5 = "Cleowyn's Robe flies out of your hands and into a niche in the wall.";
        private const string String061A = "The niche disappears.";
        private const string String0630 = "You hear a rumbling sound in the distance.";
        private const string String065B = "There is a niche in the wall which seems designed to hold a robe.";
        private const string String069D = "Returning the Robe of Cleowyn reveals a secret door in the east wall.";
        private const string String06E3 = "Cleowyn's Scepter is taken from you by spectral hands and is placed in a niche in the wall.";
        private const string String073F = "The spirit of King Cleowyn whispers -";
        private const string String0765 = "'Well done!  The reward is yours for the taking, if you dare claim it.";
        private const string String07AC = "The door to the tomb opens.";
        private const string String07C8 = "There is a niche in the wall which seems designed to hold a scepter.";
        private const string String080D = "The room you enter is cold as ice.";
        private const string String0830 = "An Ice Lion stands over a torn bag of gold.";
        private const string String085C = "The room stinks of rotten meat.";
        private const string String087C = "Something kicks gold across the floor as it charges you.";
        private const string String08B5 = "Lizardites guard this area.";
        private const string String08D1 = "Giants guard the corridor.";
        private const string String08EC = "There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'";
        private const string String09BA = "As you place Cleowyn's bones in the crypt, Cleowyn's spirit whispers to you -";
        private const string String0A08 = "'My thanks to you. You certainly took your time finding my bones. Here is the Netherworld Medallion. Now go away and don't bother me again.'";
        private const string String0A95 = "There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'";
        private const string String0B63 = "You find the Crypt of King Cleowyn and open it. Inside is the Sword of the Crypt, the Mourning Star, the Bow of Sorrow, and Galabryan Chainmail.";
        private const string String0BF4 = "Polar Bears wander the empty room.";
        private const string String0C17 = "A Polar Bear plays with a pile of stuff.";
        private const string String0C40 = "Hell Wolves snarl at you.";
        private const string String0C5A = "A Hell Wolf kicks an object aside as it leaps at you.";
        private const string String0C90 = "This gateway leads to THE GREAT CORRIDOR.";
        private const string String0CBA = "There is a teleport in the east wall.";
        private const string String0CE0 = "There is a teleport in the west wall.";
        private const string String0D06 = "You encounter a Gremlin Cleric.";
        private const string String0D26 = "Listen carefully, friend. Be careful where you place the possessions Cleowyn demands. Use Crown before Robe before Scepter.";
        private const string String0DA2 = "Someone in your group must always remain in the Mausoleum until all three items are placed and the tomb is opened.";
        private const string String0E15 = "Otherwise, imps will steal the treasures away and hide them again.  They love to torment adventurers and Cleowyn's spirit.";
        private const string String0E90 = "Remember to leave one person at all times and to reform your group before continuing your quest.";
        private const string String0EF1 = "The Gremlin Cleric turns away as you approach her.";
        private const string String0F24 = "You encounter a Halfling Knight.";
        private const string String0F45 = "The longest routes through this Mausoleum are the least rewarding.";
        private const string String0F88 = "The Halfling Knight looks at you once and then continues polishing her shield.";
        private const string String0FD7 = "You encounter an Elf Ranger.";
        private const string String0FF4 = "The night the volcano erupted, the wizard Arnakkian Slowfoot threw a great feast. All who attended died in the eruption. They died at their games of cards and gambling. Some, it is said, were transformed into the monsters who inhabit the dungeon.";
        private const string String10EB = "The Elf Ranger abruptly walks away.";
        private const string String110F = "You encounter a Gnome Barbarian.";
        private const string String1130 = "Cleowyn's bones are guarded by the Snow Elves, I have heard. Whether or not it is worth returning the king's bones to the Mausoleum is much debated, for the imps will seize them again and return them to the elves.";
        private const string String1206 = "The Gnome Barbarian opens his mouth to speak, but he forgets what he planned to say.";
        private const string String125B = "You encounter a Human Thief.";
        private const string String1278 = "If you find King Cleowyn's quarters, you will find a shortcut back to his Palace. Be careful where you tread, lest you leave his quarters unrewarded.";
        private const string String130E = "The Human Thief darts away as you approach.";
        
        // === Functions ================================================
        private void FnTOCORDOR_01(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x03, 0x03, 0x08, 0x01, type);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_02(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x001E);
            L0011: if (JumpEqual) goto L0030;
            L0013: TeleportParty(player, 0x38, 0x01, 0x7A, 0x02, type);
            L002E: goto L0067;
            L0030: ShowMessage(player, doMsgs, String03FC); // A note reads -
            L003D: ShowMessage(player, doMsgs, String040B); // 'Only heroes of the thirtieth level or higher may pass this door.'
            L004A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0067: return; // RETURN;
        }

        private void FnTELEPORT_03(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x04, 0x20, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnHIDNDOOR_04(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, YsIndexes.ItemSunbeamKey);
            L0011: if (JumpEqual) goto L0059;
            L0013: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0031: SetWallItem(player, 0x01, GetCurrentTile(player), 0x00);
            L004A: ShowMessage(player, doMsgs, String044E); // The Sunbeam Key reveals a hidden door to the Dwarf Kingdom!
            L0057: goto L0076;
            L0059: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0076: return; // RETURN;
        }

        private void FnLKPKDOOR_05(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0008);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, doMsgs, String048A); // You skillfully pick the door lock.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, doMsgs, String04AD); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnCRWNNICH_06(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x69);
            L0011: if (JumpNotEqual) goto L0028;
            L0013: ax = IsFlagOn(player, FlagTypeMap, 0x01);
            L0026: if (JumpEqual) goto L0072;
            L0028: RemoveItem(player, 0x69);
            L0034: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L0049: ShowMessage(player, doMsgs, String04C1); // Invisible hands take Cleowyn's Crown and place it in a niche in the wall.
            L0056: ShowMessage(player, doMsgs, String050B); // The niche disappears.
            L0063: ShowMessage(player, doMsgs, String0521); // You hear a rumbling sound in the distance
            L0070: goto L007F;
            L0072: ShowMessage(player, doMsgs, String054B); // There is a niche in the wall which seems designed to hold a crown.
            L007F: return; // RETURN;
        }

        private void FnCRWNDOOR_07(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeMap, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L0064;
            L0019: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0037: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0055: ShowMessage(player, doMsgs, String058E); // Returning the Crown of Cleowyn reveals a secret door in the west wall!
            L0062: goto L0081;
            L0064: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0081: return; // RETURN;
        }

        private void FnROBENICH_08(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x78);
            L0011: if (JumpEqual) goto L0029;
            L0013: Compare(GetFlag(player, FlagTypeMap, 0x01), 0x0001);
            L0027: if (JumpEqual) goto L003E;
            L0029: ax = IsFlagOn(player, FlagTypeMap, 0x02);
            L003C: if (JumpEqual) goto L0088;
            L003E: RemoveItem(player, 0x78);
            L004A: SetFlag(player, FlagTypeMap, 0x02, 0x01);
            L005F: ShowMessage(player, doMsgs, String05D5); // Cleowyn's Robe flies out of your hands and into a niche in the wall.
            L006C: ShowMessage(player, doMsgs, String061A); // The niche disappears.
            L0079: ShowMessage(player, doMsgs, String0630); // You hear a rumbling sound in the distance.
            L0086: goto L00AE;
            L0088: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L00A1: ShowMessage(player, doMsgs, String065B); // There is a niche in the wall which seems designed to hold a robe.
            L00AE: return; // RETURN;
        }

        private void FnROBEDOOR_09(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeMap, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L005C;
            L0019: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0033: SetWallItem(player, 0x01, GetCurrentTile(player), 0x02);
            L004D: ShowMessage(player, doMsgs, String069D); // Returning the Robe of Cleowyn reveals a secret door in the east wall.
            L005A: goto L0079;
            L005C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0079: return; // RETURN;
        }

        private void FnSCEPNICH_0A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, YsIndexes.ItemCleowynsSceptre);
            L0011: if (JumpEqual) goto L003D;
            L0013: ax = IsFlagOn(player, FlagTypeMap, 0x01);
            L0026: if (JumpEqual) goto L003D;
            L0028: ax = IsFlagOn(player, FlagTypeMap, 0x02);
            L003B: if (JumpNotEqual) goto L0055;
            L003D: ax = IsFlagOn(player, FlagTypeMap, 0x03);
            L0050: if (JumpNotEqual) goto L0055;
            L0052: goto L00E0;
            L0055: RemoveItem(player, YsIndexes.ItemCleowynsSceptre);
            L0061: SetFlag(player, FlagTypeMap, 0x03, 0x01);
            L0076: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0090: SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            L00AA: ShowMessage(player, doMsgs, String06E3); // Cleowyn's Scepter is taken from you by spectral hands and is placed in a niche in the wall.
            L00B7: ShowMessage(player, doMsgs, String073F); // The spirit of King Cleowyn whispers -
            L00C4: ShowMessage(player, doMsgs, String0765); // 'Well done!  The reward is yours for the taking, if you dare claim it.
            L00D1: ShowMessage(player, doMsgs, String07AC); // The door to the tomb opens.
            L00DE: goto L0106;
            L00E0: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L00F9: ShowMessage(player, doMsgs, String07C8); // There is a niche in the wall which seems designed to hold a scepter.
            L0106: return; // RETURN;
        }

        private void FnGOLDAENC_0C(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumGold), 0x0001);
            L0017: if (JumpNotEqual) goto L0048;
            L0019: ShowMessage(player, doMsgs, String080D); // The room you enter is cold as ice.
            L0026: AddTreasure(player, 0x008C, 0x00, 0x00, 0x00, 0xA9, 0xCC);
            L0046: goto L008B;
            L0048: AddTreasure(player, 0x0FA0, 0x00, 0x00, 0xCD, 0xB7, 0xD0);
            L0069: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumGold, 0x01);
            L007E: ShowMessage(player, doMsgs, String0830); // An Ice Lion stands over a torn bag of gold.
            L008B: Compare(PartyCount(player), 0x0001);
            L0096: if (JumpNotEqual) goto L00BF;
            L0098: AddEncounter(player, 0x01, 0x19);
            L00AA: AddEncounter(player, 0x02, 0x19);
            L00BC: goto L0182;
            L00BF: Compare(PartyCount(player), 0x0002);
            L00CA: if (JumpNotEqual) goto L0116;
            L00CC: AddEncounter(player, 0x01, 0x19);
            L00DE: AddEncounter(player, 0x02, 0x19);
            L00F0: AddEncounter(player, 0x03, 0x1A);
            L0102: AddEncounter(player, 0x04, 0x1A);
            L0114: goto L0182;
            L0116: AddEncounter(player, 0x01, 0x1A);
            L0128: AddEncounter(player, 0x02, 0x1A);
            L013A: AddEncounter(player, 0x03, 0x1A);
            L014C: AddEncounter(player, 0x04, 0x1A);
            L015E: AddEncounter(player, 0x05, 0x19);
            L0170: AddEncounter(player, 0x06, 0x19);
            L0182: return; // RETURN;
        }

        private void FnGOLDBENC_0D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumGold1), 0x0001);
            L0017: if (JumpNotEqual) goto L0048;
            L0019: ShowMessage(player, doMsgs, String085C); // The room stinks of rotten meat.
            L0026: AddTreasure(player, 0x00B4, 0x00, 0x00, 0x00, 0xB6, 0xCF);
            L0046: goto L008A;
            L0048: AddTreasure(player, 0x0BB8, 0x00, 0x00, 0x00, 0xD0, 0xAA);
            L0068: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumGold1, 0x01);
            L007D: ShowMessage(player, doMsgs, String087C); // Something kicks gold across the floor as it charges you.
            L008A: Compare(PartyCount(player), 0x0001);
            L0095: if (JumpEqual) goto L00A4;
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpNotEqual) goto L00CB;
            L00A4: AddEncounter(player, 0x01, 0x23);
            L00B6: AddEncounter(player, 0x02, 0x24);
            L00C8: goto L0158;
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpNotEqual) goto L0110;
            L00D8: AddEncounter(player, 0x01, 0x23);
            L00EA: AddEncounter(player, 0x02, 0x23);
            L00FC: AddEncounter(player, 0x03, 0x23);
            L010E: goto L0158;
            L0110: AddEncounter(player, 0x01, 0x23);
            L0122: AddEncounter(player, 0x02, 0x24);
            L0134: AddEncounter(player, 0x03, 0x24);
            L0146: AddEncounter(player, 0x04, 0x23);
            L0158: return; // RETURN;
        }

        private void FnSPCMONSA_0E(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String08B5); // Lizardites guard this area.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0044;
            L001D: AddEncounter(player, 0x01, 0x1E);
            L002F: AddEncounter(player, 0x02, 0x1E);
            L0041: goto L0107;
            L0044: Compare(PartyCount(player), 0x0002);
            L004F: if (JumpNotEqual) goto L009B;
            L0051: AddEncounter(player, 0x01, 0x1E);
            L0063: AddEncounter(player, 0x02, 0x1E);
            L0075: AddEncounter(player, 0x03, 0x1E);
            L0087: AddEncounter(player, 0x04, 0x1E);
            L0099: goto L0107;
            L009B: AddEncounter(player, 0x01, 0x1E);
            L00AD: AddEncounter(player, 0x02, 0x1E);
            L00BF: AddEncounter(player, 0x03, 0x1E);
            L00D1: AddEncounter(player, 0x04, 0x1E);
            L00E3: AddEncounter(player, 0x05, 0x1E);
            L00F5: AddEncounter(player, 0x06, 0x1E);
            L0107: return; // RETURN;
        }

        private void FnSPCMONSB_0F(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String08D1); // Giants guard the corridor.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0032;
            L001D: AddEncounter(player, 0x01, 0x25);
            L002F: goto L0102;
            L0032: Compare(PartyCount(player), 0x0002);
            L003D: if (JumpEqual) goto L004C;
            L003F: Compare(PartyCount(player), 0x0003);
            L004A: if (JumpNotEqual) goto L0096;
            L004C: AddEncounter(player, 0x01, 0x25);
            L005E: AddEncounter(player, 0x02, 0x25);
            L0070: AddEncounter(player, 0x03, 0x25);
            L0082: AddEncounter(player, 0x05, 0x25);
            L0094: goto L0102;
            L0096: AddEncounter(player, 0x01, 0x25);
            L00A8: AddEncounter(player, 0x02, 0x25);
            L00BA: AddEncounter(player, 0x03, 0x25);
            L00CC: AddEncounter(player, 0x04, 0x25);
            L00DE: AddEncounter(player, 0x05, 0x25);
            L00F0: AddEncounter(player, 0x06, 0x25);
            L0102: return; // RETURN;
        }

        private void FnSPCMONSC_10(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x27);
            L0022: AddEncounter(player, 0x05, 0x28);
            L0034: goto L0176;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L008F;
            L0044: AddEncounter(player, 0x01, 0x27);
            L0056: AddEncounter(player, 0x02, 0x27);
            L0068: AddEncounter(player, 0x05, 0x28);
            L007A: AddEncounter(player, 0x06, 0x28);
            L008C: goto L0176;
            L008F: Compare(PartyCount(player), 0x0003);
            L009A: if (JumpNotEqual) goto L010A;
            L009C: AddEncounter(player, 0x01, 0x27);
            L00AE: AddEncounter(player, 0x02, 0x27);
            L00C0: AddEncounter(player, 0x03, 0x27);
            L00D2: AddEncounter(player, 0x04, 0x27);
            L00E4: AddEncounter(player, 0x05, 0x28);
            L00F6: AddEncounter(player, 0x06, 0x28);
            L0108: goto L0176;
            L010A: AddEncounter(player, 0x01, 0x27);
            L011C: AddEncounter(player, 0x02, 0x27);
            L012E: AddEncounter(player, 0x03, 0x28);
            L0140: AddEncounter(player, 0x04, 0x28);
            L0152: AddEncounter(player, 0x05, 0x28);
            L0164: AddEncounter(player, 0x06, 0x28);
            L0176: return; // RETURN;
        }

        private void FnPAYOFENC_11(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            if (GetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumCryptState) == 0x02) {
                // There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'
                ShowMessage(player, doMsgs, "The bones of King Cleowyn lie once more within the crypt.");
                return;
            }
            if (GetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumCryptState) == 0x01) {
                if (HasItem(player, YsIndexes.ItemCleowynsBones) == 0x00) {
                    ShowMessage(player, doMsgs, String08EC); // There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'
                    return;
                }
                RemoveItem(player, YsIndexes.ItemCleowynsBones);
                GiveItem(player, 0x96);
                SetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumCryptState, 0x02);
                AddExperience(player, 0x000B71B0);
                ShowMessage(player, doMsgs, String09BA); // As you place Cleowyn's bones in the crypt, Cleowyn's spirit whispers to you -
                ShowMessage(player, doMsgs, String0A08); // 'My thanks to you. You certainly took your time finding my bones. Here is the Netherworld Medallion. Now go away and don't bother me again.'
                return;
            }
            SetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumCryptState, 0x01);
            GiveItem(player, 0x0A);
            GiveItem(player, 0x21);
            GiveItem(player, 0x48);
            GiveItem(player, 0x7C);
            AddExperience(player, 0x0003D090);
            ShowMessage(player, doMsgs, String0B63); // You find the Crypt of King Cleowyn and open it. Inside is the Sword of the Crypt, the Mourning Star, the Bow of Sorrow, and Galabryan Chainmail.
        }

        private void FnITEMAENC_12(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumItems), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(player, doMsgs, String0BF4); // Polar Bears wander the empty room.
            L0026: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0045: goto L008B;
            L0047: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagMausoleumItems, 0x01);
            L005C: AddTreasure(player, 0x1B58, 0x00, 0xD0, 0xB2, 0xAA, 0xB0);
            L007E: ShowMessage(player, doMsgs, String0C17); // A Polar Bear plays with a pile of stuff.
            L008B: Compare(PartyCount(player), 0x0001);
            L0096: if (JumpEqual) goto L00A5;
            L0098: Compare(PartyCount(player), 0x0002);
            L00A3: if (JumpNotEqual) goto L00CB;
            L00A5: AddEncounter(player, 0x01, 0x1B);
            L00B7: AddEncounter(player, 0x02, 0x1B);
            L00C9: goto L0113;
            L00CB: AddEncounter(player, 0x01, 0x1B);
            L00DD: AddEncounter(player, 0x02, 0x1B);
            L00EF: AddEncounter(player, 0x03, 0x1B);
            L0101: AddEncounter(player, 0x04, 0x1B);
            L0113: return; // RETURN;
        }

        private void FnITEMBENC_13(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xA1);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String0C40); // Hell Wolves snarl at you.
            L0020: AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0xD0, 0xA1);
            L0061: ShowMessage(player, doMsgs, String0C5A); // A Hell Wolf kicks an object aside as it leaps at you.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(player), 0x0002);
            L0086: if (JumpNotEqual) goto L00AE;
            L0088: AddEncounter(player, 0x01, 0x1F);
            L009A: AddEncounter(player, 0x02, 0x1F);
            L00AC: goto L00F6;
            L00AE: AddEncounter(player, 0x01, 0x1F);
            L00C0: AddEncounter(player, 0x02, 0x1F);
            L00D2: AddEncounter(player, 0x03, 0x1F);
            L00E4: AddEncounter(player, 0x04, 0x1F);
            L00F6: return; // RETURN;
        }

        private void FnBADMNSTR_14(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x1C);
            L0022: AddEncounter(player, 0x02, 0x1E);
            L0034: goto L0176;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L008F;
            L0044: AddEncounter(player, 0x01, 0x1D);
            L0056: AddEncounter(player, 0x02, 0x1D);
            L0068: AddEncounter(player, 0x03, 0x1E);
            L007A: AddEncounter(player, 0x04, 0x1E);
            L008C: goto L0176;
            L008F: Compare(PartyCount(player), 0x0003);
            L009A: if (JumpNotEqual) goto L010A;
            L009C: AddEncounter(player, 0x01, 0x1C);
            L00AE: AddEncounter(player, 0x02, 0x1C);
            L00C0: AddEncounter(player, 0x03, 0x1D);
            L00D2: AddEncounter(player, 0x04, 0x1D);
            L00E4: AddEncounter(player, 0x05, 0x1E);
            L00F6: AddEncounter(player, 0x06, 0x1E);
            L0108: goto L0176;
            L010A: AddEncounter(player, 0x01, 0x1E);
            L011C: AddEncounter(player, 0x02, 0x1E);
            L012E: AddEncounter(player, 0x03, 0x1E);
            L0140: AddEncounter(player, 0x04, 0x1E);
            L0152: AddEncounter(player, 0x05, 0x1D);
            L0164: AddEncounter(player, 0x06, 0x1D);
            L0176: return; // RETURN;
        }

        private void FnTERMNSTR_15(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x1F);
            L0022: AddEncounter(player, 0x02, 0x22);
            L0034: goto L0188;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L00A1;
            L0044: AddEncounter(player, 0x01, 0x20);
            L0056: AddEncounter(player, 0x02, 0x22);
            L0068: AddEncounter(player, 0x03, 0x20);
            L007A: AddEncounter(player, 0x04, 0x22);
            L008C: AddEncounter(player, 0x05, 0x21);
            L009E: goto L0188;
            L00A1: Compare(PartyCount(player), 0x0003);
            L00AC: if (JumpNotEqual) goto L011C;
            L00AE: AddEncounter(player, 0x01, 0x21);
            L00C0: AddEncounter(player, 0x02, 0x22);
            L00D2: AddEncounter(player, 0x03, 0x21);
            L00E4: AddEncounter(player, 0x04, 0x22);
            L00F6: AddEncounter(player, 0x05, 0x21);
            L0108: AddEncounter(player, 0x06, 0x22);
            L011A: goto L0188;
            L011C: AddEncounter(player, 0x01, 0x22);
            L012E: AddEncounter(player, 0x02, 0x22);
            L0140: AddEncounter(player, 0x03, 0x22);
            L0152: AddEncounter(player, 0x04, 0x22);
            L0164: AddEncounter(player, 0x05, 0x21);
            L0176: AddEncounter(player, 0x06, 0x21);
            L0188: return; // RETURN;
        }

        private void FnGATEMESS_16(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0C90); // This gateway leads to THE GREAT CORRIDOR.
            L0010: return; // RETURN;
        }

        private void FnTELEMESA_17(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0CBA); // There is a teleport in the east wall.
            L0010: return; // RETURN;
        }

        private void FnTELEMESB_18(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowMessage(player, doMsgs, String0CE0); // There is a teleport in the west wall.
            L0018: return; // RETURN;
        }

        private void FnNPCCHATA_19(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0D06); // You encounter a Gremlin Cleric.
            L0010: ShowPortrait(player, 0x002A);
            L001D: Compare(GetRandom(0x000F), 0x000D);
            L002D: if (JumpAbove) goto L0065;
            L002F: ShowMessage(player, doMsgs, String0D26); // Listen carefully, friend. Be careful where you place the possessions Cleowyn demands. Use Crown before Robe before Scepter.
            L003C: ShowMessage(player, doMsgs, String0DA2); // Someone in your group must always remain in the Mausoleum until all three items are placed and the tomb is opened.
            L0049: ShowMessage(player, doMsgs, String0E15); // Otherwise, imps will steal the treasures away and hide them again.  They love to torment adventurers and Cleowyn's spirit.
            L0056: ShowMessage(player, doMsgs, String0E90); // Remember to leave one person at all times and to reform your group before continuing your quest.
            L0063: goto L0072;
            L0065: ShowMessage(player, doMsgs, String0EF1); // The Gremlin Cleric turns away as you approach her.
            L0072: return; // RETURN;
        }

        private void FnNPCCHATB_1A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0F24); // You encounter a Halfling Knight.
            L0010: ShowPortrait(player, 0x001D);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0F45); // The longest routes through this Mausoleum are the least rewarding.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String0F88); // The Halfling Knight looks at you once and then continues polishing her shield.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_1B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0FD7); // You encounter an Elf Ranger.
            L0010: ShowPortrait(player, 0x001F);
            L001D: Compare(GetRandom(0x000F), 0x000B);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0FF4); // The night the volcano erupted, the wizard Arnakkian Slowfoot threw a great feast. All who attended died in the eruption. They died at their games of cards and gambling. Some, it is said, were transformed into the monsters who inhabit the dungeon.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String10EB); // The Elf Ranger abruptly walks away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_1C(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String110F); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(player, 0x0019);
            L001D: Compare(GetRandom(0x000F), 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String1130); // Cleowyn's bones are guarded by the Snow Elves, I have heard. Whether or not it is worth returning the king's bones to the Mausoleum is much debated, for the imps will seize them again and return them to the elves.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String1206); // The Gnome Barbarian opens his mouth to speak, but he forgets what he planned to say.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATE_1D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String125B); // You encounter a Human Thief.
            L0010: ShowPortrait(player, 0x0022);
            L001D: Compare(GetRandom(0x000F), 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String1278); // If you find King Cleowyn's quarters, you will find a shortcut back to his Palace. Be careful where you tread, lest you leave his quarters unrewarded.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String130E); // The Human Thief darts away as you approach.
            L004B: return; // RETURN;
        }

        private void FnMINOTAUR_1E(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(player, 0x01, 0x26);
            L0022: goto L00D6;
            L0025: Compare(PartyCount(player), 0x0002);
            L0030: if (JumpNotEqual) goto L006A;
            L0032: AddEncounter(player, 0x01, 0x26);
            L0044: AddEncounter(player, 0x02, 0x26);
            L0056: AddEncounter(player, 0x03, 0x26);
            L0068: goto L00D6;
            L006A: AddEncounter(player, 0x01, 0x26);
            L007C: AddEncounter(player, 0x02, 0x26);
            L008E: AddEncounter(player, 0x03, 0x26);
            L00A0: AddEncounter(player, 0x04, 0x26);
            L00B2: AddEncounter(player, 0x05, 0x26);
            L00C4: AddEncounter(player, 0x06, 0x26);
            L00D6: return; // RETURN;
        }

    }
}
