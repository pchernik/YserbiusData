namespace ZCF.Scripts.Maps {
    class YserMap09 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "The E Rune Key unlocked the thick door.";
        private const string String0424 = "The door is locked.  You need a special key.";
        private const string String0451 = "The room is crawling with Spinorpions.";
        private const string String0478 = "You are trapped by angry Ogres.";
        private const string String0498 = "Nasty Ogres contemptuously flick gold coins at you.";
        private const string String04CC = "A painful nip at your ankle warns you of great danger.";
        private const string String0503 = "The E Vowel Key fades away when you enter the room.";
        private const string String0537 = "Behind a writhing mass of ill-tempered snakes lies King Cleowyn's Robe.";
        private const string String057F = "Hobgoblins are waiting for you.";
        private const string String059F = "Hobgoblins throw items aside so they can attack you.";
        private const string String05D4 = "You encounter a lost band of Silver Ogres.";
        private const string String05FF = "East past the gateway are stairs leading down a level.";
        private const string String0636 = "A Halfling Cleric creeps out of the shadows.";
        private const string String0663 = "You will need Cleowyn's Robe, Crown and Scepter to reach his hidden tomb in the Mausoleum.";
        private const string String06BE = "The Halfling Cleric mumbles something incoherent and creeps back into the shadows.";
        private const string String0711 = "A half-mad Gnome Thief crawls into the room.";
        private const string String073E = "The wizard Arnakkian hired his own troops from the Snow Elves. It is said that these strange elves disappeared before the volcano erupted. Where they wound up is anybody's guess.";
        private const string String07F1 = "The insane Gnome Thief crawls away.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnSTRSTELE_01;
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0xD7, 0x01, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnKEYDOOR_02;
        private void FnKEYDOOR_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xDB, 0xDB);
            L0016: if (result.equal) goto L0063;
            L0018: Push(01);
            L001C: ax = GetFacing24(party);
            L0023: PushStack(ax);
            L0024: ax = GetNextTile20(party);
            L002B: PushStack(ax);
            L002C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: Push(01);
            L004A: SetUnblocked30(party);
            L0054: ShowMessage(party, String03FC); // The E Rune Key unlocked the thick door.
            L0061: goto L008D;
            L0063: PushStack(0x00);
            L0066: ax = GetFacing24(party);
            L006D: PushStack(ax);
            L006E: ax = GetNextTile20(party);
            L0075: PushStack(ax);
            L0076: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0080: ShowMessage(party, String0424); // The door is locked.  You need a special key.
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnGOLDAENC_03;
        private void FnGOLDAENC_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x19);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L003A;
            L0019: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xAD);
            L0038: goto L006E;
            L003A: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0059: SetState00(party, 0x02, 0x19, 0x01);
            L006E: ShowMessage(party, String0451); // The room is crawling with Spinorpions.
            L007B: ax = PartyCount(party);
            L0083: compare(ax, 0x0001);
            L0086: if (result.notequal) goto L009D;
            L0088: AddEncounter(party, 0x1E, 0x01);
            L009A: goto L0137;
            L009D: ax = PartyCount(party);
            L00A5: compare(ax, 0x0002);
            L00A8: if (result.equal) goto L00B7;
            L00AA: ax = PartyCount(party);
            L00B2: compare(ax, 0x0003);
            L00B5: if (result.notequal) goto L00EF;
            L00B7: AddEncounter(party, 0x1E, 0x01);
            L00C9: AddEncounter(party, 0x1E, 0x02);
            L00DB: AddEncounter(party, 0x1E, 0x04);
            L00ED: goto L0137;
            L00EF: AddEncounter(party, 0x1E, 0x01);
            L0101: AddEncounter(party, 0x1E, 0x02);
            L0113: AddEncounter(party, 0x20, 0x03);
            L0125: AddEncounter(party, 0x21, 0x04);
            L0137: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnGOLDBENC_04;
        private void FnGOLDBENC_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x1A);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String0478); // You are trapped by angry Ogres.
            L0026: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0066: SetState00(party, 0x02, 0x1A, 0x01);
            L007B: ShowMessage(party, String0498); // Nasty Ogres contemptuously flick gold coins at you.
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00AA;
            L0095: AddEncounter(party, 0x19, 0x01);
            L00A7: goto L0168;
            L00AA: ax = PartyCount(party);
            L00B2: compare(ax, 0x0002);
            L00B5: if (result.equal) goto L00C4;
            L00B7: ax = PartyCount(party);
            L00BF: compare(ax, 0x0003);
            L00C2: if (result.notequal) goto L010E;
            L00C4: AddEncounter(party, 0x1A, 0x01);
            L00D6: AddEncounter(party, 0x1A, 0x02);
            L00E8: AddEncounter(party, 0x19, 0x03);
            L00FA: AddEncounter(party, 0x19, 0x04);
            L010C: goto L0168;
            L010E: AddEncounter(party, 0x1A, 0x01);
            L0120: AddEncounter(party, 0x1A, 0x02);
            L0132: AddEncounter(party, 0x19, 0x03);
            L0144: AddEncounter(party, 0x19, 0x05);
            L0156: AddEncounter(party, 0x1C, 0x06);
            L0168: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnCROWNENC_05;
        private void FnCROWNENC_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x78);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0032: ShowMessage(party, String04CC); // A painful nip at your ankle warns you of great danger.
            L003F: goto L0087;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xCF, 0x78);
            L0061: RemoveItem4C(party, 0xDB);
            L006D: ShowMessage(party, String0503); // The E Vowel Key fades away when you enter the room.
            L007A: ShowMessage(party, String0537); // Behind a writhing mass of ill-tempered snakes lies King Cleowyn's Robe.
            L0087: ax = PartyCount(party);
            L008F: compare(ax, 0x0001);
            L0092: if (result.notequal) goto L00BB;
            L0094: AddEncounter(party, 0x23, 0x01);
            L00A6: AddEncounter(party, 0x23, 0x02);
            L00B8: goto L01E8;
            L00BB: ax = PartyCount(party);
            L00C3: compare(ax, 0x0002);
            L00C6: if (result.notequal) goto L0113;
            L00C8: AddEncounter(party, 0x23, 0x01);
            L00DA: AddEncounter(party, 0x23, 0x02);
            L00EC: AddEncounter(party, 0x23, 0x03);
            L00FE: AddEncounter(party, 0x1E, 0x06);
            L0110: goto L01E8;
            L0113: ax = PartyCount(party);
            L011B: compare(ax, 0x0003);
            L011E: if (result.notequal) goto L017C;
            L0120: AddEncounter(party, 0x23, 0x01);
            L0132: AddEncounter(party, 0x23, 0x02);
            L0144: AddEncounter(party, 0x23, 0x03);
            L0156: AddEncounter(party, 0x23, 0x04);
            L0168: AddEncounter(party, 0x1E, 0x05);
            L017A: goto L01E8;
            L017C: AddEncounter(party, 0x23, 0x01);
            L018E: AddEncounter(party, 0x23, 0x02);
            L01A0: AddEncounter(party, 0x23, 0x03);
            L01B2: AddEncounter(party, 0x23, 0x04);
            L01C4: AddEncounter(party, 0x20, 0x05);
            L01D6: AddEncounter(party, 0x20, 0x06);
            L01E8: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnITEMBENC_06;
        private void FnITEMBENC_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x1B);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String057F); // Hobgoblins are waiting for you.
            L0026: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xB6, 0x3D);
            L0067: SetState00(party, 0x02, 0x1B, 0x01);
            L007C: ShowMessage(party, String059F); // Hobgoblins throw items aside so they can attack you.
            L0089: ax = PartyCount(party);
            L0091: compare(ax, 0x0001);
            L0094: if (result.notequal) goto L00BD;
            L0096: AddEncounter(party, 0x01, 0x01);
            L00A8: AddEncounter(party, 0x02, 0x02);
            L00BA: goto L01EA;
            L00BD: ax = PartyCount(party);
            L00C5: compare(ax, 0x0002);
            L00C8: if (result.notequal) goto L0115;
            L00CA: AddEncounter(party, 0x01, 0x01);
            L00DC: AddEncounter(party, 0x02, 0x02);
            L00EE: AddEncounter(party, 0x02, 0x03);
            L0100: AddEncounter(party, 0x01, 0x04);
            L0112: goto L01EA;
            L0115: ax = PartyCount(party);
            L011D: compare(ax, 0x0003);
            L0120: if (result.notequal) goto L017E;
            L0122: AddEncounter(party, 0x04, 0x01);
            L0134: AddEncounter(party, 0x03, 0x02);
            L0146: AddEncounter(party, 0x03, 0x03);
            L0158: AddEncounter(party, 0x04, 0x04);
            L016A: AddEncounter(party, 0x01, 0x05);
            L017C: goto L01EA;
            L017E: AddEncounter(party, 0x08, 0x01);
            L0190: AddEncounter(party, 0x08, 0x02);
            L01A2: AddEncounter(party, 0x04, 0x03);
            L01B4: AddEncounter(party, 0x04, 0x04);
            L01C6: AddEncounter(party, 0x03, 0x05);
            L01D8: AddEncounter(party, 0x03, 0x06);
            L01EA: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnITEMCENC_07;
        private void FnITEMCENC_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x07);
            L0011: if (result.equal) goto L0065;
            L0013: ax = HasItem50(party, 0x90);
            L0021: if (result.equal) goto L0044;
            L0023: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0x90);
            L0063: goto L00B6;
            L0065: ax = HasItem50(party, 0x90);
            L0073: if (result.equal) goto L0096;
            L0075: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x00, 0x07);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x90, 0x07);
            L00B6: ShowMessage(party, String05D4); // You encounter a lost band of Silver Ogres.
            L00C3: ax = PartyCount(party);
            L00CB: compare(ax, 0x0001);
            L00CE: if (result.notequal) goto L00E5;
            L00D0: AddEncounter(party, 0x1D, 0x01);
            L00E2: goto L017F;
            L00E5: ax = PartyCount(party);
            L00ED: compare(ax, 0x0002);
            L00F0: if (result.equal) goto L00FF;
            L00F2: ax = PartyCount(party);
            L00FA: compare(ax, 0x0003);
            L00FD: if (result.notequal) goto L0137;
            L00FF: AddEncounter(party, 0x1D, 0x01);
            L0111: AddEncounter(party, 0x1D, 0x02);
            L0123: AddEncounter(party, 0x1D, 0x03);
            L0135: goto L017F;
            L0137: AddEncounter(party, 0x1D, 0x01);
            L0149: AddEncounter(party, 0x1D, 0x02);
            L015B: AddEncounter(party, 0x1D, 0x03);
            L016D: AddEncounter(party, 0x1D, 0x04);
            L017F: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnSTRMNSTR_08;
        private void FnSTRMNSTR_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: AddEncounter(party, 0x1B, 0x02);
            L0034: goto L0164;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L008F;
            L0044: AddEncounter(party, 0x1B, 0x01);
            L0056: AddEncounter(party, 0x1B, 0x02);
            L0068: AddEncounter(party, 0x1A, 0x03);
            L007A: AddEncounter(party, 0x1A, 0x04);
            L008C: goto L0164;
            L008F: ax = PartyCount(party);
            L0097: compare(ax, 0x0003);
            L009A: if (result.notequal) goto L00F8;
            L009C: AddEncounter(party, 0x1C, 0x01);
            L00AE: AddEncounter(party, 0x1C, 0x02);
            L00C0: AddEncounter(party, 0x19, 0x03);
            L00D2: AddEncounter(party, 0x19, 0x04);
            L00E4: AddEncounter(party, 0x1D, 0x05);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x1D, 0x01);
            L010A: AddEncounter(party, 0x1D, 0x02);
            L011C: AddEncounter(party, 0x1D, 0x03);
            L012E: AddEncounter(party, 0x1D, 0x04);
            L0140: AddEncounter(party, 0x1C, 0x05);
            L0152: AddEncounter(party, 0x1C, 0x06);
            L0164: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnTUFMNSTR_09;
        private void FnTUFMNSTR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x1F, 0x01);
            L0022: goto L00E3;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.equal) goto L003F;
            L0032: ax = PartyCount(party);
            L003A: compare(ax, 0x0003);
            L003D: if (result.notequal) goto L0089;
            L003F: AddEncounter(party, 0x20, 0x01);
            L0051: AddEncounter(party, 0x20, 0x02);
            L0063: AddEncounter(party, 0x1F, 0x03);
            L0075: AddEncounter(party, 0x1F, 0x04);
            L0087: goto L00E3;
            L0089: AddEncounter(party, 0x22, 0x01);
            L009B: AddEncounter(party, 0x22, 0x02);
            L00AD: AddEncounter(party, 0x21, 0x03);
            L00BF: AddEncounter(party, 0x21, 0x04);
            L00D1: AddEncounter(party, 0x22, 0x05);
            L00E3: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnVTFMNSTR_0A;
        private void FnVTFMNSTR_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x23, 0x01);
            L0022: goto L012E;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L006B;
            L0032: AddEncounter(party, 0x23, 0x01);
            L0044: AddEncounter(party, 0x23, 0x02);
            L0056: AddEncounter(party, 0x23, 0x03);
            L0068: goto L012E;
            L006B: ax = PartyCount(party);
            L0073: compare(ax, 0x0003);
            L0076: if (result.notequal) goto L00C2;
            L0078: AddEncounter(party, 0x23, 0x01);
            L008A: AddEncounter(party, 0x23, 0x02);
            L009C: AddEncounter(party, 0x23, 0x03);
            L00AE: AddEncounter(party, 0x23, 0x04);
            L00C0: goto L012E;
            L00C2: AddEncounter(party, 0x23, 0x01);
            L00D4: AddEncounter(party, 0x23, 0x02);
            L00E6: AddEncounter(party, 0x23, 0x03);
            L00F8: AddEncounter(party, 0x23, 0x04);
            L010A: AddEncounter(party, 0x23, 0x05);
            L011C: AddEncounter(party, 0x23, 0x06);
            L012E: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnSTRSMESS_0B;
        private void FnSTRSMESS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05FF); // East past the gateway are stairs leading down a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnNPCCHATA_0C;
        private void FnNPCCHATA_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0636); // A Halfling Cleric creeps out of the shadows.
            L0010: ShowPortrait(party, 0x0029);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0663); // You will need Cleowyn's Robe, Crown and Scepter to reach his hidden tomb in the Mausoleum.
            L003C: goto L004B;
            L003E: ShowMessage(party, String06BE); // The Halfling Cleric mumbles something incoherent and creeps back into the shadows.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnNPCCHATB_0D;
        private void FnNPCCHATB_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0711); // A half-mad Gnome Thief crawls into the room.
            L0010: ShowPortrait(party, 0x0024);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000A);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String073E); // The wizard Arnakkian hired his own troops from the Snow Elves. It is said that these strange elves disappeared before the volcano erupted. Where they wound up is anybody's guess.
            L003C: goto L004B;
            L003E: ShowMessage(party, String07F1); // The insane Gnome Thief crawls away.
            L004B: // RETURN;
        }

    }
}