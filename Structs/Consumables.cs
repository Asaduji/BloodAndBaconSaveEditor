namespace BloodAndBaconSaveEditor.Structs
{
    public struct Consumables
    {
        public Consumables(byte grenades, byte milk, byte bulkify, byte pills, byte rockets)
        {
            Grenades = grenades;
            Milk = milk;
            Bulkify = bulkify;
            Pills = pills;
            Rockets = rockets;
        }
        public byte Grenades;
        public byte Milk;
        public byte Bulkify;
        public byte Pills;
        public byte Rockets;
    }
}
