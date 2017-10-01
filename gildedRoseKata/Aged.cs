namespace gildedRoseKata{
    public class Aged : OtherItems{
        
        private string name;
        private int sellIn;
        private int quality;
        public Aged(string name,int sellIng, int quality){
            this.name = name;
            this.quality = quality;
            this.sellIn = sellIng;
        }
        
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        
        public override void UpdateQuality(){
            throw new System.NotImplementedException();
        }
    }
}