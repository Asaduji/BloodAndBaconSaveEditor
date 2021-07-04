namespace BloodAndBaconSaveEditor.Structs
{
    public struct UnlockedHats
    {
        public UnlockedHats(byte bitfield1, byte bitfield2)
        {
            //Hats 1
            GasMask = (bitfield1 & 1) != 0;
            WizardHat = (bitfield1 & 2) != 0;
            GermanHelmut = (bitfield1 & 4) != 0;
            TractorCap = (bitfield1 & 8) != 0;
            RussianBol = (bitfield1 & 16) != 0;
            CowboyHat = (bitfield1 & 32) != 0;
            TopHat = (bitfield1 & 64) != 0;
            
            //Hats 2
            BowlerHat = (bitfield2 & 1) != 0;
            IrishTweed = (bitfield2 & 2) != 0;
            PeruvianPom = (bitfield2 & 4) != 0;
            SnowCap = (bitfield2 & 8) != 0;
            Macarthur = (bitfield2 & 16) != 0;
            RedsunHat = (bitfield2 & 32) != 0;
            ElfinHat = (bitfield2 & 64) != 0;
            Pumpkin = (bitfield2 & 128) != 0;
        }
        
        //Hats 1
        public bool GasMask;
        public bool WizardHat;
        public bool GermanHelmut;
        public bool TractorCap;
        public bool RussianBol;
        public bool CowboyHat;
        public bool TopHat;
        
        //Hats 2
        public bool BowlerHat;
        public bool IrishTweed;
        public bool PeruvianPom;
        public bool SnowCap;
        public bool Macarthur;
        public bool RedsunHat;
        public bool ElfinHat;
        public bool Pumpkin;

        public byte Hats1ToBitfield()
        {
            var bitfield = (byte) (GasMask ? 1 : 0);
            bitfield += (byte) (WizardHat ? 2 : 0);
            bitfield += (byte) (GermanHelmut ? 4 : 0);
            bitfield += (byte) (TractorCap ? 8 : 0);
            bitfield += (byte) (RussianBol ? 16 : 0);
            bitfield += (byte) (CowboyHat ? 32 : 0);
            bitfield += (byte) (TopHat ? 64 : 0);
            return bitfield;
        }

        public byte Hats2ToBitfield()
        {
            var bitfield = (byte) (BowlerHat ? 1 : 0);
            bitfield += (byte) (IrishTweed ? 2 : 0);
            bitfield += (byte) (PeruvianPom ? 4 : 0);
            bitfield += (byte) (SnowCap ? 8 : 0);
            bitfield += (byte) (Macarthur ? 16 : 0);
            bitfield += (byte) (RedsunHat ? 32 : 0);
            bitfield += (byte) (ElfinHat ? 64 : 0);
            bitfield += (byte) (Pumpkin ? 128 : 0);
            return bitfield;
        }
    }
}