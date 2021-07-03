using System.IO;
using BloodAndBaconSaveEditor.Structs;

namespace BloodAndBaconSaveEditor.Saves
{
    public class GameSave
    {
        public GameSave(byte[] bytes)
        {
            ReadBytes(bytes);
            UnlockedWeapons = new UnlockedWeapons(_unlockedWeaponsBitField);
        }
        
        public byte[] UnlockedDays = new byte[201]; //Total 201
        private int _unlockedWeaponsBitField;
        private int _grinderUnlocksBitField;
        public UnlockedWeapons UnlockedWeapons;
        public int UnlockedCharacters; //Useless, the game uses "UnlockedMan" for unlocked characters
        public byte GrenadeCount; //Max 10
        public byte MilkCount; //Max 10
        public byte BulkifyCount; //Max 5
        public byte PillCount; //Max 5
        public byte RocketCount; //Max 2
        public byte UnlockedHats;
        public byte UnlockedHats2;
        public bool UnlockedMan1; //Special character
        public bool UnlockedMan2; //Special character
        public bool UnlockedMan3; //Special character
        public bool UnlockedMan4; //Special character
        public byte[] Flashlight = new byte[3]; //3
        public byte Googles;
        public byte[] UnlockedMaps = new byte[20]; //Total 20
        public byte[] AmmoBox1 = new byte[20]; //Total 20
        public byte[] AmmoBox2 = new byte[20]; //Total 20
        public byte[] AmmoBox3 = new byte[20]; //Total 20
        public byte[] Cog1 = new byte[20]; //Total 20 - If code is unlocked for specific maze
        public byte[] Cog2 = new byte[20]; //Total 20 - If code is unlocked for specific maze
        public byte[] Cog3 = new byte[20]; //Total 20 - If code is unlocked for specific maze
        public byte[] ExitKey = new byte[20]; //Total 20 - To exit expeditions
        public byte[,] Code1 = new byte[20, 3]; //Total 20 - To open doors at expeditions, codes
        public byte[,] Code2 = new byte[20, 3]; //Total 20 - To open doors at expeditions, codes
        public byte[,] Code3 = new byte[20, 3]; //Total 20 - To open doors at expeditions, codes
        public byte RedSkull1; //Collectible
        public byte RedSkull2; //Collectible
        public byte RedSkull3; //Collectible
        public byte Tusk1; //Collectible
        public byte Tusk2; //Collectible
        public byte Tusk3; //Collectible
        public byte[] Heirloom = new byte[7]; //Total 7 - No idea what this is
        
        private void ReadBytes(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            using var reader = new BinaryReader(ms);

            reader.ReadBoolean(); //If file exists, totally useless
            reader.ReadSingle(); //File version

            //Unlocked days
            for (var i = 0; i < UnlockedDays.Length; i++)
            {
                UnlockedDays[i] = reader.ReadByte();
            }

            _unlockedWeaponsBitField = reader.ReadInt32();
            _grinderUnlocksBitField = reader.ReadInt32();
            UnlockedCharacters = reader.ReadInt32();
            GrenadeCount = reader.ReadByte();
            MilkCount = reader.ReadByte();
            BulkifyCount = reader.ReadByte();
            PillCount = reader.ReadByte();
            RocketCount = reader.ReadByte();
            UnlockedHats = reader.ReadByte();
            UnlockedHats2 = reader.ReadByte();
            UnlockedMan1 = reader.ReadBoolean();
            UnlockedMan2 = reader.ReadBoolean();
            UnlockedMan3 = reader.ReadBoolean();
            UnlockedMan4 = reader.ReadBoolean();
            
            //Flashlights
            for (var i = 0; i < Flashlight.Length; i++)
            {
                Flashlight[i] = reader.ReadByte();
            }
            
            //Maps
            for (var i = 0; i < UnlockedMaps.Length; i++)
            {
                UnlockedMaps[i] = reader.ReadByte();
            }
            
            //Ammo box 1
            for (var i = 0; i < AmmoBox1.Length; i++)
            {
                AmmoBox1[i] = reader.ReadByte();
            }
            
            //Ammo box 2
            for (var i = 0; i < AmmoBox2.Length; i++)
            {
                AmmoBox2[i] = reader.ReadByte();
            }
            
            //Ammo box 3
            for (var i = 0; i < AmmoBox3.Length; i++)
            {
                AmmoBox3[i] = reader.ReadByte();
            }
            
            //Cog 1
            for (var i = 0; i < Cog1.Length; i++)
            {
                Cog1[i] = reader.ReadByte();
            }
            
            //Cog 2
            for (var i = 0; i < Cog2.Length; i++)
            {
                Cog2[i] = reader.ReadByte();
            }
            
            //Cog 3
            for (var i = 0; i < Cog3.Length; i++)
            {
                Cog3[i] = reader.ReadByte();
            }
            
            //Exit keys
            for (var i = 0; i < ExitKey.Length; i++)
            {
                ExitKey[i] = reader.ReadByte();
            }
            
            //Codes
            for (var i = 0; i < 20; i++)
            {
                //Code 1
                for (var c = 0; c < 3; c++)
                {
                    Code1[i, c] = reader.ReadByte();
                }
                
                //Code 2
                for (var c = 0; c < 3; c++)
                {
                    Code2[i, c] = reader.ReadByte();
                }
                
                //Code 3
                for (var c = 0; c < 3; c++)
                {
                    Code3[i, c] = reader.ReadByte();
                }
            }

            RedSkull1 = reader.ReadByte();
            RedSkull2 = reader.ReadByte();
            RedSkull3 = reader.ReadByte();
            Tusk1 = reader.ReadByte();
            Tusk2 = reader.ReadByte();
            Tusk3 = reader.ReadByte();
            
            //Heirloom
            for (var i = 0; i < Heirloom.Length; i++)
            {
                Heirloom[i] = reader.ReadByte();
            }
        }

        public byte[] GetBytes()
        {
            using var ms = new MemoryStream();
            using var writer = new BinaryWriter(ms);
            writer.Write(true); //If file exists, totally useless
            writer.Write(48f); //File version
            
            //Write days
            writer.Write(UnlockedDays);
            /*
            for (var i = 0; i < UnlockedDays.Length; i++)
            {
                
            }
            */

            writer.Write(UnlockedWeapons.ToBitfield());
            writer.Write(_grinderUnlocksBitField);
            writer.Write(UnlockedCharacters);
            writer.Write(GrenadeCount);
            writer.Write(MilkCount);
            writer.Write(BulkifyCount);
            writer.Write(PillCount);
            writer.Write(RocketCount);
            writer.Write(UnlockedHats);
            writer.Write(UnlockedHats2);
            writer.Write(UnlockedMan1);
            writer.Write(UnlockedMan2);
            writer.Write(UnlockedMan3);
            writer.Write(UnlockedMan4);
            writer.Write(Flashlight);
            writer.Write(Googles);
            writer.Write(UnlockedMaps);
            writer.Write(AmmoBox1);
            writer.Write(AmmoBox2);
            writer.Write(AmmoBox3);
            writer.Write(Cog1);
            writer.Write(Cog2);
            writer.Write(Cog3);
            writer.Write(ExitKey);
            
            //Write codes
            for (var i = 0; i < 20; i++)
            {
                //Code 1
                for (var c = 0; c < 3; c++)
                {
                    writer.Write(Code1[i, c]);
                }
                
                //Code 2
                for (var c = 0; c < 3; c++)
                {
                    writer.Write(Code2[i, c]);
                }
                
                //Code 3
                for (var c = 0; c < 3; c++)
                {
                    writer.Write(Code3[i, c]);
                }
            }
            
            writer.Write(RedSkull1);
            writer.Write(RedSkull2);
            writer.Write(RedSkull3);
            writer.Write(Tusk1);
            writer.Write(Tusk2);
            writer.Write(Tusk3);
            writer.Write(Heirloom);
            
            return ms.ToArray();
        }
    }
}