namespace ZCF.Scripts.Maps {
    class YserMap06 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You found a hidden door in the east wall.";
        private const string String0426 = "Rogues are splitting up some gold they stole.";
        private const string String0454 = "You take a sip from the fountain, but nothing happens.";
        private const string String048B = "You take a sip from the Healing Fountain and feel your Health improve quite a bit.";
        private const string String04DE = "You skillfully pick the door lock.";
        private const string String0501 = "The door is locked.";
        private const string String0515 = "Minotaurs charge you.";
        private const string String052B = "A Minotaur teases you by holding a bag of gold just out of reach.";
        private const string String056D = "Huge beings lumber into sight.";
        private const string String058C = "You have entered a Rogue encampment.";
        private const string String05B1 = "You encounter marauding Hobgoblins.";
        private const string String05D5 = "The sound of hooves on stone alerts you to danger.";
        private const string String0608 = "Gruff laughter surrounds you.";
        private const string String0626 = "The stairs through the south gateway lead upwards.";
        private const string String0659 = "Through the west gateway are stairs leading upwards.";
        private const string String068E = "The stairs through the north gateway lead upwards.";
        private const string String06C1 = "The stairs past the north gateway lead up a level.";
        private const string String06F4 = "There is a teleport in the east wall.";
        private const string String071A = "There is a teleport in the west wall.";
        private const string String0740 = "There is a teleport in the west wall.";
        private const string String0766 = "You encounter a Gnome Thief.";
        private const string String0783 = "There is more to this basement than first meets the eye. Someday I will learn the secret of what lies behind the thick, silent walls that line this corridor.";
        private const string String0821 = "The Gnome Thief smiles enigmatically and ducks into the shadows.";
        private const string String0862 = "You encounter a Human Barbarian.";
        private const string String0883 = "As much as I despise orcs, I sometimes find it useful to have them in my party. Indeed, you will frequently have to work with races and Guilds you would otherwise ignore, if you wish to solve the many mysteries of this dungeon.";
        private const string String0967 = "The Human Barbarian raps you with his club and trudges away.";
        private const string String09A4 = "You encounter an Orc Knight.";
        private const string String09C1 = "A colleague told me he encountered a strange elfin race far down in the dungeon. He would not say much else, other than that he knew why cold-loving creatures were to be found inside a volcano.";
        private const string String0A83 = "The Orc Knight bows graciously and walks away.";
        private const string String0AB2 = "You encounter an Elf Cleric.";
        private const string String0ACF = "I stumbled over a marble block not long ago. On it were the words - Arnakkian Slowfoot, Wizard to the King.";
        private const string String0B3B = "The Elf Cleric sighs mournfully and massages a stubbed toe.";
        private const string String0B77 = "You encounter a Human Thief.";
        private const string String0B94 = "To the east of the Rune Room on level three can be found the Wizards' Challenge. It is quite a challenge, too.";
        private const string String0C03 = "I have found several short cuts in the Wizards' Challenge.";
        private const string String0C3E = "The Human Thief points at something behind you. While your back is turned, she sneaks away.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnSTRSTELE_01;
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x01, 0x04, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnSTAIRSUP_02;
        private void FnSTAIRSUP_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x2E, 0x06, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnTELPORTE_03;
        private void FnTELPORTE_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x07, 0x01, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnTELPORTW_04;
        private void FnTELPORTW_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0x04, 0x01, 0x02);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnHIDNDOOR_05;
        private void FnHIDNDOOR_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x0006);
            L0012: if (result.above or result.equal) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (result.notequal) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (result.equal) goto L00A0;
            L0063: SetMove2C(party, 0x01, 0x02, 0x02);
            L0079: Push(02);
            L007D: ax = GetNextTile20(party);
            L0084: PushStack(ax);
            L0085: Push(01);
            L0089: SetUnblocked30(party);
            L0093: ShowMessage(party, String03FC); // You found a hidden door in the east wall.
            L00A0: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnGOLDAENC_06;
        private void FnGOLDAENC_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x16);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L0039;
            L0018: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0037: goto L007A;
            L0039: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0058: SetState00(party, 0x02, 0x16, 0x01);
            L006D: ShowMessage(party, String0426); // Rogues are splitting up some gold they stole.
            L007A: ax = PartyCount(party);
            L0082: compare(ax, 0x0001);
            L0085: if (result.notequal) goto L00AE;
            L0087: AddEncounter(party, 0x1D, 0x01);
            L0099: AddEncounter(party, 0x0A, 0x02);
            L00AB: goto L01C9;
            L00AE: ax = PartyCount(party);
            L00B6: compare(ax, 0x0002);
            L00B9: if (result.notequal) goto L00F4;
            L00BB: AddEncounter(party, 0x1E, 0x01);
            L00CD: AddEncounter(party, 0x05, 0x02);
            L00DF: AddEncounter(party, 0x0D, 0x03);
            L00F1: goto L01C9;
            L00F4: ax = PartyCount(party);
            L00FC: compare(ax, 0x0003);
            L00FF: if (result.notequal) goto L015D;
            L0101: AddEncounter(party, 0x1F, 0x01);
            L0113: AddEncounter(party, 0x0B, 0x02);
            L0125: AddEncounter(party, 0x04, 0x03);
            L0137: AddEncounter(party, 0x07, 0x04);
            L0149: AddEncounter(party, 0x0D, 0x05);
            L015B: goto L01C9;
            L015D: AddEncounter(party, 0x20, 0x01);
            L016F: AddEncounter(party, 0x0B, 0x02);
            L0181: AddEncounter(party, 0x06, 0x03);
            L0193: AddEncounter(party, 0x08, 0x04);
            L01A5: AddEncounter(party, 0x0A, 0x05);
            L01B7: AddEncounter(party, 0x0D, 0x06);
            L01C9: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnFOUNTAIN_07;
        private void FnFOUNTAIN_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x1E);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0035;
            L0019: ShowPortrait(party, 0x0042);
            L0026: ShowMessage(party, String0454); // You take a sip from the fountain, but nothing happens.
            L0033: goto L0075;
            L0035: ax = GetMaxHits74(party);
            L003C: AddHealth94(party, ax);
            L0046: SetState00(party, 0x02, 0x1E, 0x01);
            L005B: ShowPortrait(party, 0x0042);
            L0068: ShowMessage(party, String048B); // You take a sip from the Healing Fountain and feel your Health improve quite a bit.
            L0075: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnLKPKDOOR_08;
        private void FnLKPKDOOR_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xBF, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0006);
            L0027: if (result.below) goto L0074;
            L0029: Push(01);
            L002D: ax = GetFacing24(party);
            L0034: PushStack(ax);
            L0035: ax = GetNextTile20(party);
            L003C: PushStack(ax);
            L003D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: Push(01);
            L005B: SetUnblocked30(party);
            L0065: ShowMessage(party, String04DE); // You skillfully pick the door lock.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String0501); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnSTRMNSTR_09;
        private void FnSTRMNSTR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: goto L0140;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L006B;
            L0032: AddEncounter(party, 0x19, 0x01);
            L0044: AddEncounter(party, 0x1A, 0x02);
            L0056: AddEncounter(party, 0x19, 0x03);
            L0068: goto L0140;
            L006B: ax = PartyCount(party);
            L0073: compare(ax, 0x0003);
            L0076: if (result.notequal) goto L00D4;
            L0078: AddEncounter(party, 0x1A, 0x01);
            L008A: AddEncounter(party, 0x1A, 0x02);
            L009C: AddEncounter(party, 0x1B, 0x03);
            L00AE: AddEncounter(party, 0x1B, 0x04);
            L00C0: AddEncounter(party, 0x19, 0x05);
            L00D2: goto L0140;
            L00D4: AddEncounter(party, 0x1C, 0x01);
            L00E6: AddEncounter(party, 0x1C, 0x02);
            L00F8: AddEncounter(party, 0x1C, 0x03);
            L010A: AddEncounter(party, 0x1C, 0x04);
            L011C: AddEncounter(party, 0x19, 0x05);
            L012E: AddEncounter(party, 0x19, 0x06);
            L0140: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnVTFMNSTR_0A;
        private void FnVTFMNSTR_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1E, 0x01);
            L0022: AddEncounter(party, 0x1E, 0x02);
            L0034: goto L0140;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L007D;
            L0044: AddEncounter(party, 0x1D, 0x01);
            L0056: AddEncounter(party, 0x1E, 0x02);
            L0068: AddEncounter(party, 0x20, 0x03);
            L007A: goto L0140;
            L007D: ax = PartyCount(party);
            L0085: compare(ax, 0x0003);
            L0088: if (result.notequal) goto L00D4;
            L008A: AddEncounter(party, 0x20, 0x01);
            L009C: AddEncounter(party, 0x20, 0x02);
            L00AE: AddEncounter(party, 0x1D, 0x03);
            L00C0: AddEncounter(party, 0x1D, 0x04);
            L00D2: goto L0140;
            L00D4: AddEncounter(party, 0x1D, 0x01);
            L00E6: AddEncounter(party, 0x1D, 0x02);
            L00F8: AddEncounter(party, 0x1E, 0x03);
            L010A: AddEncounter(party, 0x1F, 0x04);
            L011C: AddEncounter(party, 0x20, 0x05);
            L012E: AddEncounter(party, 0x20, 0x06);
            L0140: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnSTRMNSTR_0B;
        private void FnSTRMNSTR_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x21, 0x01);
            L0022: goto L011C;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L0059;
            L0032: AddEncounter(party, 0x21, 0x01);
            L0044: AddEncounter(party, 0x21, 0x02);
            L0056: goto L011C;
            L0059: ax = PartyCount(party);
            L0061: compare(ax, 0x0003);
            L0064: if (result.notequal) goto L00B0;
            L0066: AddEncounter(party, 0x24, 0x01);
            L0078: AddEncounter(party, 0x24, 0x02);
            L008A: AddEncounter(party, 0x21, 0x03);
            L009C: AddEncounter(party, 0x23, 0x04);
            L00AE: goto L011C;
            L00B0: AddEncounter(party, 0x23, 0x01);
            L00C2: AddEncounter(party, 0x23, 0x02);
            L00D4: AddEncounter(party, 0x24, 0x03);
            L00E6: AddEncounter(party, 0x24, 0x04);
            L00F8: AddEncounter(party, 0x22, 0x05);
            L010A: AddEncounter(party, 0x22, 0x06);
            L011C: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnBADMNSTR_0C;
        private void FnBADMNSTR_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x25, 0x01);
            L0022: goto L0140;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L006B;
            L0032: AddEncounter(party, 0x26, 0x01);
            L0044: AddEncounter(party, 0x26, 0x02);
            L0056: AddEncounter(party, 0x28, 0x05);
            L0068: goto L0140;
            L006B: ax = PartyCount(party);
            L0073: compare(ax, 0x0003);
            L0076: if (result.notequal) goto L00D4;
            L0078: AddEncounter(party, 0x25, 0x01);
            L008A: AddEncounter(party, 0x25, 0x02);
            L009C: AddEncounter(party, 0x27, 0x03);
            L00AE: AddEncounter(party, 0x27, 0x04);
            L00C0: AddEncounter(party, 0x28, 0x05);
            L00D2: goto L0140;
            L00D4: AddEncounter(party, 0x27, 0x01);
            L00E6: AddEncounter(party, 0x27, 0x02);
            L00F8: AddEncounter(party, 0x25, 0x03);
            L010A: AddEncounter(party, 0x25, 0x04);
            L011C: AddEncounter(party, 0x28, 0x05);
            L012E: AddEncounter(party, 0x28, 0x06);
            L0140: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnGOLDBENC_0D;
        private void FnGOLDBENC_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x17);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String0515); // Minotaurs charge you.
            L0026: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0066: SetState00(party, 0x02, 0x17, 0x01);
            L007B: ShowMessage(party, String052B); // A Minotaur teases you by holding a bag of gold just out of reach.
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00AA;
            L0095: AddEncounter(party, 0x22, 0x01);
            L00A7: goto L016B;
            L00AA: ax = PartyCount(party);
            L00B2: compare(ax, 0x0002);
            L00B5: if (result.notequal) goto L00DE;
            L00B7: AddEncounter(party, 0x21, 0x01);
            L00C9: AddEncounter(party, 0x22, 0x02);
            L00DB: goto L016B;
            L00DE: ax = PartyCount(party);
            L00E6: compare(ax, 0x0003);
            L00E9: if (result.notequal) goto L0123;
            L00EB: AddEncounter(party, 0x21, 0x01);
            L00FD: AddEncounter(party, 0x22, 0x02);
            L010F: AddEncounter(party, 0x23, 0x03);
            L0121: goto L016B;
            L0123: AddEncounter(party, 0x23, 0x01);
            L0135: AddEncounter(party, 0x24, 0x02);
            L0147: AddEncounter(party, 0x25, 0x03);
            L0159: AddEncounter(party, 0x21, 0x04);
            L016B: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnWEAPENC_0E;
        private void FnWEAPENC_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x18);
            L0011: if (result.equal) goto L0065;
            L0013: ax = HasItem50(party, 0x30);
            L0021: if (result.equal) goto L0044;
            L0023: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x30);
            L0063: goto L00B6;
            L0065: ax = HasItem50(party, 0x30);
            L0073: if (result.equal) goto L0096;
            L0075: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x18);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x30, 0x18);
            L00B6: ShowMessage(party, String056D); // Huge beings lumber into sight.
            L00C3: ax = PartyCount(party);
            L00CB: compare(ax, 0x0001);
            L00CE: if (result.notequal) goto L00F7;
            L00D0: AddEncounter(party, 0x1A, 0x01);
            L00E2: AddEncounter(party, 0x19, 0x02);
            L00F4: goto L0236;
            L00F7: ax = PartyCount(party);
            L00FF: compare(ax, 0x0002);
            L0102: if (result.notequal) goto L014F;
            L0104: AddEncounter(party, 0x1A, 0x01);
            L0116: AddEncounter(party, 0x1A, 0x02);
            L0128: AddEncounter(party, 0x19, 0x03);
            L013A: AddEncounter(party, 0x19, 0x04);
            L014C: goto L0236;
            L014F: ax = PartyCount(party);
            L0157: compare(ax, 0x0003);
            L015A: if (result.notequal) goto L01CA;
            L015C: AddEncounter(party, 0x19, 0x01);
            L016E: AddEncounter(party, 0x19, 0x02);
            L0180: AddEncounter(party, 0x1B, 0x03);
            L0192: AddEncounter(party, 0x1B, 0x04);
            L01A4: AddEncounter(party, 0x1A, 0x05);
            L01B6: AddEncounter(party, 0x1A, 0x06);
            L01C8: goto L0236;
            L01CA: AddEncounter(party, 0x1B, 0x01);
            L01DC: AddEncounter(party, 0x1B, 0x02);
            L01EE: AddEncounter(party, 0x1B, 0x03);
            L0200: AddEncounter(party, 0x1B, 0x04);
            L0212: AddEncounter(party, 0x1C, 0x05);
            L0224: AddEncounter(party, 0x1C, 0x06);
            L0236: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnARMORENC_0F;
        private void FnARMORENC_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x7F);
            L0011: if (result.equal) goto L0034;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0032: goto L0053;
            L0034: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0x7F);
            L0053: ShowMessage(party, String058C); // You have entered a Rogue encampment.
            L0060: ax = PartyCount(party);
            L0068: compare(ax, 0x0001);
            L006B: if (result.notequal) goto L0082;
            L006D: AddEncounter(party, 0x03, 0x01);
            L007F: goto L0143;
            L0082: ax = PartyCount(party);
            L008A: compare(ax, 0x0002);
            L008D: if (result.notequal) goto L00B6;
            L008F: AddEncounter(party, 0x03, 0x01);
            L00A1: AddEncounter(party, 0x0D, 0x02);
            L00B3: goto L0143;
            L00B6: ax = PartyCount(party);
            L00BE: compare(ax, 0x0003);
            L00C1: if (result.notequal) goto L00FB;
            L00C3: AddEncounter(party, 0x1E, 0x01);
            L00D5: AddEncounter(party, 0x11, 0x02);
            L00E7: AddEncounter(party, 0x04, 0x03);
            L00F9: goto L0143;
            L00FB: AddEncounter(party, 0x20, 0x01);
            L010D: AddEncounter(party, 0x05, 0x02);
            L011F: AddEncounter(party, 0x0F, 0x03);
            L0131: AddEncounter(party, 0x0D, 0x06);
            L0143: // RETURN;
        }

        private override MapEventHandler MapEvent10 => FnMAGICENC_10;
        private void FnMAGICENC_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x8B);
            L0011: if (result.equal) goto L0065;
            L0013: ax = HasItem50(party, 0x91);
            L0021: if (result.equal) goto L0044;
            L0023: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x01);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x91);
            L0063: goto L00B6;
            L0065: ax = HasItem50(party, 0x91);
            L0073: if (result.equal) goto L0096;
            L0075: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x8B);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x91, 0x8B);
            L00B6: ShowMessage(party, String05B1); // You encounter marauding Hobgoblins.
            L00C3: ax = PartyCount(party);
            L00CB: compare(ax, 0x0001);
            L00CE: if (result.notequal) goto L00F7;
            L00D0: AddEncounter(party, 0x25, 0x01);
            L00E2: AddEncounter(party, 0x28, 0x02);
            L00F4: goto L0212;
            L00F7: ax = PartyCount(party);
            L00FF: compare(ax, 0x0002);
            L0102: if (result.notequal) goto L013D;
            L0104: AddEncounter(party, 0x25, 0x01);
            L0116: AddEncounter(party, 0x26, 0x02);
            L0128: AddEncounter(party, 0x28, 0x03);
            L013A: goto L0212;
            L013D: ax = PartyCount(party);
            L0145: compare(ax, 0x0003);
            L0148: if (result.notequal) goto L01A6;
            L014A: AddEncounter(party, 0x26, 0x01);
            L015C: AddEncounter(party, 0x26, 0x02);
            L016E: AddEncounter(party, 0x27, 0x03);
            L0180: AddEncounter(party, 0x27, 0x04);
            L0192: AddEncounter(party, 0x28, 0x05);
            L01A4: goto L0212;
            L01A6: AddEncounter(party, 0x27, 0x01);
            L01B8: AddEncounter(party, 0x27, 0x02);
            L01CA: AddEncounter(party, 0x25, 0x03);
            L01DC: AddEncounter(party, 0x25, 0x04);
            L01EE: AddEncounter(party, 0x28, 0x05);
            L0200: AddEncounter(party, 0x28, 0x06);
            L0212: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnITEMBENC_11;
        private void FnITEMBENC_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x52);
            L0011: if (result.equal) goto L0034;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0x13);
            L0032: goto L0053;
            L0034: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x52);
            L0053: ShowMessage(party, String05D5); // The sound of hooves on stone alerts you to danger.
            L0060: ax = PartyCount(party);
            L0068: compare(ax, 0x0001);
            L006B: if (result.notequal) goto L0082;
            L006D: AddEncounter(party, 0x22, 0x01);
            L007F: goto L0143;
            L0082: ax = PartyCount(party);
            L008A: compare(ax, 0x0002);
            L008D: if (result.notequal) goto L00B6;
            L008F: AddEncounter(party, 0x22, 0x01);
            L00A1: AddEncounter(party, 0x22, 0x02);
            L00B3: goto L0143;
            L00B6: ax = PartyCount(party);
            L00BE: compare(ax, 0x0003);
            L00C1: if (result.notequal) goto L00FB;
            L00C3: AddEncounter(party, 0x23, 0x01);
            L00D5: AddEncounter(party, 0x23, 0x02);
            L00E7: AddEncounter(party, 0x23, 0x03);
            L00F9: goto L0143;
            L00FB: AddEncounter(party, 0x24, 0x01);
            L010D: AddEncounter(party, 0x24, 0x02);
            L011F: AddEncounter(party, 0x24, 0x03);
            L0131: AddEncounter(party, 0x24, 0x04);
            L0143: // RETURN;
        }

        private override MapEventHandler MapEvent12 => FnITEMCENC_12;
        private void FnITEMCENC_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x20);
            L0011: if (result.equal) goto L0065;
            L0013: ax = HasItem50(party, 0x95);
            L0021: if (result.equal) goto L0044;
            L0023: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x3F);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x95);
            L0063: goto L00B6;
            L0065: ax = HasItem50(party, 0x95);
            L0073: if (result.equal) goto L0096;
            L0075: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x20);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x95, 0x20);
            L00B6: ShowMessage(party, String0608); // Gruff laughter surrounds you.
            L00C3: ax = PartyCount(party);
            L00CB: compare(ax, 0x0001);
            L00CE: if (result.notequal) goto L00F7;
            L00D0: AddEncounter(party, 0x20, 0x01);
            L00E2: AddEncounter(party, 0x17, 0x02);
            L00F4: goto L01EE;
            L00F7: ax = PartyCount(party);
            L00FF: compare(ax, 0x0002);
            L0102: if (result.notequal) goto L013D;
            L0104: AddEncounter(party, 0x11, 0x01);
            L0116: AddEncounter(party, 0x0C, 0x02);
            L0128: AddEncounter(party, 0x0E, 0x03);
            L013A: goto L01EE;
            L013D: ax = PartyCount(party);
            L0145: compare(ax, 0x0003);
            L0148: if (result.notequal) goto L0194;
            L014A: AddEncounter(party, 0x1F, 0x01);
            L015C: AddEncounter(party, 0x0D, 0x02);
            L016E: AddEncounter(party, 0x0B, 0x03);
            L0180: AddEncounter(party, 0x04, 0x04);
            L0192: goto L01EE;
            L0194: AddEncounter(party, 0x1E, 0x01);
            L01A6: AddEncounter(party, 0x20, 0x02);
            L01B8: AddEncounter(party, 0x0B, 0x03);
            L01CA: AddEncounter(party, 0x0E, 0x04);
            L01DC: AddEncounter(party, 0x01, 0x05);
            L01EE: // RETURN;
        }

        private override MapEventHandler MapEvent13 => FnTELEPORT_13;
        private void FnTELEPORT_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0x54, 0x04, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnSTRSMESS_14;
        private void FnSTRSMESS_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0626); // The stairs through the south gateway lead upwards.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FnSTRSMESS_15;
        private void FnSTRSMESS_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0659); // Through the west gateway are stairs leading upwards.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent16 => FnSTRSMESS_16;
        private void FnSTRSMESS_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String068E); // The stairs through the north gateway lead upwards.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent17 => FnSTRSMESS_17;
        private void FnSTRSMESS_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06C1); // The stairs past the north gateway lead up a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent18 => FnTELEMESS_18;
        private void FnTELEMESS_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F4); // There is a teleport in the east wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent19 => FnTELEMESS_19;
        private void FnTELEMESS_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String071A); // There is a teleport in the west wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1A => FnTELEPORT_1A;
        private void FnTELEPORT_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0xDD, 0x03, 0x03);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent1B => FnTELEMESS_1B;
        private void FnTELEMESS_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0740); // There is a teleport in the west wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1C => FnNPCCHATA_1C;
        private void FnNPCCHATA_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0766); // You encounter a Gnome Thief.
            L0010: ShowPortrait(party, 0x0024);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0001);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0783); // There is more to this basement than first meets the eye. Someday I will learn the secret of what lies behind the thick, silent walls that line this corridor.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0821); // The Gnome Thief smiles enigmatically and ducks into the shadows.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1D => FnNPCCHATB_1D;
        private void FnNPCCHATB_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0862); // You encounter a Human Barbarian.
            L0010: ShowPortrait(party, 0x0016);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0883); // As much as I despise orcs, I sometimes find it useful to have them in my party. Indeed, you will frequently have to work with races and Guilds you would otherwise ignore, if you wish to solve the many mysteries of this dungeon.
            L003C: goto L0058;
            L003E: DoDamage90(party, 0x000A);
            L004B: ShowMessage(party, String0967); // The Human Barbarian raps you with his club and trudges away.
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent1E => FnNPCCHATC_1E;
        private void FnNPCCHATC_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A4); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0006);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String09C1); // A colleague told me he encountered a strange elfin race far down in the dungeon. He would not say much else, other than that he knew why cold-loving creatures were to be found inside a volcano.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0A83); // The Orc Knight bows graciously and walks away.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1F => FnNPCCHATD_1F;
        private void FnNPCCHATD_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AB2); // You encounter an Elf Cleric.
            L0010: ShowPortrait(party, 0x0027);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0007);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0ACF); // I stumbled over a marble block not long ago. On it were the words - Arnakkian Slowfoot, Wizard to the King.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0B3B); // The Elf Cleric sighs mournfully and massages a stubbed toe.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent20 => FnNPCCHATE_20;
        private void FnNPCCHATE_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B77); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0008);
            L002D: if (result.unsigned_greater_than) goto L004B;
            L002F: ShowMessage(party, String0B94); // To the east of the Rune Room on level three can be found the Wizards' Challenge. It is quite a challenge, too.
            L003C: ShowMessage(party, String0C03); // I have found several short cuts in the Wizards' Challenge.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0C3E); // The Human Thief points at something behind you. While your back is turned, she sneaks away.
            L0058: // RETURN;
        }

    }
}