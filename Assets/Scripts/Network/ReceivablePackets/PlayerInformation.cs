﻿/**
 * Author: Pantelis Andrianakis
 * Date: May 18th 2018
 */
public class PlayerInformation
{
    public static void Notify(ReceivablePacket packet)
    {
        long objectId = packet.ReadLong();
        CharacterDataHolder characterData = new CharacterDataHolder();
        characterData.SetName(packet.ReadString());
        characterData.SetRace((byte)packet.ReadByte());
        characterData.SetHeight(packet.ReadFloat());
        characterData.SetBelly(packet.ReadFloat());
        characterData.SetHairType((byte)packet.ReadByte());
        characterData.SetHairColor(packet.ReadInt());
        characterData.SetSkinColor(packet.ReadInt());
        characterData.SetEyeColor(packet.ReadInt());
        characterData.SetX(packet.ReadFloat());
        characterData.SetY(packet.ReadFloat());
        characterData.SetZ(packet.ReadFloat());
        characterData.SetHeading(packet.ReadFloat());

        WorldManager.Instance.UpdateObject(objectId, characterData);
    }
}
