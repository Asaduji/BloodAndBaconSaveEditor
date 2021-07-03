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
            Consumables = new Consumables(_grenadeCount, _milkCount, _bulkifyCount, _pillCount, _rocketCount);
        }
        
        public byte[] UnlockedDays = new byte[201]; //Total 201, the first byte is always 1 and is useless
        private int _unlockedWeaponsBitField;
        private int _grinderUnlocksBitField;
        public UnlockedWeapons UnlockedWeapons;
        public int UnlockedCharacters; //Useless, the game uses "UnlockedMan" for unlocked characters
        private byte _grenadeCount; //Max 10
        private byte _milkCount; //Max 10
        private byte _bulkifyCount; //Max 5
        private byte _pillCount; //Max 5
        private byte _rocketCount; //Max 2
        public Consumables Consumables;
        public byte UnlockedHats;
        public byte UnlockedHats2;
        public bool UnlockedSpecialCharacter1; //Special character, A Scarecrow
        public bool UnlockedSpecialCharacter2; //Special character, Toy Robot
        public bool UnlockedSpecialCharacter3; //Special character, The Golem
        public bool UnlockedSpecialCharacter4; //Special character, Astronaut
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
            _grenadeCount = reader.ReadByte();
            _milkCount = reader.ReadByte();
            _bulkifyCount = reader.ReadByte();
            _pillCount = reader.ReadByte();
            _rocketCount = reader.ReadByte();
            UnlockedHats = reader.ReadByte();
            UnlockedHats2 = reader.ReadByte();
            UnlockedSpecialCharacter1 = reader.ReadBoolean();
            UnlockedSpecialCharacter2 = reader.ReadBoolean();
            UnlockedSpecialCharacter3 = reader.ReadBoolean();
            UnlockedSpecialCharacter4 = reader.ReadBoolean();
            
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
            writer.Write(UnlockedWeapons.ToBitfield());
            writer.Write(_grinderUnlocksBitField);
            writer.Write(UnlockedCharacters);
            writer.Write(Consumables.Grenades);
            writer.Write(Consumables.Milk);
            writer.Write(Consumables.Bulkify);
            writer.Write(Consumables.Pills);
            writer.Write(Consumables.Rockets);
            writer.Write(UnlockedHats);
            writer.Write(UnlockedHats2);
            writer.Write(UnlockedSpecialCharacter1);
            writer.Write(UnlockedSpecialCharacter2);
            writer.Write(UnlockedSpecialCharacter3);
            writer.Write(UnlockedSpecialCharacter4);
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