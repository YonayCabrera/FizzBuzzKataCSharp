namespace gildedRoseKata{
    public class Backstage : OtherItems{
        
        private string name;
        private int sellIn;
        private int quality;
        public Backstage(string name,int sellIng, int quality){
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