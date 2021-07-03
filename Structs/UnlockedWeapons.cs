namespace BloodAndBaconSaveEditor.Structs
{
    public struct UnlockedWeapons
    {
        public UnlockedWeapons(int bitfield)
        {
            Colt = (bitfield & 1) != 0; 
            Deagle = (bitfield & 2) != 0; //NOTE: even if we set the deagle as locked, the game will automatically unlock it
            SilencedPistol = (bitfield & 4) != 0;
            Ak47 = (bitfield & 8) != 0;
            Shotgun = (bitfield & 16) != 0;
            M16 = (bitfield & 32) != 0;
            Uzi = (bitfield & 64) != 0;
            RocketLauncher = (bitfield & 128) != 0;
            PaintGun = (bitfield & 256) != 0;
            P90 = (bitfield & 512) != 0;
        }
        
        //Primary weapons
        public bool Ak47;
        public bool Shotgun;
        public bool M16;
        public bool Uzi;
        public bool RocketLauncher;
        public bool P90;
        
        //Secondary weapons
        public bool Deagle;
        public bool Colt;
        public bool SilencedPistol;
        public bool PaintGun;

        public int ToBitfield()
        {
            var bitfield = Colt ? 1 : 0;
            bitfield += Deagle ? 2 : 0;
            bitfield += SilencedPistol ? 4 : 0;
            bitfield += Ak47 ? 8 : 0;
            bitfield += Shotgun ? 16 : 0;
            bitfield += M16 ? 32 : 0;
            bitfield += Uzi ? 64 : 0;
            bitfield += RocketLauncher ? 128 : 0;
            bitfield += PaintGun ? 256 : 0;
            bitfield += P90 ? 512 : 0;
            return bitfield;
        }
    }
}